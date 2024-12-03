using FilmsAPI.Models;
using FilmsManage.Models;
using FilmsManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsManage.GUI.UserControls
{
    public partial class DoanhThu : UserControl
    {
        private readonly DangPhimSV _context;

        public DoanhThu()
        {
            _context = new DangPhimSV("https://localhost:7085");

            InitializeComponent();
            LoadRevenue();          
        }
        void LoadRevenue()
        {
            LoadMovieIntoCombobox();
            LoadDateTimePickerRevenue();//Set "Từ ngày" & "Đến ngày ngày" về đầu tháng & cuối tháng
            LoadRevenue("Avengers", dtmFromDate.Value, dtmToDate.Value);
        }
        async void LoadMovieIntoCombobox()
        {
            List<LoaiPhim> phimList = await _context.GetAsync<List<LoaiPhim>>("api/LoaiPhim");
            //Bind dữ liệu vào combobox
            cboSelectMovie.DataSource = phimList;
            cboSelectMovie.DisplayMember = "TenTheLoai";
            cboSelectMovie.ValueMember = "TenTheLoai";     
        }
        void LoadDateTimePickerRevenue()
        {
            dtmFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtmToDate.Value = dtmFromDate.Value.AddMonths(1).AddDays(-1);
        }
        async void LoadRevenue(string idMovie, DateTime fromDate, DateTime toDate)
        {
            CultureInfo culture = new CultureInfo("vi-VN");

            var tenPhim = idMovie; // Tên phim cần tìm
            var ngayBatDau = fromDate;
            var ngayKetThuc = toDate;

            List<Phim> phimList = await _context.GetAsync<List<Phim>>("api/Phim");


            //var maPhim  = phimList.Find(p => p.TenPhim == idMovie);

            List<XuatChieu> xuatChieuList = await _context.GetAsync<List<XuatChieu>>("api/XuatChieu");
            List<Ve> veList = await _context.GetAsync<List<Ve>>("api/Ve");
            List<HoaDon> hoaDonList = await _context.GetAsync<List<HoaDon>>("api/HoaDon");
            List<LoaiPhim> LoaiPhim = await _context.GetAsync<List<LoaiPhim>>("api/LoaiPhim");
            List<TheLoaiCuaPhim> TheLoaiPhim = await _context.GetAsync<List<TheLoaiCuaPhim>>("api/LoaiCuaPhim");
            List<ChiTietHoaDon> chiTietHoaDonList = await _context.GetAsync<List<ChiTietHoaDon>>($"api/CTHD");


            var maLoaiPhim = LoaiPhim.Find(p => p.TenTheLoai == tenPhim) ;
            if (maLoaiPhim != null)
            {



                var maloai = maLoaiPhim.MaTheLoai;

                // Truy vấn LINQ trên dữ liệu lấy từ API
                var doanhThu = (from p in phimList
                                join xc in xuatChieuList on p.MaPhim equals xc.MaPhim
                                join v in veList on xc.MaXuatChieu equals v.MaXuatChieu
                                join cthd in chiTietHoaDonList on v.MaVe equals cthd.MaVe
                                join hd in hoaDonList on cthd.MaHd equals hd.MaHd
                                join tlp in TheLoaiPhim on p.MaPhim equals tlp.Maphim
                                join lp in LoaiPhim on tlp.MaTheLoai equals lp.MaTheLoai
                                where lp.MaTheLoai == maloai &&
                                      cthd.TimeDatVe >= ngayBatDau &&
                                      cthd.TimeDatVe <= ngayKetThuc
                                group cthd by new { p.TenPhim, p.NgayKc } into g
                                select new DoanhThuPhim
                                {
                                    TenPhim = g.Key.TenPhim,
                                    NgayKc = g.Key.NgayKc,
                                    SoVeBan = g.Sum(x => x.SoLuong),
                                    TongDoanhThu = g.Sum(x => x.MaVeNavigation.GiaVe * x.SoLuong)
                                }).ToList();


                List<DoanhThuPhim> doanhthuphim = (doanhThu);
                dtgvRevenue.DataSource = doanhthuphim;
            }
            txtDoanhThu.Text = GetSumRevenue().ToString("c", culture);

        }
        decimal GetSumRevenue()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dtgvRevenue.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["tongDoanhThu"].Value);
            }
            return sum;
        }       
        private void btnShowRevenue_Click(object sender, EventArgs e)
        {
            LoadRevenue(cboSelectMovie.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);

        }      
    }
}
