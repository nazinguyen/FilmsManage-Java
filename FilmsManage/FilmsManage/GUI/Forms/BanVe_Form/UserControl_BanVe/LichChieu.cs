using FilmsAPI.Models;
using FilmsManage.DTO;
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

namespace FilmsManage.GUI.Forms.BanVe_Form.UserControl_BanVe
{
    public partial class LichChieu : UserControl
    {
        // Danh sách phim
        private List<XuatChieu> films = new List<XuatChieu>();
        private readonly DangPhimSV _lichChieuService;
        private int maXuatChieu;
        private Main_Form mainForm;

        public LichChieu(Main_Form mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            _lichChieuService = new DangPhimSV("https://localhost:7085");
            LichChieu_Load(null, null);
        }

        /// <summary>
        /// Phương thức tải dữ liệu phim từ API
        /// </summary>
        private async Task LoadFilmsFromAPI()
        {
            try
            {
                var phimList = await _lichChieuService.GetAsync<List<XuatChieu>>("/api/LichChieu/GetXuatChieu");
                var filteredPhimList = phimList.Where(item => item.ThoiGianBatDau > DateTime.Now).ToList();
                foreach (var item in filteredPhimList)
                {
                    //if (item.NgayKc > DateTime.Now)
                    //{
                    // Tạo đối tượng phim mới từ dữ liệu nhận được
                    films.Add(item);
                    LoadFilmToTextBox(item);
                    //}
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Lỗi tải phim: {ex.Message}");
            }
        }


        /// <summary>
        /// Hiển thị thông tin phim vào FlowLayoutPanel
        /// </summary>
        private void LoadFilmToTextBox(XuatChieu phim)
        {
            var filmPanel = CreateFilmPanel(phim);
            flowLayoutPanel1.Controls.Add(filmPanel);
            flowLayoutPanel1.AutoScroll = true;
        }

        /// <summary>
        /// Tạo panel hiển thị thông tin phim
        /// </summary>
        private Panel CreateFilmPanel(XuatChieu phim)
        {
            var filmPanel = new Panel
            {
                Size = new Size(366, 470),
                Margin = new Padding(12), // Khoảng cách bên ngoài
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Padding = new Padding(10),
                Cursor = Cursors.Hand
            };

            var filmPictureBox = CreatePictureBox(phim);
            var panelInfo = CreateFilmInfoPanel(phim);
            filmPanel.BackColor = Color.White;
            filmPanel.BorderStyle = BorderStyle.None;
            filmPanel.Region = new Region(new RectangleF(0, 0, filmPanel.Width, filmPanel.Height));
            filmPanel.BackColor = Color.FromArgb(248, 249, 250);
            filmPanel.Controls.Add(filmPictureBox);
            filmPanel.Controls.Add(panelInfo);

            return filmPanel;
        }

        /// <summary>
        /// Tạo PictureBox để hiển thị ảnh bìa phim
        /// </summary>
        private PictureBox CreatePictureBox(XuatChieu phim)
        {
            var pictureBox = new PictureBox
            {
                Location = new Point(77, 3),
                Size = new Size(205, 230),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.None,
                BackColor = Color.White
            };

            if (!string.IsNullOrEmpty(phim.MaPhimNavigation?.AnhBia))
            {
                try
                {
                    pictureBox.Load(phim.MaPhimNavigation?.AnhBia);
                }
                catch (Exception)
                {
                    pictureBox.Image = null;
                }
            }
            pictureBox.Region = new Region(new RectangleF(0, 0, pictureBox.Width, pictureBox.Height));
            return pictureBox;
        }

        /// <summary>
        /// Tạo panel chứa thông tin phim
        /// </summary>
        private Panel CreateFilmInfoPanel(XuatChieu phim)
        {
            var panelInfo = new Panel
            {
                Location = new Point(0, 245),
                Size = new Size(366, 250)
            };

            var titleLabel = new Label
            {
                Text = phim.MaPhimNavigation?.TenPhim,
                Location = new Point(13, 10),
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.DarkSlateGray,
                Size = new Size(340, 40)
            };

            var genreLabel = new Label
            {
                Location = new Point(13, 50),
                Font = new Font("Arial", 12),
                ForeColor = Color.DimGray,
                Size = new Size(340, 25)
            };
            foreach (var item in phim.MaPhimNavigation.TheLoaiCuaPhims)
            {
                genreLabel.Text = $"Thể loại: {item.MaTheLoaiNavigation.TenTheLoai}";
            }

            var durationLabel = new Label
            {
                Text = $"Thời lượng: {phim.MaPhimNavigation?.ThoiLuong} phút",
                Location = new Point(13, 90),
                Font = new Font("Arial", 12),
                ForeColor = Color.DimGray,
                Size = new Size(340, 25)
            };

            var dateLabel = new Label
            {
                Text = $"Giờ chiếu: {phim.ThoiGianBatDau:HH:mm}",
                Location = new Point(13, 130),
                Font = new Font("Arial", 12),
                ForeColor = Color.DimGray,
                Size = new Size(340, 25),
            };

            var buyTicketButton = new Button
            {
                Text = "Mua vé",
                Size = new Size(100, 40),
                BackColor = Color.FromArgb(34, 193, 195),
                Location = new Point(133, 170),

                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            buyTicketButton.Click += (s, e) => BuyTicket(phim.MaXuatChieu);
            maXuatChieu = phim.MaXuatChieu;
            // Thêm hiệu ứng hover
            buyTicketButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 153, 157);
            buyTicketButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 143, 145);
            panelInfo.Controls.Add(titleLabel);
            panelInfo.Controls.Add(durationLabel);
            panelInfo.Controls.Add(dateLabel);
            panelInfo.Controls.Add(buyTicketButton);
            panelInfo.Controls.Add(genreLabel);

            return panelInfo;
        }

