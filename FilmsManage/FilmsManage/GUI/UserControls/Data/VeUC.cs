using FilmsManage.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmsManage.Models;
using FilmsAPI.Models;
using System.Diagnostics;

namespace FilmsManage.GUI.UserControls.Data
{
    public partial class VeUC : UserControl
    {
        private readonly DangPhimSV _sv;

        public VeUC()
        {
            _sv = new DangPhimSV("https://localhost:7085");
            InitializeComponent();
            LoadXuatChieu();
            ConfigureDataGridView();
        }
        public async void LoadXuatChieu()
        {
            lsvAllListShowTimes.Items.Clear();

            try
            {
                var xuatChieu = await _sv.GetAsync<List<XuatChieu>>("/api/XuatChieu");
                var xuatChieuHopLe = xuatChieu.Where(x => x.ThoiGianBatDau >= DateTime.Now);

                if (xuatChieuHopLe != null && xuatChieuHopLe.Any())
                {


                    foreach (var item in xuatChieuHopLe)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.MaPhongNavigation?.TenPhongChieu);
                        listViewItem.SubItems.Add(item.MaPhimNavigation?.TenPhim);
                        listViewItem.SubItems.Add(item.ThoiGianBatDau.ToString() + " - " + item.ThoiGianKetThuc.ToString("hh-mm-ss tt")); // Định dạng thời gian
                        listViewItem.SubItems.Add(item.Status ? "Đã tạo vé" : "Chưa tạo vé");
                        listViewItem.Tag = item.MaXuatChieu;
                        lsvAllListShowTimes.Items.Add(listViewItem);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi: " + ex.Message);
            }
        }

        private void dtgvTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ConfigureDataGridView()
        {
            dtgvVe.Columns.Clear();

            dtgvVe.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaVe",
                HeaderText = "Mã vé",
                DataPropertyName = "MaVe",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dtgvVe.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaGhe",
                HeaderText = "Mã ghế",
                DataPropertyName = "MaGhe",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dtgvVe.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Trạng thái",
                DataPropertyName = "Status",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dtgvVe.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LoaiGhe",
                HeaderText = "Loại ghế",
                DataPropertyName = "LoaiGhe",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dtgvVe.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GiaVe",
                HeaderText = "Giá vé",
                DataPropertyName = "GiaVe",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });


