using FilmsAPI.Models;
using FilmsManage.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsManage.GUI.UserControls.Data
{
    public partial class CinemaUC : UserControl
    {
        private readonly DangPhimSV _PhongChieu;
        public CinemaUC()
        {
            InitializeComponent();
            _PhongChieu = new DangPhimSV("https://localhost:7085");
            LoadData();
            LoadComboBoxData();
            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaPhong",
                HeaderText = "Mã phòng",
                DataPropertyName = "MaPhongChieu" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenPhong",
                HeaderText = "Tên phòng chiếu",
                DataPropertyName = "TenPhongChieu" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "tenManHinh",
                HeaderText = "Tên màn hình",
                DataPropertyName = "TenManHinh" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "soChoNgoi",
                HeaderText = "Số chỗ ngồi",
                DataPropertyName = "SoGhe" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "soHangGhe",
                HeaderText = "Số hàng ghế",
                DataPropertyName = "SoHangGhe" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "soGheMoiHang",
                HeaderText = "Số ghế mỗi hàng",
                DataPropertyName = "SoGheMotHang" // Tên trường chính xác trong dữ liệu
            });
            // Thêm sự kiện CellClick
            dtgvCinema.CellClick += DtgvFormat_CellClick;
            txtCinemaID.Enabled = false;
            txtNumberOfRows.Visible = false;
        }

        public async Task LoadData()
        {
            try
            {
                // Gọi API để lấy danh sách DangPhim
                List<PhongChieu> phongChieuList = await _PhongChieu.GetAsync<List<PhongChieu>>("/api/PhongChieu");

                var phongChieuDisplayList = phongChieuList.Select(d => new
                {
                    d.MaPhongChieu,
                    d.TenPhongChieu,
                    d.SoGhe,
                    TenManHinh = d.MaManHinhNavigation?.TenManHinh,
                    d.SoHangGhe,
                    d.SoGheMotHang,
                }).ToList();

                dtgvCinema.DataSource = phongChieuDisplayList;
                dtgvCinema.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void DtgvFormat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra hàng hợp lệ
            {
                DataGridViewRow selectedRow = dtgvCinema.Rows[e.RowIndex];

                // Gán giá trị từ hàng được chọn vào các ô nhập liệu
                txtCinemaID.Text = selectedRow.Cells["MaPhong"].Value?.ToString();
                txtCinemaName.Text = selectedRow.Cells["TenPhong"].Value?.ToString();
                cboCinemaScreenType.Text = selectedRow.Cells["tenManHinh"].Value?.ToString();
                txtCinemaSeats.Text = selectedRow.Cells["soChoNgoi"].Value?.ToString();
                txtNumberOfRows.Text = selectedRow.Cells["soHangGhe"].Value?.ToString();
                txtSeatsPerRow.Text = selectedRow.Cells["soGheMoiHang"].Value?.ToString();
            }
        }

        public async Task LoadComboBoxData()
        {
            try
            {
                // Lấy danh sách phòng chiếu từ API
                List<PhongChieu> phongChieus = await _PhongChieu.GetAsync<List<PhongChieu>>("/api/PhongChieu");

                // Lọc danh sách tên màn hình, bỏ qua null
                var screenTypes = phongChieus
                    .Select(pc => pc.MaManHinhNavigation?.TenManHinh)
                    .Where(tenManHinh => !string.IsNullOrEmpty(tenManHinh)) // Bỏ qua giá trị null hoặc chuỗi trống
                    .Distinct() // Loại bỏ giá trị trùng lặp
                    .ToList();

                // Gán danh sách vào ComboBox
                cboCinemaScreenType.DataSource = screenTypes;
                cboCinemaScreenType.DisplayMember = ""; // Không cần vì DataSource là chuỗi
                cboCinemaScreenType.ValueMember = "";   // Không cần vì DataSource là chuỗi
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải dữ liệu ComboBox: {ex.Message}");
            }
        }

        private async void btnInsertCinema_Click(object sender, EventArgs e)
        {
            string tenPhong = txtCinemaName.Text;
            string manHinh = cboCinemaScreenType.Text;

            if (string.IsNullOrWhiteSpace(tenPhong))
            {
                MessageBox.Show("Vui lòng nhập tên phòng.");
                return;
            }

            if (string.IsNullOrWhiteSpace(manHinh))
            {
                MessageBox.Show("Vui lòng nhập tên màn hình.");
                return;
            }

            if (!int.TryParse(txtCinemaID.Text, out int maPC))
            {
                MessageBox.Show("Mã phòng chiếu không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            if (!int.TryParse(txtCinemaSeats.Text, out int soGhe))
            {
                MessageBox.Show("Số ghế không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            if (!int.TryParse(txtSeatsPerRow.Text, out int gheMoiHang))
            {
                MessageBox.Show("Số ghế mỗi hàng không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            var phongChieu = new PhongChieu
            {
                MaPhongChieu = maPC,
                TenPhongChieu = tenPhong,
                SoGhe = soGhe,
                SoGheMotHang = gheMoiHang,
                MaManHinhNavigation = new ManHinh
                {
                    TenManHinh = manHinh
                }
            };

            try
            {
                string endpoint = "/api/PhongChieu";
                var response = await _PhongChieu.PostAsync<Models.ApiRespone>(endpoint, phongChieu);

                MessageBox.Show(response.Message);
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnUpdateCinema_Click(object sender, EventArgs e)
        {
            string tenPC = txtCinemaName.Text.Trim();
            string tenMH = cboCinemaScreenType.Text.Trim();

            if (!int.TryParse(txtCinemaID.Text, out int maPC))
            {
                MessageBox.Show("Số ghế không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            if (!int.TryParse(txtCinemaSeats.Text, out int soGhe))
            {
                MessageBox.Show("Số ghế không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            if (!int.TryParse(txtSeatsPerRow.Text, out int soGheMoiHang))
            {
                MessageBox.Show("Số ghế mỗi hàng không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tenPC))
            {
                MessageBox.Show("Vui lòng nhập tên phòng chiếu.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tenMH))
            {
                MessageBox.Show("Vui lòng nhập tên màn hình.");
                return;
            }

            var phongChieu = new PhongChieu
            {
                MaPhongChieu = maPC,
                TenPhongChieu = tenPC,
                MaManHinhNavigation = new ManHinh
                {
                    TenManHinh = tenMH
                },
                SoGhe = soGhe,
                SoGheMotHang = soGheMoiHang
            };

            try
            {
                string endpoint = "api/PhongChieu"; // Đảm bảo rằng endpoint là đúng
                var response = await _PhongChieu.PutAsync<Models.ApiRespone>(endpoint, phongChieu);

                MessageBox.Show(response.Message);
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}
