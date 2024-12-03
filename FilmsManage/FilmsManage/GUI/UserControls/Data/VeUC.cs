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

                if (xuatChieu != null && xuatChieu.Any())
                {


                    foreach (var item in xuatChieu)
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

                int xuatChieuId = Convert.ToInt32( selectedItem.Tag);
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

        private async void btnAddTicketsByShowTime_Click(object sender, EventArgs e)
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


                Debug.WriteLine("pc "+phongChieu.MaPhongChieu);

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
                    decimal giaVe = (ghe.MaLoaiGheNavigation.MaLoai == loaiGheVIP) ? 200000 : 100000;
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
    }
}