        private void BuyTicket(int xuatChieuId)
        {
           
            var themSua = mainForm.panel4.Controls.OfType<UserControl_BanVe.BanVe>().FirstOrDefault();

            if (themSua != null)
            {
                mainForm.panel4.Controls.Remove(themSua);
                themSua.Dispose();
            }
            foreach (Control control in mainForm.panel4.Controls)
            {
                control.Visible = false;
            }

            themSua = new UserControl_BanVe.BanVe(xuatChieuId, mainForm);
            themSua.Dock = DockStyle.Fill;
            mainForm.panel4.Controls.Add(themSua);

           

        }


        /// <summary>
        /// Phương thức tải dữ liệu thể loại từ API
        /// </summary>
        private async Task LoadGenresToComboBox()
        {
            try
            {

                // Gọi API để lấy danh sách thể loại
                var genreList = await _lichChieuService.GetAsync<List<LoaiPhimDTO.TheLoaiDTO>>("/api/LichChieu/GetAllTheLoai");

                // Thêm mục mặc định "Thể loại" vào danh sách
                genreList.Insert(0, new LoaiPhimDTO.TheLoaiDTO
                {
                    MaTheLoai = 0, // Giá trị không có ý nghĩa thực tế, chỉ dùng để kiểm tra
                    TenTheLoai = "Thể loại"
                });

                // Gán danh sách thể loại vào ComboBox
                comboBox1.DataSource = genreList;
                comboBox1.DisplayMember = "TenTheLoai"; // Thuộc tính hiển thị
                comboBox1.ValueMember = "MaTheLoai";   // Giá trị ẩn
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Lỗi tải thể loại: {ex.Message}");
            }
        }



        /// <summary>
        /// Xử lý sự kiện khi form được load
        /// </summary>
        private async void LichChieu_Load(object sender, EventArgs e)
        {
            await LoadGenresToComboBox(); // Tải danh sách thể loại lên ComboBox
            await LoadFilmsFromAPI();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is int selectedGenreId && selectedGenreId == 0)
            {
                DisplayFilms(films);
            }
            else if (comboBox1.SelectedValue is int validGenreId)
            {
                // Lọc danh sách phim theo thể loại được chọn
                var filteredFilms = films.Where(f =>
                    f.MaPhimNavigation.TheLoaiCuaPhims.Any(tl => tl.MaTheLoai == validGenreId)
                ).ToList();

                // Hiển thị các phim phù hợp với thể loại
                DisplayFilms(filteredFilms);
            }
        }


        // Sự kiện khi người dùng nhấn vào TextBox
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tìm kiếm ...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black; // Đổi màu chữ nếu cần
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Tìm kiếm ...";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var searchText = textBox1.Text.Trim().ToLower(); // Lấy giá trị tìm kiếm và chuyển thành chữ thường
            var filteredFilms = films;

            // Nếu có từ khóa tìm kiếm
            if (!string.IsNullOrEmpty(searchText))
            {
                filteredFilms = filteredFilms
                    .Where(f => f.MaPhimNavigation.TenPhim.ToLower().Contains(searchText))
                    .ToList();
            }

            // Kiểm tra nếu có thể loại đã chọn
            if (comboBox1.SelectedValue is int selectedGenreId && selectedGenreId != 0)
            {
                filteredFilms = filteredFilms
                    .Where(f => f.MaPhimNavigation.TheLoaiCuaPhims.Any(tl => tl.MaTheLoai == selectedGenreId))
                    .ToList();
            }

            // Hiển thị các phim phù hợp với điều kiện tìm kiếm và thể loại
            DisplayFilms(filteredFilms);
        }


        // Hàm hiển thị phim lên FlowLayoutPanel
        private void DisplayFilms(List<XuatChieu> filmsToDisplay)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var film in filmsToDisplay)
            {
                LoadFilmToTextBox(film);
            }
        }
    }
}
