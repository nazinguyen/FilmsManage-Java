CREATE TABLE TinhTrang (
    MaTinhTrang INT IDENTITY(1,1) PRIMARY KEY,
    TenTinhTrang NVARCHAR(255) NOT NULL
);

CREATE TABLE DangPhim (
    MaDangPhim INT IDENTITY(1,1) PRIMARY KEY,
    TenDangPhim NVARCHAR(255) NOT NULL
);

CREATE TABLE LoaiGhe (
    MaLoaiGhe INT IDENTITY(1,1) PRIMARY KEY,
    TenLoaiGhe NVARCHAR(255) NOT NULL
);

CREATE TABLE PhongChieu (
    IdPhongChieu INT IDENTITY(1,1) PRIMARY KEY,
    TenPhongChieu NVARCHAR(255) NOT NULL
);

CREATE TABLE Ghe (
    SoGhe INT IDENTITY(1,1) PRIMARY KEY,
    MaPhong INT NOT NULL,
    TrangThaiGhe BIT NOT NULL,
    MaTinhTrang INT NOT NULL,
    MaLoaiGhe INT NOT NULL,
    FOREIGN KEY (MaPhong) REFERENCES PhongChieu(IdPhongChieu),
    FOREIGN KEY (MaTinhTrang) REFERENCES TinhTrang(MaTinhTrang),
    FOREIGN KEY (MaLoaiGhe) REFERENCES LoaiGhe(MaLoaiGhe)
);

CREATE TABLE Quyen (
    MaQuyen INT IDENTITY(1,1) PRIMARY KEY,
    TenQuyen NVARCHAR(255) NOT NULL
);

CREATE TABLE NhanVien (
    IdNhanVien INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(100) NOT NULL,
    MatKhau NVARCHAR(100) NOT NULL,
    TenNhanVien NVARCHAR(255) NOT NULL,
    GioiTinh BIT NOT NULL,
    NgaySinh DATETIME NOT NULL,
    MaQuyen INT NOT NULL,
    FOREIGN KEY (MaQuyen) REFERENCES Quyen(MaQuyen),
    CHECK(DATEDIFF(YEAR, NgaySinh, GETDATE()) >= 18)
);

CREATE TABLE QuocGia (
    IdQuocGia INT IDENTITY(1,1) PRIMARY KEY,
    TenNuoc NVARCHAR(255) NOT NULL
);

CREATE TABLE XuatChieu (
    MaXuatChieu INT IDENTITY(1,1) PRIMARY KEY,
    MaPhim INT NOT NULL,
    GioChieu INT NOT NULL,
    PhutChieu INT NOT NULL,
    IdPhongChieu INT NOT NULL,
    FOREIGN KEY (IdPhongChieu) REFERENCES PhongChieu(IdPhongChieu),
    CHECK(GioChieu BETWEEN 0 AND 23 AND PhutChieu BETWEEN 0 AND 59)
);

CREATE TABLE Gia (
    MaGia INT IDENTITY(1,1) PRIMARY KEY,
    SoTien DECIMAL(8, 2) NOT NULL,
    MaDangPhim INT NOT NULL,
    MaVe INT NOT NULL,
    IdLoaiGhe INT NOT NULL,
    FOREIGN KEY (MaDangPhim) REFERENCES DangPhim(MaDangPhim),
    FOREIGN KEY (IdLoaiGhe) REFERENCES LoaiGhe(MaLoaiGhe),
    CHECK(SoTien > 0)
);

CREATE TABLE KhachHang (
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(100) NOT NULL,
    NgaySinh DATETIME NOT NULL,
    DiaChi NVARCHAR(255) NOT NULL,
    SoDienThoai NVARCHAR(50) NOT NULL,
    Email NVARCHAR(255),
    GioiTinh BIT NOT NULL,
    MatKhau NVARCHAR(100) NOT NULL,
    CHECK(NgaySinh < GETDATE()),
    CHECK(SoDienThoai LIKE '[0-9]%'),
    CHECK(Email LIKE '%_@__%.__%')
);

CREATE TABLE LoaiPhim (
    MaLoaiPhim INT IDENTITY(1,1) PRIMARY KEY,
    TenLoaiPhim NVARCHAR(255) NOT NULL
);

CREATE TABLE Phim (
    MaPhim INT IDENTITY(1,1) PRIMARY KEY,
    GhiChu NVARCHAR(255) NOT NULL,
    DoDaiGio INT NOT NULL,
    DoDaiPhut INT NOT NULL,
    NgayBatDau DATETIME NOT NULL,
    AnhDaiDien NVARCHAR(255) NOT NULL,
    MoTaPhim NVARCHAR(255) NOT NULL,
    NgayKetThuc DATETIME NOT NULL,
    MaLoaiPhim INT NOT NULL,
    MaDangPhim INT NOT NULL,
    MaXuatChieu INT NOT NULL,
    NoiDungPhim NVARCHAR(255) NOT NULL,
    DoTuoi INT NOT NULL,
    IdQuocGia INT NOT NULL,
    FOREIGN KEY (MaXuatChieu) REFERENCES XuatChieu(MaXuatChieu),
    FOREIGN KEY (MaLoaiPhim) REFERENCES LoaiPhim(MaLoaiPhim),
    FOREIGN KEY (MaDangPhim) REFERENCES DangPhim(MaDangPhim),
    FOREIGN KEY (IdQuocGia) REFERENCES QuocGia(IdQuocGia),
    CHECK(NgayKetThuc > NgayBatDau),
    CHECK(DoDaiGio BETWEEN 0 AND 23 AND DoDaiPhut BETWEEN 0 AND 59)
);

CREATE TABLE DanhSachDatVeOnline (
    MaDatVe INT IDENTITY(1,1) PRIMARY KEY,
    MaKhachHang INT NOT NULL,
    MaXacNhan INT NOT NULL,
    MaPhim INT NOT NULL,
    SoLuongVeThuong INT NOT NULL CHECK (SoLuongVeThuong >= 0),
    SoLuongVeVip INT NOT NULL CHECK (SoLuongVeVip >= 0),
    TrangThaiDatVe NVARCHAR(255) NOT NULL,
    MaXuatChieu INT NOT NULL,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaXuatChieu) REFERENCES XuatChieu(MaXuatChieu),
    FOREIGN KEY (MaPhim) REFERENCES Phim(MaPhim)
);


CREATE TABLE Ve (
    IdVe INT IDENTITY(1,1) PRIMARY KEY,
    MaPhong INT NOT NULL,
    MaGia INT NOT NULL,
    DonGia DECIMAL(8, 2) NOT NULL,
    MaXuatChieu INT NOT NULL,
    IdNhanVien INT NOT NULL,
    SoGhe INT NOT NULL,
    MaLichChieu INT NOT NULL,
    FOREIGN KEY (MaPhong) REFERENCES PhongChieu(IdPhongChieu),
    FOREIGN KEY (MaXuatChieu) REFERENCES XuatChieu(MaXuatChieu),
    FOREIGN KEY (IdNhanVien) REFERENCES NhanVien(IdNhanVien),
    FOREIGN KEY (SoGhe) REFERENCES Ghe(SoGhe),
    CHECK(DonGia > 0)
);