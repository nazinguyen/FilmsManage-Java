using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using FilmsAPI.Models;
using FilmsManage.GUI.Forms;
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
        private List<Ghe> danhSachGheDaMua;
        private List<Ghe> danhSachGhe;
        private int soGheMotHang;
        private XuatChieu thongTinXuatChieu;
        private List<Ve> veDaMua;
        private int maXuatChieu;

        public BanVe(int maXuatChieuFromLichChieu)
        {
            gheChon = new List<Ghe>();
            _sv = new DangPhimSV("https://localhost:7085");
            InitializeComponent();
            maXuatChieu = maXuatChieuFromLichChieu;
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
                var xuatChieu = await _sv.GetAsync<XuatChieu>($"/api/BanVe/GetXuatChieu/{maXuatChieu}");
                thongTinXuatChieu = xuatChieu;
                var listTicketByTimeShow = await _sv.GetAsync<List<Ve>>($"/api/BanVe/GetVeBySuatchieu/{xuatChieu.MaXuatChieu}");
                veDaMua = listTicketByTimeShow.Where(v => v.TrangThai == true).ToList();
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
                soGheMotHang = xuatChieu.MaPhongNavigation.SoGheMotHang;
                GennerateFilm(xuatChieu);

                if (xuatChieu.MaPhongNavigation == null)
                {
                    MessageBox.Show("Phòng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var listGhe = xuatChieu.MaPhongNavigation?.Ghes?.ToList();
                danhSachGheDaMua = listGhe.Where(x => x.TrangThai == true).ToList();
                if (listGhe == null || !listGhe.Any())
                {
                    MessageBox.Show("Phòng không có ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                await ShowGhe(listGhe, xuatChieu.MaPhongNavigation ?? new PhongChieu(), veDaMua ?? new List<Ve>());

            }
            catch (Exception ex)
            {
                // Xử lý lỗi và thông báo cho người dùng
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task ShowGhe(List<Ghe> listGhe, PhongChieu phongChieu, List<Ve> danhSachVeDaMua)
        {
            danhSachGhe = listGhe;

            // Khởi tạo danh sách ghế được chọn nếu chưa có
            if (gheChon == null)
                gheChon = new List<Ghe>();

            flpSeat.Controls.Clear(); // Xóa các button cũ trong panel ghế
            int count = 0;

            // Sắp xếp danh sách ghế theo thứ tự bảng chữ cái (hàng) và số ghế
            listGhe = listGhe.OrderBy(g => g.TenGhe[0]) // Sắp xếp theo hàng (chữ cái đầu tiên)
                             .ThenByDescending(g => int.Parse(g.TenGhe.Substring(1))) // Sắp xếp số ghế giảm dần
                             .ToList();

            // Lặp qua từng hàng ghế
            for (int i = 0; i < phongChieu.SoHangGhe; i++)
            {
                FlowLayoutPanel rowPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight, // Các button trong hàng sẽ nằm ngang
                    WrapContents = false, // Không cho phép gói dòng mới
                    AutoSize = true,      // Tự động điều chỉnh kích thước
                    AutoSizeMode = AutoSizeMode.GrowAndShrink // Tự động thay đổi kích thước panel theo số lượng ghế
                };

                var hang = (char)('A' + i); // Xác định ký tự hàng (A, B, C,...)
                var gheTrongHang = listGhe.Where(g => g.TenGhe.StartsWith(hang.ToString()))
                                          .OrderByDescending(g => int.Parse(g.TenGhe.Substring(1))) // Đảo ngược số ghế
                                          .ToList();

                foreach (var ghe in gheTrongHang)
                {
                    Button button = new Button
                    {
                        Name = ghe.TenGhe,
                        Text = ghe.TenGhe,
                        Width = 60,
                        Height = 40,
                        Tag = ghe
                    };

                    // Kiểm tra vé đã mua
                    var veDaMua = danhSachVeDaMua.Where(v => v.MaGhe == ghe.MaGhe).FirstOrDefault();


                    if (veDaMua != null)
                    {
                        // Ghế đã có vé mua
                        button.BackColor = Color.Red;
                        button.Enabled = false; // Không cho phép click
                    }
                    else
                    {
                        // Ghế chưa mua
                        button.BackColor = ghe.MaLoaiGheNavigation?.TenLoaiGhe != "VIP"
                                           ? Color.Blue
                                           : Color.White;
                    }

                    // Xử lý sự kiện Click cho ghế chưa mua
                    button.Click += (sender, e) =>
                    {
                        var clickedButton = sender as Button;
                        var clickedGhe = clickedButton?.Tag as Ghe;

                        if (clickedGhe != null)
                        {
                            if (clickedButton.BackColor == Color.Yellow)
                            {
                                // Bỏ chọn ghế
                                clickedButton.BackColor = ghe.MaLoaiGheNavigation?.TenLoaiGhe != "VIP" ? Color.Blue : Color.White;
                                gheChon.Remove(clickedGhe); // Loại ghế khỏi danh sách đã chọn
                            }
                            else
                            {
                                // Chọn ghế
                                clickedButton.BackColor = Color.Yellow;
                                gheChon.Add(clickedGhe); // Thêm ghế vào danh sách đã chọn
                            }
                        }
                    };

                    rowPanel.Controls.Add(button);
                }

                flpSeat.Controls.Add(rowPanel);
            }
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

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (gheChon == null || gheChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế trước khi thanh toán.", "Thông báo");
                return;
            }

            // Hiển thị form thanh toán và truyền danh sách ghế đã chọn
            ThanhToan thanhToanForm = new ThanhToan(gheChon, thongTinXuatChieu);
            thanhToanForm.ShowDialog(); // Mở form dưới dạng modal


        }


        bool KtraViPham(List<Ghe> danhSach, List<Ghe> gheDaChon, int SoGheMotHang)
        {
            if (danhSach == null || gheDaChon == null || danhSach.Count == 0 || gheDaChon.Count == 0)
                return false;

            // Nhóm ghế theo hàng
            var hangGheChon = gheDaChon
                .Where(g => !string.IsNullOrEmpty(g.TenGhe) && g.TenGhe.Length > 1)
                .GroupBy(g => g.TenGhe[0])
                .ToDictionary(
                    g => g.Key,
                    g => g
                        .Select(x => int.TryParse(x.TenGhe.Substring(1), out int soGhe) ? soGhe : 0)
                        .Where(n => n > 0)
                        .OrderBy(n => n)
                        .ToList()
                );

            var danhSachGhe = danhSach
                .Where(g => !string.IsNullOrEmpty(g.TenGhe) && g.TenGhe.Length > 1)
                .GroupBy(g => g.TenGhe[0])
                .ToDictionary(
                    g => g.Key,
                    g => g
                        .Select(x => new
                        {
                            SoGhe = int.TryParse(x.TenGhe.Substring(1), out int soGhe) ? soGhe : 0,
                            TrangThai = x.TrangThai
                        })
                        .Where(n => n.SoGhe > 0)
                        .OrderBy(n => n.SoGhe)
                        .ToList()
                );

            foreach (var hang in hangGheChon)
            {
                var tenHang = hang.Key;
                var soGheDaChon = hang.Value;

                if (!danhSachGhe.ContainsKey(tenHang)) continue;

                var gheTrongHang = danhSachGhe[tenHang];

                // Kiểm tra khoảng trống giữa các ghế đã chọn
                for (int i = 0; i < soGheDaChon.Count - 1; i++)
                {
                    int khoangCach = soGheDaChon[i + 1] - soGheDaChon[i];

                    // Nếu khoảng cách là 2 (chỉ có một ghế trống giữa)
                    if (khoangCach == 2)
                    {
                        int gheTrong = soGheDaChon[i] + 1;

                        // Kiểm tra ghế này trống và chưa được mua
                        if (gheTrongHang.Any(g => g.SoGhe == gheTrong && !g.TrangThai))
                        {
                            MessageBox.Show($"Vi phạm: Ghế {tenHang}{gheTrong} bị bỏ trống giữa ghế {tenHang}{soGheDaChon[i]} và {tenHang}{soGheDaChon[i + 1]}.");
                            return true;
                        }
                    }
                }

                // Kiểm tra ghế đầu tiên trong dãy chọn
                if (soGheDaChon.First() > 1)
                {
                    int gheTruoc = soGheDaChon.First() - 1;
                    int gheTruocSau = gheTruoc - 1;

                    // Ghế trước dãy trống và không có ghế nào lân cận phía sau
                    if (gheTrongHang.Any(g => g.SoGhe == gheTruoc && !g.TrangThai) &&
                        (gheTruocSau < 1 || gheTrongHang.Any(g => g.SoGhe == gheTruocSau && g.TrangThai)))
                    {
                        MessageBox.Show($"Vi phạm hàng {tenHang}: ghế {gheTruoc} bị bỏ trống trước dãy chọn.");
                        return true;
                    }
                }

                // Kiểm tra ghế cuối cùng trong dãy chọn
                if (soGheDaChon.Last() < SoGheMotHang)
                {
                    int gheSau = soGheDaChon.Last() + 1;
                    int gheSauSau = gheSau + 1;

                    // Ghế sau dãy trống và không có ghế nào lân cận phía sau
                    if (gheTrongHang.Any(g => g.SoGhe == gheSau && !g.TrangThai) &&
                        (gheSauSau > SoGheMotHang || gheTrongHang.Any(g => g.SoGhe == gheSauSau && g.TrangThai)))
                    {
                        MessageBox.Show($"Vi phạm hàng {tenHang}: ghế {gheSau} bị bỏ trống sau dãy chọn.");
                        return true;
                    }
                }
            }
            return false; // Không có vi phạm
        }
        private void btnTiepTuc_Click_1(object sender, EventArgs e)
        {
            if (gheChon == null || gheChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế trước khi thanh toán.", "Thông báo");
                return;
            }
            if (KtraViPham(danhSachGhe, gheChon, soGheMotHang))
            {
                return;
            }
            ThanhToan thanhToanForm = new ThanhToan(gheChon, thongTinXuatChieu);
            thanhToanForm.ShowDialog(); // Mở form dưới dạng modal
            GenerateButtons();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LichChieu lichChieu = new LichChieu();
            lichChieu.Show();
            this.Close();
        }
    }
}
