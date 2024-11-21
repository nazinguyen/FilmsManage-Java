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
    public partial class DinhDangPhimUC : UserControl
    {
        private readonly DangPhimSV _dangPhimSV;
        public DinhDangPhimUC()
        {
            InitializeComponent();
            _dangPhimSV = new DangPhimSV("https://localhost:7085");
            LoadData();
            dtgvFormat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TitleId",
                HeaderText = "Mã định dạng",
                DataPropertyName = "MaLoaiPhim" // Tên trường chính xác trong dữ liệu
            });

            dtgvFormat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TitleId1",
                HeaderText = "Mã phim",
                DataPropertyName = "MaPhim" // Tên trường chính xác trong dữ liệu
            });

            dtgvFormat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GenreName1",
                HeaderText = "Tên phim",
                DataPropertyName = "GhiChu" // Tên trường chính xác trong dữ liệu
            });

            dtgvFormat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TitleId2",
                HeaderText = "Mã màn hình",
                DataPropertyName = "MaDangPhim" // Tên trường chính xác trong dữ liệu
            });

            dtgvFormat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GenreName2",
                HeaderText = "Tên màn hình",
                DataPropertyName = "TenDangPhim" // Tên trường chính xác trong dữ liệu
            });
        }

        public async Task LoadData()
        {
            try
            {
                // Lấy danh sách Phim và DangPhim từ API
                List<Phim> PhimList = await _dangPhimSV.GetAsync<List<Phim>>("Phim");
                List<DangPhim> DangPhimList = await _dangPhimSV.GetAsync<List<DangPhim>>("DangPhim");

                // Thực hiện join hai danh sách
                var PhimDisplayList = PhimList
                    .Join(DangPhimList,
                          phim => phim.MaDangPhim,         // Khóa ngoại từ bảng Phim
                          dangPhim => dangPhim.MaDangPhim, // Khóa chính từ bảng DangPhim
                          (phim, dangPhim) => new
                          {
                              phim.MaPhim,
                              phim.GhiChu,
                              phim.MaLoaiPhim,
                              phim.MaDangPhim,
                              TenDangPhim = dangPhim.TenDangPhim // Lấy từ bảng DangPhim
                          })
                    .ToList();

                // Gắn dữ liệu vào DataGridView
                dtgvFormat.DataSource = PhimDisplayList;
                dtgvFormat.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnInsertFormat_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFormatID.Text, out int genreId))
            {
                MessageBox.Show("Vui lòng nhập mã định dạng hợp lệ.");
                return;
            }

            var loaiPhim = new LoaiPhim
            {
                MaLoaiPhim = genreId
            };

            try
            {
                string endpoint = "/DangPhim";
                var response = await _dangPhimSV.PutAsync<Models.ApiRespone>(endpoint, loaiPhim);

                MessageBox.Show(response.Message);
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnUpdateFormat_Click(object sender, EventArgs e)
        {
            string genreId = txtFormatID.Text;

            if (string.IsNullOrWhiteSpace(genreId))
            {
                MessageBox.Show("Vui lòng nhập mã định dạng.");
                return;
            }

            var loaiPhim = new LoaiPhim
            {
                MaLoaiPhim = int.Parse(genreId),
                MaPhim = cboFormat_MovieID.SelectedValue.ToString(),
                MaDangPhim = cboFormat_ScreenID.SelectedValue.ToString(),
            };

            try
            {
                string endpoint = "/DangPhim"; // Đảm bảo rằng endpoint là đúng
                var response = await _dangPhimSV.PutAsync<Models.ApiRespone>(endpoint, loaiPhim);  // Sử dụng POST thay vì PUT

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
