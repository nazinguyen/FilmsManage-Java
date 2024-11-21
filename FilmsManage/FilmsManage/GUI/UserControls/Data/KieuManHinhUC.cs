using FilmsManage.Models.Entities;
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
    public partial class KieuManHinhUC : UserControl
    {
        private readonly DangPhimSV _kieuManHinh;

        public KieuManHinhUC()
        {
            InitializeComponent();
            _kieuManHinh = new DangPhimSV("https://localhost:7085");
            LoadData();
            dtgvScreenType.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TitleId",
                HeaderText = "Title ID",
                DataPropertyName = "MaDangPhim" // Tên trường chính xác trong dữ liệu
            });

            dtgvScreenType.Columns.Add(new DataGridViewTextBoxColumn
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
                List<DangPhim> dangPhimList = await _kieuManHinh.GetAsync<List<DangPhim>>("DangPhim");

                var dangPhimDisplayList = dangPhimList.Select(d => new
                {
                    d.MaDangPhim,
                    d.TenDangPhim
                }).ToList();

                dtgvScreenType.DataSource = dangPhimDisplayList;
                dtgvScreenType.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnInsertScreenType_Click(object sender, EventArgs e)
        {
            string genreName = txtScreenTypeName.Text;

            if (string.IsNullOrWhiteSpace(genreName))
            {
                MessageBox.Show("Vui lòng nhập tên màn hình.");
                return;
            }

            var dangPhim = new DangPhim
            {
                TenDangPhim = genreName
            };

            try
            {
                string endpoint = "/DangPhim";
                var response = await _kieuManHinh.PutAsync<Models.ApiRespone>(endpoint, dangPhim);

                MessageBox.Show(response.Message);
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnUpdateScreenType_Click(object sender, EventArgs e)
        {
            string genreId = txtScreenTypeID.Text;
            string genreName = txtScreenTypeName.Text;

            if (string.IsNullOrWhiteSpace(genreId) || string.IsNullOrWhiteSpace(genreName))
            {
                MessageBox.Show("Vui lòng nhập mã và tên màn hình.");
                return;
            }

            var dangPhim = new DangPhim
            {
                MaDangPhim = int.Parse(genreId),
                TenDangPhim = genreName
            };

            try
            {
                string endpoint = "/DangPhim"; // Đảm bảo rằng endpoint là đúng
                var response = await _kieuManHinh.PostAsync<Models.ApiRespone>(endpoint, dangPhim);  // Sử dụng POST thay vì PUT

                MessageBox.Show(response.Message);  // Hiển thị thông báo từ API
                await LoadData();  // Tải lại dữ liệu sau khi cập nhật thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnDeleteScreenType_Click(object sender, EventArgs e)
        {
            string genreId = txtScreenTypeID.Text;

            if (string.IsNullOrWhiteSpace(genreId))
            {
                MessageBox.Show("Vui lòng nhập mã dạng phim để xóa.");
                return;
            }

            try
            {
                string endpoint = $"/DangPhim"; // Endpoint phù hợp với API xóa dạng phim
                var response = await _kieuManHinh.DeleteAsync<Models.ApiRespone>(endpoint); // Gọi API Delete

                MessageBox.Show(response.Message); // Hiển thị thông báo trả về từ API
                await LoadData(); // Tải lại dữ liệu sau khi xóa thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}
