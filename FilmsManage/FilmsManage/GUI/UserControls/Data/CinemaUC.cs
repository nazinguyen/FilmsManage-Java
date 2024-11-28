using FilmsAPI.Models;
using FilmsManage.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                var manHinh = await _PhongChieu.GetAsync<List<ManHinh>>("/api/ManHinh");



                cboCinemaScreenType.DataSource = manHinh;
                cboCinemaScreenType.DisplayMember = "TenManHinh";
                cboCinemaScreenType.ValueMember = "MaManHinh";

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
                TenPhongChieu = tenPhong,
                SoGhe = soGhe,
                SoGheMotHang = gheMoiHang,
                MaManHinh = Convert.ToInt32(cboCinemaScreenType.SelectedValue),
            };

            try
            {
                string endpoint = "/api/PhongChieu";
                var response = await _PhongChieu.PostAsync<Models.ApiRespone>(endpoint, phongChieu);

                //them ghe tu phong chieu
                var loaiGheList = await _PhongChieu.GetAsync<List<LoaiGhe>>("/api/LoaiGhe");
                if (loaiGheList == null || !loaiGheList.Any())
                {
                    MessageBox.Show("Dữ liệu loại ghế không có!");
                    return;
                }

                int loaiGheVIP = 0;
                int loaiGheThuong = 0;
                foreach (var item in loaiGheList)
                {
                    if (item.TenLoaiGhe == "VIP")
                    {
                        loaiGheVIP = item.MaLoai;
                        Debug.WriteLine(loaiGheVIP);
                    }
                    else
                    {
                        loaiGheThuong = item.MaLoai;
                        Debug.WriteLine(loaiGheThuong);
                    }
                }

                var listGhe = new List<Ghe>();

                // Tạo ghế
                var getPhong = await _PhongChieu.GetAsync<List<PhongChieu>>("/api/PhongChieu");
                var phong = new PhongChieu();
                int idPhong = 0;
                foreach (var item in getPhong)
                {
                    if (item.TenPhongChieu == tenPhong)
                    {
                        idPhong = item.MaPhongChieu;
                        phong = item;
                        Debug.WriteLine(idPhong);
                        break;
                    }
                }
                for (int i = 1; i <= phong.SoHangGhe; i++)
                {
                    for (int j = 1; j <= phong.SoGheMotHang; j++)
                    {
                        Debug.WriteLine("ok");

                        Ghe ghe = new Ghe
                        {
                            TrangThai = false,
                            MaPhong = idPhong,
                            MaLoaiGhe = (i >= 4) ? loaiGheVIP : loaiGheThuong // Ghế VIP bắt đầu từ hàng số 4, ghế Thường cho các hàng còn lại
                        };
                        Debug.WriteLine("hang " + i);
                        var addGhe = await _PhongChieu.PostAsync<Models.ApiRespone>("/api/Ghe", ghe);
                        listGhe.Add(ghe);

                        if (listGhe.Count >= phong.SoGhe)
                        {
                            break;
                        }
                    }

                    if (listGhe.Count >= phong.SoGhe)
                    {
                        break;
                    }
                }

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

        private void dtgvCinema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
