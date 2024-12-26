using FilmsAPI.Models;
using FilmsManage.DTO;
using FilmsManage.Helper;
using FilmsManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsManage.GUI.Forms.BanVe_Form.UserControl_BanVe
{
    public partial class ThanhToan : UserControl
    {
        private List<Ghe> gheChon;
        private XuatChieu xuatChieu;
        private List<Ve> listVe;
        private DangPhimSV _sv;
        private List<FoodDTO> foods;
        private Main_Form mainForm;


        public ThanhToan(Main_Form mainForm, List<Ghe> gheChon, XuatChieu xuatChieu, List<FoodDTO> foods)
        {
            this.mainForm = mainForm;
            this.foods = foods;
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
                if (gheChon.Count() == 0 || gheChon == null)
                {
                    AddBillItemToFlowLayout();
                    return;
                }
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

                AddBillItemToFlowLayout();
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
        private void AddBillItemToFlowLayout()
        {
            foreach (var item in foods)
            {
                // Tạo một Panel để chứa hai Label (trái và phải)
                Panel itemPanel = new Panel();
                itemPanel.Size = new Size(flpBillFood.Width - 20, 30); // Chiều rộng vừa đủ FlowLayoutPanel, chiều cao cố định
                itemPanel.BackColor = Color.Transparent; // Hoặc màu nền tùy chỉnh
                itemPanel.Dock = DockStyle.Top;

                // Label trái: hiển thị số lượng và tên sản phẩm
                Label lblProductInfo = new Label();
                lblProductInfo.AutoSize = false; // Để canh chỉnh kích thước
                lblProductInfo.Text = $"{item.Quantity} x {item.Name}";
                lblProductInfo.TextAlign = ContentAlignment.MiddleLeft;
                lblProductInfo.Size = new Size(itemPanel.Width / 2, itemPanel.Height);
                lblProductInfo.Font = new Font("Arial", 10, FontStyle.Regular);

                // Label phải: hiển thị thành tiền
                Label lblTotalPrice = new Label();
                lblTotalPrice.AutoSize = false;
                lblTotalPrice.Text = $"{(item.Price * item.Quantity):N0}"; // Định dạng tiền tệ
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
            lblTotalPriceFood.Text = foods.Sum(f => (f.Price * f.Quantity)).ToString("N0");

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
        }
        private async void btnThanhToan_Click(object sender, EventArgs e)
        {

        }
        public void MoveToHome()
        {
            var themSua = mainForm.panel4.Controls.OfType<UserControl_BanVe.LichChieu>().FirstOrDefault();

            if (themSua != null)
            {
                mainForm.panel4.Controls.Remove(themSua);
                themSua.Dispose();
            }
            foreach (Control control in mainForm.panel4.Controls)
            {
                control.Visible = false;
            }

            themSua = new UserControl_BanVe.LichChieu(mainForm);
            themSua.Dock = DockStyle.Fill;
            mainForm.panel4.Controls.Add(themSua);

        }

        public async Task addDetailBillForFood(List<FoodDTO> foods, int maHoaDon)
        {
            List<DetailFood> detailFoods = new List<DetailFood>();
            foreach (var item in foods)
            {
                DetailFood detailFood = new DetailFood()
                {
                    FoodId = item.Id,
                    OrderId = maHoaDon,
                    Quantity = item.Quantity,
                    ThanhTien = item.Price * item.Quantity,
                };
                detailFoods.Add(detailFood);
            }

            if (detailFoods.Count < 0)
            {
                MessageBox.Show("Xảy ra lỗi trong khi thực hiện đơn hàng");
                return;
            }

            try
            {
                var result = await _sv.PostAsync<Models.ApiRespone>("/api/BanVe/AddDetailBillForFoodRangeAsync", detailFoods);

                MessageBox.Show(result.Message);

            }
            catch (Exception ex)
            {

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
        }

        private void label31_Paint(object sender, PaintEventArgs e)
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

        private void panel4_Paint_1(object sender, PaintEventArgs e)
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

        private void panel8_Paint(object sender, PaintEventArgs e)
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

        private void panel3_Paint_1(object sender, PaintEventArgs e)
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

        private void panel7_Paint(object sender, PaintEventArgs e)
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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
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

        private void label3_Paint_1(object sender, PaintEventArgs e)
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

        private void btnThanhToan_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null)
                return;

            // Kích thước và bo góc
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
            int borderRadius = 20; // Độ bo góc

            // Tạo hiệu ứng nền gradient
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.FromArgb(72, 201, 176), Color.FromArgb(46, 134, 193), LinearGradientMode.Vertical))
            using (GraphicsPath path = GetRoundedRectangle(rect, borderRadius))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Vẽ nền gradient bo góc
                e.Graphics.FillPath(brush, path);

                // Viền xung quanh nút
                using (Pen borderPen = new Pen(Color.FromArgb(0, 123, 255), 2))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }

            // Vẽ chữ nổi bật ở giữa button
            string buttonText = btn.Text;
            using (StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            using (SolidBrush textBrush = new SolidBrush(Color.White))
            {
                e.Graphics.DrawString(buttonText, btn.Font, textBrush, rect, sf);
            }
        }

        private void btnQuayLai_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null)
                return;

            // Kích thước và bo góc
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
            int borderRadius = 20; // Độ bo góc

            // Tạo hiệu ứng nền gradient (Danger)
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.FromArgb(235, 77, 75), Color.FromArgb(192, 57, 43), LinearGradientMode.Vertical))
            using (GraphicsPath path = GetRoundedRectangle(rect, borderRadius))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Vẽ nền gradient bo góc
                e.Graphics.FillPath(brush, path);

                // Viền xung quanh nút
                using (Pen borderPen = new Pen(Color.FromArgb(242, 38, 19), 2))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }

            // Vẽ chữ nổi bật ở giữa button
            string buttonText = btn.Text;
            using (StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            using (SolidBrush textBrush = new SolidBrush(Color.White))
            {
                e.Graphics.DrawString(buttonText, btn.Font, textBrush, rect, sf);
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Góc trên trái
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90); // Góc trên phải
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90); // Góc dưới phải
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90); // Góc dưới trái
            path.CloseFigure();
            return path;
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
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

        private void panel6_Paint_1(object sender, PaintEventArgs e)
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

        private async void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            var loginResponse = TokenStorage.GetLoginResponse();
            if (loginResponse == null)
            {
                MessageBox.Show("Vui lòng đăng nhập để tiếp tục!");
                return;
            }
            if (cbKH.Checked)
            {
                HoaDon hoaDon = new HoaDon()
                {

                    TongTien = (listVe?.Sum(v => v.GiaVe) ?? 0) + (foods?.Sum(f => f.Quantity * f.Price) ?? 0),
                    MaNv = loginResponse.User.MaNv,
                    MaKh = null
                };

                var saveBill = await _sv.PostAsync<HoaDon>("/api/BanVe/AddBill", hoaDon);

                Console.WriteLine($"Lưu hóa đơn thành công: {saveBill.MaHd}");
                if (listVe?.Any() == true) // Kiểm tra nếu listVe không null và có phần tử
                {
                    await addDetailBills(saveBill.MaHd, listVe);
                }

                if (foods?.Any() == true) // Kiểm tra nếu foods không null và có phần tử
                {
                    await addDetailBillForFood(foods, saveBill.MaHd);
                }



                MoveToHome();



            }
            else
            {
                var khachHang = await _sv.GetAsync<KhachHang>($"/api/BanVe/GetKhachHangBySDT/{txtDienThoai.Text}");
                if (khachHang == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng tương ứng với số điện thoại " + txtDienThoai.Text);
                    return;
                }
                //var veDoi = khachHang.DiemTichluy / 8;
                //if (veDoi >= 1)
                //{

                //}
                var point = khachHang.DiemTichluy;

                if (khachHang != null && khachHang.DiemTichluy >= listVe.Count * 5)
                {
                    DialogResult result = MessageBox.Show("Khách hàng " + khachHang.TenKh + " hiện đang có " + khachHang.DiemTichluy + "điểm . Xác nhận đổi vé", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        point -= listVe.Count * 5 - 1;
                        MessageBox.Show("Đổi điểm khách hàng thành công");

                    }
                    else
                    {
                        point += 1;
                    }

                    var Customer = new KhachHang
                    {
                        MaKh = khachHang.MaKh,
                        Sdt = khachHang.Sdt,
                        TenKh = khachHang.TenKh,
                        NgaySinh = khachHang.NgaySinh,
                        DiaChi = khachHang.DiaChi,
                        CCCD = khachHang.CCCD,
                        DiemTichluy = point,
                        Email = khachHang.Email
                    };

                    string endpointUpdate = $"api/KhachHang";
                    var response = await _sv.PutAsync<string>(endpointUpdate, Customer);

                    if (response == null)
                    {
                        MessageBox.Show("Có lỗi trong quá trình đổi điểm, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
                await addDetailBillForFood(foods, saveBill.MaHd);
                MoveToHome();

            }
        }

        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {

            var themSua = mainForm.panel4.Controls.OfType<UserControl_BanVe.LichChieu>().FirstOrDefault();

            if (themSua != null)
            {
                mainForm.panel4.Controls.Remove(themSua);
                themSua.Dispose();
            }
            foreach (Control control in mainForm.panel4.Controls)
            {
                control.Visible = false;
            }

            themSua = new UserControl_BanVe.LichChieu(mainForm);
            themSua.Dock = DockStyle.Fill;
            mainForm.panel4.Controls.Add(themSua);
        }
    }
}
