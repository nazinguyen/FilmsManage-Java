using DocumentFormat.OpenXml.Office2010.Drawing;
using FilmsAPI.Models;
using FilmsManage.Helper;
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

namespace FilmsManage.GUI.Forms
{
    public partial class ThanhToan : Form
    {
        private List<Ghe> gheChon;
        private XuatChieu xuatChieu;
        private List<Ve> listVe;
        private DangPhimSV _sv;


        public ThanhToan(List<Ghe> gheChon, XuatChieu xuatChieu)
        {
            this.gheChon = gheChon;
            InitializeComponent();
            this.xuatChieu = xuatChieu;
            _sv = new DangPhimSV("https://localhost:7085");
            ShowHoaDon();
        }

        public async Task ShowHoaDon()
        {
            try
            {
                // Lấy danh sách vé từ API
                listVe = await _sv.PostAsync<List<Ve>>($"/api/BanVe/GetVeTheoGhe/{xuatChieu.MaXuatChieu}", gheChon)
                         ?? new List<Ve>(); // Đảm bảo không null

                // Hiển thị thông tin xuất chiếu
                lblPhim.Text = xuatChieu.MaPhimNavigation?.TenPhim ?? "N/A";
                lblNgayChieu.Text = xuatChieu.ThoiGianBatDau.ToString("dd/MM/yyyy");
                lblGioChieu.Text = xuatChieu.ThoiGianBatDau.ToString("hh:mm tt");
                lblPhongChieu.Text = xuatChieu.MaPhongNavigation?.TenPhongChieu ?? "N/A";

                // Hiển thị danh sách ghế
                lblViTri.Text = string.Join(", ", gheChon.Select(g => g.TenGhe));

                // Đếm số ghế VIP và ghế thường
                lblGheVIP.Text = gheChon.Count(g => g.MaLoaiGheNavigation.TenLoaiGhe == "VIP").ToString();
                lblGheThuong.Text = gheChon.Count(g => g.MaLoaiGheNavigation.TenLoaiGhe == "Normal").ToString();

                // Tính tổng tiền
                lblTongTien.Text = listVe.Sum(v => v.GiaVe).ToString("N0"); // Định dạng số nếu cần

                AddBillItemToFlowLayout("abc",2,1000 );
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                lblPhim.Text = "Đã xảy ra lỗi: " + ex.Message;
            }
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                // Lấy Graphics để vẽ
                Graphics g = e.Graphics;

                // Tạo Pen để vẽ viền
                using (Pen pen = new Pen(Color.Black, 2)) // Màu đen, độ dày 2px
                {
                    // Xác định vị trí vẽ đường viền dưới
                    int x1 = 0;
                    int y1 = label.Height - 1; // Nằm ngay dưới cùng của label
                    int x2 = label.Width;
                    int y2 = label.Height - 1;

                    // Vẽ đường thẳng
                    g.DrawLine(pen, x1, y1, x2, y2);
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Lấy Graphics từ PaintEventArgs
                Graphics g = e.Graphics;

                // Tạo Pen để vẽ đường viền
                using (Pen pen = new Pen(Color.Black, 2)) // Màu đen, độ dày 2px
                {
                    // Vẽ viền trên
                    g.DrawLine(pen, 0, 0, panel.Width, 0);

                    // Vẽ viền dưới
                    g.DrawLine(pen, 0, panel.Height - 1, panel.Width, panel.Height - 1);
                }
            }
        }
        private void AddBillItemToFlowLayout(string productName, int quantity, decimal price)
        {
            // Tạo một Panel để chứa hai Label (trái và phải)
            Panel itemPanel = new Panel();
            itemPanel.Size = new Size(flpBillFood.Width - 20, 30); // Chiều rộng vừa đủ FlowLayoutPanel, chiều cao cố định
            itemPanel.BackColor = Color.Transparent; // Hoặc màu nền tùy chỉnh
            itemPanel.Dock = DockStyle.Top;

            // Label trái: hiển thị số lượng và tên sản phẩm
            Label lblProductInfo = new Label();
            lblProductInfo.AutoSize = false; // Để canh chỉnh kích thước
            lblProductInfo.Text = $"{quantity} x {productName}";
            lblProductInfo.TextAlign = ContentAlignment.MiddleLeft;
            lblProductInfo.Size = new Size(itemPanel.Width / 2, itemPanel.Height);
            lblProductInfo.Font = new Font("Arial", 10, FontStyle.Regular);

            // Label phải: hiển thị thành tiền
            Label lblTotalPrice = new Label();
            lblTotalPrice.AutoSize = false;
            lblTotalPrice.Text = $"{(price * quantity):C}"; // Định dạng tiền tệ
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            lblTotalPrice.Size = new Size(itemPanel.Width / 2, itemPanel.Height);
            lblTotalPrice.Font = new Font("Arial", 10, FontStyle.Regular);
            lblTotalPrice.Dock = DockStyle.Right;

            // Thêm các Label vào Panel
            itemPanel.Controls.Add(lblProductInfo);
            itemPanel.Controls.Add(lblTotalPrice);

            // Thêm Panel vào FlowLayoutPanel
            flpBillFood.Controls.Add(itemPanel);
        }

  
        private void label3_Paint(object sender, PaintEventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                // Lấy Graphics để vẽ
                Graphics g = e.Graphics;

                // Tạo Pen để vẽ viền
                using (Pen pen = new Pen(Color.Black, 2)) // Màu đen, độ dày 2px
                {
                    // Xác định vị trí vẽ đường viền dưới
                    int x1 = 0;
                    int y1 = label.Height - 1; // Nằm ngay dưới cùng của label
                    int x2 = label.Width;
                    int y2 = label.Height - 1;

                    // Vẽ đường thẳng
                    g.DrawLine(pen, x1, y1, x2, y2);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Lấy Graphics từ PaintEventArgs
                Graphics g = e.Graphics;

                // Tạo Pen để vẽ đường viền
                using (Pen pen = new Pen(Color.Black, 2)) // Màu đen, độ dày 2px
                {
                    // Vẽ viền trên
                    g.DrawLine(pen, 0, 0, panel.Width - 1, 0);

                    // Vẽ viền dưới
                    g.DrawLine(pen, 0, panel.Height - 1, panel.Width - 1, panel.Height - 1);

                    // Vẽ viền trái
                    g.DrawLine(pen, 0, 0, 0, panel.Height - 1);

                    // Vẽ viền phải
                    g.DrawLine(pen, panel.Width - 1, 0, panel.Width - 1, panel.Height - 1);
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Lấy Graphics từ PaintEventArgs
                Graphics g = e.Graphics;

                // Tạo Pen để vẽ đường viền
                using (Pen pen = new Pen(Color.Black, 2)) // Màu đen, độ dày 2px
                {
                    // Vẽ viền trên
                    g.DrawLine(pen, 0, 0, panel.Width - 1, 0);

                    // Vẽ viền dưới
                    g.DrawLine(pen, 0, panel.Height - 1, panel.Width - 1, panel.Height - 1);

                    // Vẽ viền trái
                    g.DrawLine(pen, 0, 0, 0, panel.Height - 1);

                    // Vẽ viền phải
                    g.DrawLine(pen, panel.Width - 1, 0, panel.Width - 1, panel.Height - 1);
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Lấy Graphics từ PaintEventArgs
                Graphics g = e.Graphics;

                // Tạo Pen để vẽ đường viền
                using (Pen pen = new Pen(Color.Black, 2)) // Màu đen, độ dày 2px
                {
                    // Vẽ đường viền dưới
                    g.DrawLine(pen, 0, panel.Height - 1, panel.Width, panel.Height - 1);
                }
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Lấy Graphics từ PaintEventArgs
                Graphics g = e.Graphics;

                // Tạo Pen để vẽ đường viền
                using (Pen pen = new Pen(Color.Black, 2)) // Màu đen, độ dày 2px
                {
                    // Vẽ đường viền dưới
                    g.DrawLine(pen, 0, panel.Height - 1, panel.Width, panel.Height - 1);
                }
            }
        }

        private async void cbKH_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKH.Checked)
            {
                // Khách hàng vãng lai
                txtDienThoai.Visible = false; // Ẩn trường nhập mã khách hàng
                txtHoTen.Visible = false; // Hiện trường nhập tên khách hàng
            }
            else
            {
                txtDienThoai.Visible = true; // Hiện trường nhập mã khách hàng
                txtHoTen.Visible = true; // Ẩn trường nhập tên khách hàng
            }
        }
        public void CloseDialog()
        {
            MessageBox.Show("Đặt thành công");
            this.Close();
        }
        private async void btnThanhToan_Click(object sender, EventArgs e)
        {
            var loginResponse = TokenStorage.GetLoginResponse();
            if (cbKH.Checked)
            {
                HoaDon hoaDon = new HoaDon()
                {

                    TongTien = listVe.Sum(v => v.GiaVe),
                    MaNv = loginResponse.User.MaNv,
                    MaKh = null
                };

                var saveBill = await _sv.PostAsync<HoaDon>("/api/BanVe/AddBill", hoaDon);

                Console.WriteLine($"Lưu hóa đơn thành công: {saveBill.MaHd}");
                await addDetailBills(saveBill.MaHd, listVe);

                CloseDialog();


            }
            else
            {
                var khachHang = await _sv.GetAsync<KhachHang>($"/api/BanVe/GetKhachHangBySDT/{txtDienThoai.Text}");
                if (khachHang == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng tương ứng với số điện thoại " + txtDienThoai.Text);
                    return;
                }
                var veDoi = khachHang.DiemTichluy / 8;
                if (veDoi >= 1)
                {

                }

                HoaDon hoaDon = new HoaDon()
                {

                    TongTien = listVe.Sum(v => v.GiaVe),
                    MaNv = loginResponse.User.MaNv,
                    MaKh = khachHang.MaKh
                };

                var saveBill = await _sv.PostAsync<HoaDon>("/api/BanVe/AddBill", hoaDon);

                Console.WriteLine($"Lưu hóa đơn thành công: {saveBill.MaHd}");
                await addDetailBills(saveBill.MaHd, listVe);
                CloseDialog();
            }
        }

        public async Task addDetailBills(int maHoaDon, List<Ve> ve)
        {
            List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();
            foreach (var item in ve)
            {
                ChiTietHoaDon ct = new ChiTietHoaDon()
                {
                    MaHd = maHoaDon,
                    MaVe = item.MaVe,
                    SoLuong = 1,
                    ThanhTien = item.GiaVe,
                };


                chiTietHoaDons.Add(ct);
                item.TrangThai = true;
            }

            try
            {
                // Gọi API để lưu chi tiết hóa đơn
                var updateVe = await _sv.PutAsync<string>("/api/BanVe/UpdateStatusVe", ve);
                MessageBox.Show(updateVe);
                var result = await _sv.PostAsync<string>("/api/BanVe/AddDetailBillRangeAsync", chiTietHoaDons);

                MessageBox.Show(result);

                Debug.WriteLine("ok");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
