using FilmsAPI.Models;
using FilmsManage.Models;
using FilmsManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsManage.GUI.UserControls.Data
{
    public partial class PhimUC : UserControl
    {

        private readonly DangPhimSV _dangPhimSV;
        public PhimUC()
        {
            _dangPhimSV = new DangPhimSV("https://localhost:7085");

            InitializeComponent();
            LoadData();
        }
        public void LoadTitle()
        {
            dtgvMovie.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FilmId",
                HeaderText = "Mã phim",
                DataPropertyName = "MaPhim" // Tên trường chính xác trong dữ liệu
            });

            dtgvMovie.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FilmName",
                HeaderText = "Tên Phim",
                DataPropertyName = "TenPhim" // Tên trường chính xác trong dữ liệu
            });

            dtgvMovie.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MoTa",
                HeaderText = "Mô tả",
                DataPropertyName = "MoTaPhim" // Tên trường chính xác trong dữ liệu
            });

            dtgvMovie.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ThoiLuong",
                HeaderText = "Thời lượng",
                DataPropertyName = "DoDaiPhut" // Tên trường chính xác trong dữ liệu
            });

            dtgvMovie.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayKC",
                HeaderText = "Ngày khởi chiếu",
                DataPropertyName = "NgayBatDau" // Tên trường chính xác trong dữ liệu
            });

            dtgvMovie.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayKT",
                HeaderText = "Ngày kết thúc",
                DataPropertyName = "NgayKetThuc" // Tên trường chính xác trong dữ liệu
            });

            //dtgvMovie.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "SanXuat",
            //    HeaderText = "Sản xuất",
            //    DataPropertyName = "SanXuat" // Tên trường chính xác trong dữ liệu
            //});

            //dtgvMovie.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "DaoDien",
            //    HeaderText = "Đạo diễn",
            //    DataPropertyName = "DaoDien" // Tên trường chính xác trong dữ liệu
            //});

            //dtgvMovie.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "NamSX",
            //    HeaderText = "Năm sản xuất",
            //    DataPropertyName = "NamSX" // Tên trường chính xác trong dữ liệu
            //});

            //dtgvMovie.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "QuanLy",
            //    HeaderText = "Quản lý",
            //    DataPropertyName = "QuanLy" // Tên trường chính xác trong dữ liệu
            //});
        }
        public async void LoadData()
        {
            LoadTitle();
            try
            {
                // Gọi API để lấy danh sách DangPhim
                List<Phim> dangPhimList = await _dangPhimSV.GetAsync<List<Phim>>("/api/Phim");

                var PhimDisplayList = dangPhimList.Select(d => new
                {
                    d.MaPhim,
                    d.TenPhim,
                    d.Mota,
                    d.ThoiLuong,
                    d.NgayKc,
                    d.NgayKt
                }).ToList();

                dtgvMovie.DataSource = PhimDisplayList;
                dtgvMovie.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void dtgvMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
