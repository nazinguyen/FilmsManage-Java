Create database FilmsDb
use FilmsDb

Create table LoaiPhim(
	MaTheLoai int identity(1,1)  primary key ,
	TenTheLoai nvarchar(100) not null
);
Create table ManHinh(
	MaManHinh int identity(1,1) primary key,
	TenManHinh nvarchar(100) not null
);
Create table DangPhim(
	MaDangPhim int identity(1,1) primary key,
	TenDangPhim nvarchar(100) not null,
	MaManHinh int not null,

	foreign key (MaManHinh) references ManHinh(MaManHinh)
);


Create table Phim(
	MaPhim int identity(1,1) primary key,
	TenPhim nvarchar(255) not null,
	GhiChu nvarchar(500) not null,
	Mota nvarchar(max) not null,
	NoiDung nvarchar(max) not null,
	ThoiLuong int not null,
	NgayKC Date not null,
	NgayKT Date not null,
	DoTuoi int not null,
	AnhBia varchar(255)  not null,
	TenDaoDien nvarchar(100) not null,
	MaDangPhim int not null,

	foreign key (MaDangPhim) references DangPhim(MaDangPhim),
	Check(ThoiLuong > 0),
	Check(NgayKC <= NgayKT),
	Check(DoTuoi > 0)

);

Create table TheLoaiCuaPhim(
	Maphim int not null,
	MaTheLoai int not null,

	primary key(MaPhim, MaTheLoai),
	foreign key (MaPhim) references Phim(MaPhim),
	foreign key (MaTheLoai) references LoaiPhim(MaTheLoai)


);
ALTER TABLE TheLoaiCuaPhim
ADD Id INT IDENTITY(1,1) NOT NULL;


CREATE TABLE PhongChieu (
    MaPhongChieu INT IDENTITY(1, 1) PRIMARY KEY,
    SoGhe INT NOT NULL,
    SoGheMotHang INT NOT NULL,
    SoHangGhe INT NOT NULL,
    MaManHinh INT NOT NULL,
    FOREIGN KEY (MaManHinh) REFERENCES ManHinh(MaManHinh),
    CHECK (SoGhe > 0 AND SoGheMotHang > 0 AND SoHangGhe > 0)
);
ALTER TABLE PhongChieu
ADD TenPhongChieu NVARCHAR(100) NOT NULL;


CREATE TRIGGER trg_Calculate_SoHangGhe
ON PhongChieu
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE pc
    SET SoHangGhe = CASE
                        WHEN i.SoGhe % i.SoGheMotHang = 0 THEN i.SoGhe / i.SoGheMotHang
                        ELSE (i.SoGhe / i.SoGheMotHang) + 1
                    END
    FROM PhongChieu pc
    INNER JOIN Inserted i ON pc.MaPhongChieu = i.MaPhongChieu;
END;


Create table LoaiGhe(
	MaLoai int identity(1,1) primary key,
	TenLoaiGhe varchar(20) not null
);

Create table Ghe(
	MaGhe int identity(1,1) primary key,
	TrangThai bit not null,
	MaPhong int not null,
	MaLoaiGhe int not null,

	foreign key (MaPhong) references PhongChieu(MaPhongChieu),
	foreign key (MaLoaiGhe) references LoaiGhe(MaLoai)
);

Create table XuatChieu(
	MaXuatChieu int identity(1,1) primary key,
	ThoiGianBatDau date not null,
	ThoiGianKetThuc date not null,
	MaPhong int not null,
	MaPhim int not null,

	foreign key (MaPhong) references PhongChieu(MaPhongChieu),
	foreign key (MaPhim) references Phim(MaPhim),

	Check(ThoiGianBatDau < ThoiGianKetThuc)
);

