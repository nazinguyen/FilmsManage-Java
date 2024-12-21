using FilmsAPI.Models;
using FilmsManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FilmsManage.GUI.UserControls.Data
{
    public partial class LichChieuUC : UserControl
    {

        private readonly DangPhimSV _dangPhimSV;

        public LichChieuUC()
        {
            InitializeComponent();
            _dangPhimSV = new DangPhimSV("https://localhost:7085");

            ConfigureDataGridView();
            LoadComboBox();
            txtShowtimeID.Enabled = false;

        }

        public async void LoadComboBox()
        {
            try
            {
                var phim = await _dangPhimSV.GetAsync<List<Phim>>("/api/Phim");

                var phongChieu = await _dangPhimSV.GetAsync<List<PhongChieu>>("/api/PhongChieu");

                cbbPhim.DataSource = phim;
                cbbPhim.DisplayMember = "TenPhim";
                cbbPhim.ValueMember = "MaPhim";

                cbbPhongChieu.DataSource = phongChieu;
                cbbPhongChieu.DisplayMember = "TenPhongChieu";
                cbbPhongChieu.ValueMember = "MaPhongChieu";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}");
            }
        }
        public void ConfigureDataGridView()
        {
            dtgvShowLichChieu.Columns.Clear();

            dtgvShowLichChieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TitleId",
                HeaderText = "Mã xuất chiếu",
                DataPropertyName = "MaXuatChieu",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dtgvShowLichChieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenPhongChieu",
                HeaderText = "Mã phòng",
                DataPropertyName = "TenPhongChieu",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dtgvShowLichChieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenPhim",
                HeaderText = "Tên phim",
                DataPropertyName = "TenPhim",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dtgvShowLichChieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ThoiGianBd",
                HeaderText = "Thời gian bắt đầu",
                DataPropertyName = "ThoiGianBatDau",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dtgvShowLichChieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ThoiGianKt",
                HeaderText = "Thời gian kết thúc",
                DataPropertyName = "ThoiGianKetThuc",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Tùy chọn cho DataGridView
            dtgvShowLichChieu.AutoGenerateColumns = false; // Ngăn việc tự động tạo cột
            dtgvShowLichChieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng
            dtgvShowLichChieu.MultiSelect = false; // Không cho phép chọn nhiều dòng

            LoadData();
        }
        public async void LoadData()
        {
            try
            {
                var xuatChieu = await _dangPhimSV.GetAsync<List<XuatChieu>>("/api/XuatChieu");

                if (xuatChieu == null || !xuatChieu.Any())
                {
                    MessageBox.Show("Không có dữ liệu.");
                    return;
                }

                var showXuatChieu = xuatChieu.Select(s => new
                {
                    s.MaXuatChieu,
                    TenPhongChieu = s.MaPhongNavigation?.TenPhongChieu,
                    TenPhim = s.MaPhimNavigation?.TenPhim,
                    s.ThoiGianBatDau,
                    s.ThoiGianKetThuc

                }).ToList();

                dtgvShowLichChieu.DataSource = showXuatChieu;

                txtShowtimeID.Text = "";
                cbbPhim.SelectedItem = null;
                cbbPhongChieu.SelectedItem = null;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");

            }
        }
        private void dtgvShowtime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtgvShowLichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvShowLichChieu.Rows[e.RowIndex];

                var maXuatChieu = selectedRow.Cells["TitleId"].Value?.ToString();
                var tenPhim = selectedRow.Cells["TenPhim"].Value?.ToString();
                var tenPhong = selectedRow.Cells["TenPhongChieu"].Value?.ToString();
                var thoiGianBatDau = selectedRow.Cells["ThoiGianBd"].Value?.ToString();
                var thoiGianKetThuc = selectedRow.Cells["ThoiGianKt"].Value?.ToString();

                txtShowtimeID.Text = maXuatChieu;
                cbbPhim.SelectedItem = cbbPhim.Items.Cast<Phim>().FirstOrDefault(p => p.TenPhim == tenPhim);
                cbbPhongChieu.SelectedItem = cbbPhongChieu.Items.Cast<PhongChieu>().FirstOrDefault(p => p.TenPhongChieu == tenPhong);
                if (DateTime.TryParse(thoiGianBatDau, out DateTime ngayBatDau))
                {
                    dateStart.Value = new DateTime(ngayBatDau.Year, ngayBatDau.Month, ngayBatDau.Day);

                    // Gán giờ, phút, giây vào TimePicker cho thời gian bắt đầu
                    timeStart.Value = new DateTime(2000, 1, 1, ngayBatDau.Hour, ngayBatDau.Minute, ngayBatDau.Second);
                }
                else
                {
                    MessageBox.Show("Ngày bắt đầu không hợp lệ.");
                }

                if (DateTime.TryParse(thoiGianKetThuc, out DateTime ngayKetthuc))
                {
                    // Gán giờ, phút, giây vào TimePicker cho thời gian kết thúc
                    timeEnd.Value = new DateTime(2000, 1, 1, ngayKetthuc.Hour, ngayKetthuc.Minute, ngayKetthuc.Second);
                }
                else
                {
                    MessageBox.Show("Ngày kết thúc không hợp lệ.");
                }

            }
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {

        }



        private async void btnInsertShowtime_Click(object sender, EventArgs e)
        {
            var maPhim = Convert.ToInt32(cbbPhim.SelectedValue);
            var maPhong = Convert.ToInt32(cbbPhongChieu.SelectedValue);
            DateTime thoiGianBd = dateStart.Value.Add(timeStart.Value.TimeOfDay);
            DateTime thoiGianKt = dateStart.Value.Add(timeEnd.Value.TimeOfDay);

            // Lấy danh sách phòng chiếu
            var phongChieuList = await _dangPhimSV.GetAsync<List<PhongChieu>>("/api/PhongChieu");
            var phongChieu = phongChieuList.FirstOrDefault(p => p.MaPhongChieu == maPhong);

            // Kiểm tra nếu phòng không có ghế
            if (phongChieu == null || phongChieu.SoGhe <= 0)
            {
                MessageBox.Show("Phòng chiếu này không có ghế. Vui lòng chọn phòng khác.");
                return;
            }

            // Kiểm tra nếu suất chiếu với tên phim và phòng chiếu đã tồn tại chưa
            var existingShowtimes = await _dangPhimSV.GetAsync<List<XuatChieu>>("/api/XuatChieu");
            if (existingShowtimes.Any(x => x.MaPhim == maPhim && x.MaPhong == maPhong &&
                                            x.ThoiGianBatDau == thoiGianBd))
            {
                MessageBox.Show("Suất chiếu này đã tồn tại. Vui lòng chọn lại.");
                return;
            }

            XuatChieu newXuatChieu = new XuatChieu()
            {
                MaPhim = maPhim,
                MaPhong = maPhong,
                ThoiGianBatDau = thoiGianBd,
                ThoiGianKetThuc = thoiGianKt
            };

            try
            {
                var response = await _dangPhimSV.PostAsync<Models.ApiRespone>("/api/XuatChieu", newXuatChieu);
                MessageBox.Show(response.Message);
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công. " + ex.Message);
            }
        }

        private async void btnUpdateShowtime_Click_1(object sender, EventArgs e)
        {
            if (dtgvShowLichChieu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một suất chiếu để cập nhật.");
                return;
            }

            // Lấy dữ liệu từ dòng được chọn
            var selectedRow = dtgvShowLichChieu.SelectedRows[0];
            var maXuatChieu = Convert.ToInt32(selectedRow.Cells["TitleId"].Value);
            var maPhim = Convert.ToInt32(cbbPhim.SelectedValue);
            var maPhong = Convert.ToInt32(cbbPhongChieu.SelectedValue);
            DateTime thoiGianBd = dateStart.Value.Add(timeStart.Value.TimeOfDay);
            DateTime thoiGianKt = dateStart.Value.Add(timeEnd.Value.TimeOfDay);

            // Kiểm tra nếu suất chiếu với tên phim và phòng chiếu đã tồn tại chưa
            var existingShowtimes = await _dangPhimSV.GetAsync<List<XuatChieu>>("/api/XuatChieu");
            if (existingShowtimes.Any(x => x.MaPhim == maPhim && x.MaPhong == maPhong &&
                                            x.ThoiGianBatDau == thoiGianBd && x.MaXuatChieu != maXuatChieu))
            {
                MessageBox.Show("Suất chiếu này đã tồn tại. Vui lòng chọn lại.");
                return;
            }

            // Gán các giá trị vào object XuatChieu
            XuatChieu xuatChieu = new XuatChieu()
            {
                MaXuatChieu = maXuatChieu,
                MaPhim = maPhim,
                MaPhong = maPhong,
                ThoiGianBatDau = thoiGianBd,
                ThoiGianKetThuc = thoiGianKt
            };

            try
            {
                Debug.WriteLine("Bắt đầu cập nhật...");
                var response = await _dangPhimSV.PutAsync<Models.ApiRespone>("/api/XuatChieu", xuatChieu);
                MessageBox.Show(response.Message);
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không thành công! " + ex.Message);
            }
        }

        private async void btnDeleteShowtime_Click_1(object sender, EventArgs e)
        {
            if (dtgvShowLichChieu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một suất chiếu để xóa.");
                return;
            }

            // Lấy dòng được chọn
            var selectedRow = dtgvShowLichChieu.SelectedRows[0];
            var maXuatChieu = Convert.ToInt32(selectedRow.Cells["TitleId"].Value);

            // Hiển thị hộp thoại xác nhận
            var confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa suất chiếu này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Nếu người dùng chọn Yes, thực hiện xóa
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var response = await _dangPhimSV.DeleteAsync($"/api/XuatChieu/Delete/{maXuatChieu}");

                    if (response)
                    {
                        MessageBox.Show("Xóa thành công.");
                        LoadData(); // Tải lại danh sách sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Không thê xóa xuất chiếu này! Vui lòng liên hệ với bộ phận IT");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công! " + ex.Message);
                }
            }

        }

        private async void txtSearchShowtime_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = txtSearchShowtime.Text.ToLower();
            if (searchText == "")
            {
                LoadData();
            }
            var xuatChieus = await _dangPhimSV.GetAsync<List<XuatChieu>>("/api/XuatChieu");
            if (xuatChieus == null || !xuatChieus.Any())
            {
                MessageBox.Show("Không có dữ liệu.");
                return;
            }

            // Lọc dữ liệu và chuyển đổi thành đối tượng ẩn danh
            var filteredShowtimes = xuatChieus
                .Where(s => s.MaPhimNavigation != null &&
                            s.MaPhimNavigation.TenPhim != null &&
                            s.MaPhimNavigation.TenPhim.ToLower().Contains(searchText))
                .Select(p => new
                {
                    p.MaXuatChieu,
                    TenPhongChieu = p.MaPhongNavigation?.TenPhongChieu,
                    TenPhim = p.MaPhimNavigation?.TenPhim,
                    p.ThoiGianBatDau,
                    p.ThoiGianKetThuc
                })
                .ToList();

            // Hiển thị danh sách đã lọc
            dtgvShowLichChieu.DataSource = null; // Xóa dữ liệu cũ
            dtgvShowLichChieu.DataSource = filteredShowtimes; //
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            var exporter = new ExcelExporter();
            exporter.ExportDataGridViewToExcel(dtgvShowLichChieu);
        }
    }
}
