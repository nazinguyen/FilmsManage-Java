using DocumentFormat.OpenXml.Drawing;
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

namespace FilmsManage
{
    public partial class BanVe : Form
    {
        private DangPhimSV _sv;
        private int selectedSeats = 0; // Số lượng ghế đang chọn
        private List<Ghe> gheChon;

        public BanVe()
        {
            gheChon = new List<Ghe>();
            _sv = new DangPhimSV("https://localhost:7085");
            InitializeComponent();
            GenerateButtons();
        }
        private Image LoadImageFromFileSystem(string filePath)
        {
            // Kiểm tra nếu đường dẫn hợp lệ và file tồn tại
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                return null;
            }

            try
            {
                // Tải ảnh từ file hệ thống
                return Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
                return null;
            }
        }
        private void GennerateFilm(XuatChieu xuatChieu)
        {
            var phim = xuatChieu.MaPhimNavigation;
            lblPhim.Text = phim?.TenPhim;
            lblXuatChieu.Text = xuatChieu.ThoiGianBatDau.ToString("HH:mm tt") + " - " + xuatChieu.ThoiGianKetThuc.ToString("HH:mm tt");
            lblPhongChieu.Text = xuatChieu.MaPhongNavigation?.TenPhongChieu;
            lblVeChon.Text = selectedSeats.ToString();
            picFilm.Image = LoadImageFromFileSystem(phim.AnhBia);


        }
        private async void GenerateButtons()
        {
            try
            {
                // Gọi API để lấy thông tin Xuất Chiếu
                var xuatChieu = await _sv.GetAsync<XuatChieu>($"/api/BanVe/GetXuatChieu/{58}");

                // Kiểm tra dữ liệu trả về
                if (xuatChieu == null)
                {
                    MessageBox.Show("Xuất chiếu không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (xuatChieu.MaPhimNavigation == null)
                {
                    MessageBox.Show("Phim không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GennerateFilm(xuatChieu);

                if (xuatChieu.MaPhongNavigation == null)
                {
                    MessageBox.Show("Phòng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var listGhe = xuatChieu.MaPhongNavigation?.Ghes?.ToList();

                if (listGhe == null || !listGhe.Any())
                {
                    MessageBox.Show("Phòng không có ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                await ShowGhe(listGhe, xuatChieu.MaPhongNavigation ?? new PhongChieu());

            }
            catch (Exception ex)
            {
                // Xử lý lỗi và thông báo cho người dùng
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task ShowGhe(List<Ghe> listGhe, PhongChieu phongChieu)
        {
            flpSeat.Controls.Clear();  // Xóa các button cũ trong panel ghế
            int count = 0;

            // Sắp xếp danh sách ghế theo bảng chữ cái và số ghế
            listGhe = listGhe.OrderBy(g => g.MaGhe).ToList();

            // Lặp qua từng hàng ghế
            for (int i = 0; i < phongChieu.SoHangGhe; i++)
            {
                // Tạo một FlowLayoutPanel mới cho mỗi hàng ghế
                FlowLayoutPanel rowPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight, // Các button trong hàng sẽ nằm ngang
                    WrapContents = false,  // Không cho phép gói dòng mới
                    AutoSize = true,       // Tự động điều chỉnh kích thước
                    AutoSizeMode = AutoSizeMode.GrowAndShrink // Tự động thay đổi kích thước panel theo số lượng ghế
                };

                // Tính toán ký tự chữ cái cho hàng ghế (A, B, C,...)
                char rowChar = (char)('A' + i); // 'A' là mã ASCII của A, cộng thêm i để tạo chữ cái kế tiếp

                // Lặp qua các ghế trong mỗi hàng, nhưng theo thứ tự đảo ngược
                for (int j = phongChieu.SoGheMotHang - 1; j >= 0; j--)  // Đảo ngược từ cuối xuống đầu
                {
                    if (count < listGhe.Count)  // Đảm bảo không vượt quá số ghế
                    {
                        var ghe = listGhe[count];

                        // Tạo mã ghế theo dạng "A11", "A10", "A9", ..., "A1"
                        string seatCode = $"{rowChar}{j + 1}";  // ghế 1, 2, 3, ... trong hàng A, B, C,...

                        Button button = new Button
                        {
                            Name = $"btnGhe{seatCode}",            // Đặt tên cho button là mã ghế
                            Text = seatCode,                       // Hiển thị mã ghế trên button
                            Width = 60,                             // Chiều rộng button
                            Height = 40,                            // Chiều cao button
                            Tag = ghe                                // Gắn dữ liệu ghế vào Tag
                        };

                        // Xử lý màu sắc của ghế theo hàng
                        if (ghe.MaLoaiGheNavigation?.TenLoaiGhe != "VIP")  // Nếu là 4 hàng đầu tiên
                        {
                            if (ghe.TrangThai)  // Ghế đã bán
                            {
                                button.BackColor = Color.Red;
                            }
                            else  // Ghế chưa bán
                            {
                                button.BackColor = Color.Blue;  // Màu xanh cho ghế chưa bán
                            }
                        }
                        else  // Các hàng sau
                        {
                            if (ghe.TrangThai)  // Ghế đã bán
                            {
                                button.BackColor = Color.Red;
                            }
                            else  // Ghế chưa bán
                            {
                                button.BackColor = Color.White;  // Màu trắng cho ghế chưa bán
                            }
                        }

                        // Xử lý sự kiện Click cho button
                        button.Click += (sender, e) =>
                        {
                            var clickedButton = sender as Button;
                            var clickedGhe = clickedButton?.Tag as Ghe;

                            if (clickedGhe != null)
                            {
                                if (clickedGhe.TrangThai == true)
                                {
                                    // Ghế đã bán, không thể chọn
                                    clickedButton.BackColor = Color.Red;
                                    MessageBox.Show($"Vé đã được bán.", "Thông báo");
                                }
                                else
                                {
                                    // Nếu ghế đang là vàng (đã chọn trước đó), bỏ chọn
                                    if (clickedButton.BackColor == Color.Yellow)
                                    {
                                        // Trở lại màu gốc tùy theo hàng ghế
                                        clickedButton.BackColor = (ghe.MaLoaiGheNavigation?.TenLoaiGhe != "VIP") ? Color.Blue : Color.White;

                                        selectedSeats--;     // Giảm số ghế đang chọn
                                        gheChon.Remove(clickedGhe); // Xóa ghế khỏi danh sách đã chọn
                                    }
                                    else
                                    {
                                        // Chọn ghế mới
                                        clickedButton.BackColor = Color.Yellow;
                                        selectedSeats++;            // Tăng số ghế đang chọn
                                        gheChon.Add(clickedGhe);     // Thêm ghế vào danh sách đã chọn
                                    }

                                    // Cập nhật số lượng ghế đang chọn
                                    lblVeChon.Text = selectedSeats.ToString();
                                }
                            }
                        };
                        count++;

                        // Thêm button vào FlowLayoutPanel của hàng
                        rowPanel.Controls.Add(button);
                    }
                }

                // Sau khi đã tạo các ghế trong hàng, thêm FlowLayoutPanel vào panel chính
                flpSeat.Controls.Add(rowPanel);
            }

            Debug.WriteLine(count);
        }






        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }

        private void flpSeat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            int cornerRadius = 20; // Bán kính góc bo
            int borderWidth = 3;   // Độ rộng viền
            Color borderColor = Color.Black; // Màu viền

            var panel = sender as Panel;

            if (panel == null) return;

            // Tạo GraphicsPath để vẽ góc bo
            var graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Góc trên trái
            path.AddArc(panel.Width - cornerRadius - 1, 0, cornerRadius, cornerRadius, 270, 90); // Góc trên phải
            path.AddArc(panel.Width - cornerRadius - 1, panel.Height - cornerRadius - 1, cornerRadius, cornerRadius, 0, 90); // Góc dưới phải
            path.AddArc(0, panel.Height - cornerRadius - 1, cornerRadius, cornerRadius, 90, 90); // Góc dưới trái
            path.CloseAllFigures();

            // Áp dụng góc bo cho Panel
            panel.Region = new Region(path);

            // Vẽ viền xung quanh Panel
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                graphics.DrawPath(pen, path);
            }

        }
    }
}