            // Tùy chọn cho DataGridView
            dtgvVe.AutoGenerateColumns = false; // Ngăn việc tự động tạo cột
            dtgvVe.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng
            dtgvVe.MultiSelect = false; // Không cho phép chọn nhiều dòng

        }

        public async void LoadVe(int MaXuatChieu)
        {
            dtgvVe.DataSource = null;
            try
            {
                var ve = await _sv.GetAsync<List<Ve>>($"/api/Ve/GetVeTheoXuatChieu/{MaXuatChieu}");

                if (ve == null || !ve.Any())
                {
                    MessageBox.Show("Không có dữ liệu.");
                    return;
                }

                var showVe = ve.Select(s => new
                {
                    Mave = s.MaVe,
                    MaGhe = s.MaGhe,
                    Status = s.TrangThai ? "Đã bán" : "Chưa bán",
                    LoaiGhe = s.MaGheNavigation?.MaLoaiGheNavigation?.TenLoaiGhe ?? "Không xác định", // Lấy loại ghế
                    GiaVe = s.GiaVe
                }).ToList();

                dtgvVe.DataSource = showVe;


            }

            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");

            }
        }
        private async void lsvAllListShowTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count > 0)
            {
                var selectedItem = lsvAllListShowTimes.SelectedItems[0];

                int xuatChieuId = Convert.ToInt32(selectedItem.Tag);
                var xuatChieu = await _sv.GetAsync<XuatChieu>($"/api/XuatChieu/{xuatChieuId}");
                Debug.WriteLine(xuatChieuId);
                if (xuatChieu != null && xuatChieu.Status)
                {
                    LoadVe(xuatChieuId);
                }
                else
                {
                    dtgvVe.DataSource = null;
                    return;
                }
            }
        }

        private async void lsvAllListShowTimes_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private async void btnAddTicketsByShowTime_Click_1(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một xuất chiếu!");
                return;
            }

            var selectedItem = lsvAllListShowTimes.SelectedItems[0];
            int maXuatChieu = (int)selectedItem.Tag;

            try
            {
                var xuatChieu = await _sv.GetAsync<XuatChieu>($"/api/XuatChieu/{maXuatChieu}");
                if (xuatChieu.Status == true)
                {
                    MessageBox.Show("Xuất chiếu đã được tạo vé.");
                    return;
                }
                if (xuatChieu == null)
                {
                    MessageBox.Show("Không tìm thấy suất chiếu.");
                    return;
                }

                var phongChieu = xuatChieu.MaPhongNavigation;
                if (phongChieu == null)
                {
                    MessageBox.Show("Không tồn tại phòng chiếu theo suất chiếu này!");
                    return;
                }

                var loaiGheList = await _sv.GetAsync<List<LoaiGhe>>("/api/LoaiGhe");
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


                Debug.WriteLine("pc " + phongChieu.MaPhongChieu);

                var listGheFromApi = await _sv.GetAsync<List<Ghe>>($"/api/Ghe/{phongChieu.MaPhongChieu}");
                Debug.WriteLine("ok list ghe");
                var getLoaiVe = await _sv.GetAsync<List<LoaiVe>>("/api/LoaiVe");
                Debug.WriteLine("ok loai ghe");

                int maVeThuong = 0;
                foreach (var item in getLoaiVe)
                {
                    if (item.TenLoaiVe == "Vé Thường") maVeThuong = item.MaLoai;
                }
                Debug.WriteLine(maVeThuong + "-" + listGheFromApi.Count.ToString());
                //Tạo vé cho mỗi ghế trong phòng chiếu
                foreach (var ghe in listGheFromApi)
                {
                    decimal giaVe = (ghe.MaLoaiGhe == loaiGheVIP)
                        ? ((xuatChieu.GiaCoBan ?? 0) * 0.5m)
                        : (xuatChieu.GiaCoBan ?? 0);
                    Debug.WriteLine(giaVe);
                    Debug.WriteLine(maXuatChieu);
                    Debug.WriteLine(ghe.MaGhe);
                    Debug.WriteLine(maVeThuong);

                    Ve newVe = new Ve
                    {
                        MaXuatChieu = maXuatChieu,
                        MaGhe = ghe.MaGhe,
                        MaLoaiVe = maVeThuong,
                        GiaVe = giaVe,
                        TrangThai = false
                    };
                    Debug.WriteLine("gui");


                    var response = await _sv.PostAsync<Models.ApiRespone>("/api/Ve", newVe);
                    Debug.WriteLine("thanh cong");

                }

                // Cập nhật trạng thái suất chiếu
                var xuatChieuUpdate = new XuatChieu()
                {
                    MaXuatChieu = xuatChieu.MaXuatChieu,
                    ThoiGianBatDau = xuatChieu.ThoiGianBatDau,
                    ThoiGianKetThuc = xuatChieu.ThoiGianKetThuc,
                    MaPhong = xuatChieu.MaPhong,
                    MaPhim = xuatChieu.MaPhim,
                    Status = true
                };

                var updateXuatChieu = await _sv.PutAsync<Models.ApiRespone>("/api/XuatChieu", xuatChieuUpdate);

                LoadVe(xuatChieu.MaXuatChieu);
                LoadXuatChieu();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private async void btnDeleteTicketsByShowTime_Click(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một xuất chiếu!");
                return;
            }

            var selectedItem = lsvAllListShowTimes.SelectedItems[0];
            int maXuatChieu = (int)selectedItem.Tag;

            var getXuatChieu = await _sv.GetAsync<XuatChieu>($"/api/XuatChieu/{maXuatChieu}");

            if (getXuatChieu.ThoiGianKetThuc >= DateTime.Now)
            {
                MessageBox.Show("Không thể xóa lịch vé theo lịch chiếu này");
                return;
            }

            var getVe = await _sv.GetAsync<List<Ve>>($"/api/Ve/{getXuatChieu.MaXuatChieu}");
            if (getVe == null)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
            var deleteVe = await _sv.DeleteAsync("/api/Ve/DeleteRangeAsync", getVe ?? new List<Ve>());

        }

        private async void btnShowTimeNotCreateTickets_Click(object sender, EventArgs e)
        {
            lsvAllListShowTimes.Items.Clear();

            try
            {
                var xuatChieu = await _sv.GetAsync<List<XuatChieu>>("/api/XuatChieu");
                var xuatChieuHopLe = xuatChieu.Where(x => x.ThoiGianBatDau >= DateTime.Now && x.Status == false);

                if (xuatChieuHopLe != null && xuatChieuHopLe.Any())
                {


                    foreach (var item in xuatChieuHopLe)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.MaPhongNavigation?.TenPhongChieu);
                        listViewItem.SubItems.Add(item.MaPhimNavigation?.TenPhim);
                        listViewItem.SubItems.Add(item.ThoiGianBatDau.ToString() + " - " + item.ThoiGianKetThuc.ToString("hh-mm-ss tt")); // Định dạng thời gian
                        listViewItem.SubItems.Add(item.Status ? "Đã tạo vé" : "Chưa tạo vé");
                        listViewItem.Tag = item.MaXuatChieu;
                        lsvAllListShowTimes.Items.Add(listViewItem);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi: " + ex.Message);
            }
        }

        private void btnAllListShowTimes_Click_1(object sender, EventArgs e)
        {
            LoadXuatChieu();
        }

        private async void txtSearchShowtime_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = txtSearchShowtime.Text.ToLower();
            if (searchText == "")
            {
                LoadXuatChieu();
                return; // Thêm return để tránh gọi lại API khi searchText rỗng
            }
            var xuatChieus = await _sv.GetAsync<List<XuatChieu>>("/api/XuatChieu");
            if (xuatChieus == null || !xuatChieus.Any())
            {
                MessageBox.Show("Không có dữ liệu.");
                return;
            }

            // Lọc dữ liệu và chuyển đổi thành đối tượng ẩn danh
            var filteredShowtimes = xuatChieus
                .Where(s => s.MaPhimNavigation != null &&
                            s.MaPhimNavigation.TenPhim != null &&
                            s.MaPhimNavigation.TenPhim.ToLower().Contains(searchText) && s.ThoiGianBatDau >= DateTime.Now)
                .Select(p => new
                {
                    p.MaXuatChieu,
                    TenPhongChieu = p.MaPhongNavigation?.TenPhongChieu,
                    TenPhim = p.MaPhimNavigation?.TenPhim,
                    ThoiGianBatDau = p.ThoiGianBatDau.ToString("dd/MM/yyyy HH:mm"),
                    ThoiGianKetThuc = p.ThoiGianKetThuc.ToString("dd/MM/yyyy HH:mm")
                })
                .ToList();

            // Hiển thị danh sách đã lọc trong ListView
            lsvAllListShowTimes.Items.Clear(); // Xóa các mục cũ
            foreach (var showtime in filteredShowtimes)
            {
                // Tạo một ListViewItem cho mỗi dòng dữ liệu
                var item = new ListViewItem(showtime.MaXuatChieu.ToString());
                item.SubItems.Add(showtime.TenPhongChieu ?? "N/A");
                item.SubItems.Add(showtime.TenPhim ?? "N/A");
                item.SubItems.Add(showtime.ThoiGianBatDau);
                item.SubItems.Add(showtime.ThoiGianKetThuc);

                lsvAllListShowTimes.Items.Add(item);
            }

        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            var exporter = new ExcelExporter();

            // Gọi hàm ExportListViewToExcel và truyền vào ListView
            exporter.ExportDataGridViewToExcel(dtgvVe);
        }
    }
}