ALTER TRIGGER trg_XuatChieu_Validation
ON XuatChieu
INSTEAD OF INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Khai báo các biến tạm
    DECLARE @MaPhim INT, @MaPhong INT, @ThoiGianBatDau DATETIME, @ThoiGianKetThuc DATETIME;

    -- Lấy dữ liệu từ bản ghi được thêm hoặc cập nhật
    SELECT 
        @MaPhim = MaPhim,
        @MaPhong = MaPhong,
        @ThoiGianBatDau = ThoiGianBatDau,
        @ThoiGianKetThuc = ThoiGianKetThuc
    FROM inserted;

    -- 1. Kiểm tra thời gian bắt đầu phải >= thời gian hiện tại
    IF (@ThoiGianBatDau < GETDATE())
    BEGIN
        THROW 50001, 'Thời gian bắt đầu phải lớn hơn hoặc bằng thời gian hiện tại.', 1;
    END;

    -- 2. Kiểm tra thời gian kết thúc phải lớn hơn thời gian bắt đầu
    IF (@ThoiGianKetThuc <= @ThoiGianBatDau)
    BEGIN
        THROW 50002, 'Thời gian kết thúc phải lớn hơn thời gian bắt đầu.', 1;
    END;

    -- 3. Phòng chỉ chiếu một phim trong một khoảng thời gian
    IF EXISTS (
        SELECT 1
        FROM XuatChieu
        WHERE MaPhong = @MaPhong
          AND (ThoiGianBatDau < @ThoiGianKetThuc AND ThoiGianKetThuc > @ThoiGianBatDau)
    )
    BEGIN
        THROW 50003, 'Phòng chiếu đã được sử dụng cho một phim khác trong khoảng thời gian này.', 1;
    END;

    -- 4. Kiểm tra trùng lặp suất chiếu (cùng phim, cùng phòng, cùng thời gian)
    IF EXISTS (
        SELECT 1
        FROM XuatChieu
        WHERE MaPhim = @MaPhim 
          AND MaPhong = @MaPhong
          AND ThoiGianBatDau = @ThoiGianBatDau 
          AND ThoiGianKetThuc = @ThoiGianKetThuc
    )
    BEGIN
        THROW 50004, 'Suất chiếu bị trùng lặp.', 1;
    END;

    -- 5. Giới hạn số suất chiếu trong một ngày cho một phòng
    IF (
        SELECT COUNT(*)
        FROM XuatChieu
        WHERE MaPhong = @MaPhong
          AND CAST(ThoiGianBatDau AS DATE) = CAST(@ThoiGianBatDau AS DATE)
    ) >= 10
    BEGIN
        THROW 50005, 'Phòng chiếu đã đạt giới hạn số suất chiếu trong ngày.', 1;
    END;

    -- Thêm hoặc cập nhật bản ghi vào bảng XuatChieu
    IF EXISTS (SELECT 1 FROM inserted WHERE MaXuatChieu IS NOT NULL)
    BEGIN
        -- Thực hiện cập nhật
        UPDATE XuatChieu
        SET 
            MaPhim = @MaPhim,
            MaPhong = @MaPhong,
            ThoiGianBatDau = @ThoiGianBatDau,
            ThoiGianKetThuc = @ThoiGianKetThuc
        WHERE MaXuatChieu = (SELECT TOP 1 MaXuatChieu FROM inserted);
    END
    ELSE
    BEGIN
        -- Thực hiện thêm mới
        INSERT INTO XuatChieu (MaPhim, MaPhong, ThoiGianBatDau, ThoiGianKetThuc)
        VALUES (@MaPhim, @MaPhong, @ThoiGianBatDau, @ThoiGianKetThuc);
    END;
END;



Create table KhachHang(
	MaKH int identity(1,1) primary key,
	TenKH nvarchar(100),
	SDT varchar(20),
	Email varchar(100),
);

Create table TaiKhoan(
    MaTaiKhoan int identity(1,1) primary key,
    MaKH int not null,
    TenDangNhap varchar(50) not null unique,
    MatKhau varchar(50) not null,

    foreign key (MaKH) references KhachHang(MaKH)
);


Create table Quyen(
	MaQuyen int identity(1,1) primary key,
	TenQuyen nvarchar(50) not null
);


Create table NhanVien(
	MaNV int identity(1,1) primary key,
	TenNV nvarchar(200) not null,
	SDT varchar(20) not null,
	Email varchar(100) not null,
	MatKhau varchar(50) not null,
	MaQuyen int not null,

	foreign key (MaQuyen) references Quyen(MaQuyen)
);

Create table LoaiVe(
	MaLoai int identity(1,1) primary key,
	TenLoaiVe nvarchar(50) not null
);



Create table Ve(
	MaVe int identity(1,1) primary key,
	GiaVe decimal not null,
	TrangThai bit not null,
	MaLoaiVe int not null,
	MaGhe int not null,
	MaXuatChieu int not null,
	MaKH int not null,
	MaNV int not null,

	foreign key (MaLoaiVe) references LoaiVe(MaLoai),
	foreign key (MaGhe) references Ghe(MaGhe),
	foreign key (MaXuatChieu) references XuatChieu(MaXuatChieu),
	foreign key (MaKH) references KhachHang(MaKH),
	foreign key (MaNV) references NhanVien(MaNV),

	Check(GiaVe > 0)

);

Create table HoaDon(
	MaHD int identity(1,1) primary key,
	TongTien decimal not null check(TongTien > 0 ),
	MaNV int not null,

	foreign key (MaNV) references NhanVien(MaNV)

);

Create table ChiTietHoaDon(
	MaHD int not null,
	MaVe int not null,
	SoLuong int not null check(SoLuong > 0),
	ThanhTien decimal not null check(ThanhTien > 0),

	primary key (MaHD, MaVe),
	foreign key (MaHD) references HoaDon(MaHD),
	foreign key (MaVe) references Ve(MaVe),

);

create trigger trg_Calculate_ThanhTien_and_TongTien
on ChiTietHoaDon
after insert, update, delete
as
begin
    set nocount on;

    -- Tính toán Thành Tiền cho các bản ghi mới hoặc được cập nhật
    update cthd
    set ThanhTien = cthd.SoLuong * v.GiaVe
    from ChiTietHoaDon cthd
    inner join Ve v on cthd.MaVe = v.MaVe
    where exists (
        select 1
        from inserted i
        where cthd.MaHD = i.MaHD and cthd.MaVe = i.MaVe
    );

    -- Cập nhật Tổng Tiền cho các hóa đơn bị ảnh hưởng
    update hd
    set TongTien = (
        select sum(cthd.ThanhTien)
        from ChiTietHoaDon cthd
        where cthd.MaHD = hd.MaHD
    )
    from HoaDon hd
    where exists (
        select 1
        from inserted i
        where hd.MaHD = i.MaHD
    )
    or exists (
        select 1
        from deleted d
        where hd.MaHD = d.MaHD
    );
end;


