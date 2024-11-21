using FilmsManage.Models;
using FilmsManage.Models.Entities;
using FilmsManage.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsManage.GUI.UserControls.Data
{
    public partial class TheLoaiPhimUC : UserControl
    {
        private readonly DangPhimSV _dangPhimSV;

        public TheLoaiPhimUC()
        {
            InitializeComponent();
            _dangPhimSV = new DangPhimSV("https://localhost:7085");
            LoadData();
            dtgvGenre.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TitleId",
                HeaderText = "Title ID",
                DataPropertyName = "MaDangPhim" // Tên trường chính xác trong dữ liệu
            });

            dtgvGenre.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GenreName",
                HeaderText = "Tên Dạng Phim",
                DataPropertyName = "TenDangPhim" // Tên trường chính xác trong dữ liệu
            });


        }

        public async Task LoadData()
        {
         

            try
            {
                // Gọi API để lấy danh sách DangPhim
                List<DangPhim> dangPhimList = await _dangPhimSV.GetAsync<List<DangPhim>>("DangPhim");

                var dangPhimDisplayList = dangPhimList.Select(d => new
                {
                    d.MaDangPhim,
                    d.TenDangPhim
                }).ToList();

                dtgvGenre.DataSource = dangPhimDisplayList;
                dtgvGenre.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }


        private void dtgvGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Logic khi click vào một ô trong DataGridView nếu cần
        }

        private void panel40_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGenreID_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnInsertGenre_Click(object sender, EventArgs e)
        {
            string genreName = txtGenreName.Text;

            if (string.IsNullOrWhiteSpace(genreName))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại phim.");
                return;
            }

            var dangPhim = new DangPhim
            {
                TenDangPhim = genreName
            };

            try
            {
                string endpoint = "/DangPhim"; // Đảm bảo đường dẫn API đúng
                var response = await _dangPhimSV.PutAsync<Models.ApiRespone>(endpoint, dangPhim);

                MessageBox.Show(response.Message);  // Hiển thị thông báo từ API
                await LoadData();                   // Tải lại dữ liệu sau khi thêm mới thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            string genreId = txtGenreID.Text;
            string genreName = txtGenreName.Text;

            if (string.IsNullOrWhiteSpace(genreId) || string.IsNullOrWhiteSpace(genreName))
            {
                MessageBox.Show("Vui lòng nhập mã và tên thể loại phim.");
                return;
            }

            var dangPhim = new DangPhim
            {
                MaDangPhim = int.Parse(genreId),
                TenDangPhim = genreName,
                Gia = new List<Gium>(),
                Phims = new List<Phim>()
            };

            try
            {
                string endpoint = "/DangPhim"; // Đảm bảo rằng endpoint là đúng
                var response = await _dangPhimSV.PostAsync<Models.ApiRespone>(endpoint, dangPhim);  // Sử dụng POST thay vì PUT

                MessageBox.Show(response.Message);  // Hiển thị thông báo từ API
                await LoadData();  // Tải lại dữ liệu sau khi cập nhật thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

    }
}