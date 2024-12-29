using FilmsAPI.Models;
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
using System.Text.RegularExpressions;

namespace FilmsManage.GUI.UserControls.Data
{
    public partial class FoodUC : UserControl
    {
        private DangPhimSV sv;
        private string fileName;
        private Food food1;
        public FoodUC()
        {
            sv = new DangPhimSV("https://localhost:7085");
            InitializeComponent();
            LoadFood();
            LoadCates();
        }

        public async void LoadCates()
        {
            try
            {
                var cates = await getCate();
                if (cates == null) cates = new List<Category>();

                // Gán dữ liệu vào ComboBox
                cbbDanhMuc.DataSource = cates;
                cbbDanhMuc.DisplayMember = "Name"; // Tên thuộc tính hiển thị
                cbbDanhMuc.ValueMember = "Id";    // Tên thuộc tính giá trị
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<List<FilmsAPI.Models.Food>> GetFood()
        {
            try
            {
                var response = await sv.GetAsync<List<FilmsAPI.Models.Food>>("/api/BanVe/Doan");

                if (response == null)
                {
                    Debug.WriteLine("Không có đồ ăn nào được tìm thấy");
                    return new List<FilmsAPI.Models.Food>();
                }
                return response;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{ex.Message}");
                return new List<FilmsAPI.Models.Food>();

            }
        }
        public async void LoadFood()
        {
            try
            {
                var foods = await GetFood();
                flowLayoutPanel1.Controls.Clear(); // Clear existing controls

                foreach (var food in foods)
                {
                    var foodPanel = CreateFoodPanel(food);
                    flowLayoutPanel1.Controls.Add(foodPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading food: {ex.Message}");
                Debug.WriteLine($"Error loading food: {ex.Message}");
            }
        }

        public async Task<List<Category>> getCate()
        {
            try
            {
                var response = await sv.GetAsync<List<Category>>("/api/BanVe/GetCateFood");
                if (response == null)
                {
                    return new List<Category>();
                }
                return response;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                return new List<Category>();
            }
        }
        public void FillFood(Food model)
        {
            food1 = model;
            try
            {
                // Gán dữ liệu từ model vào các control
                txtTen.Text = model.Name;
                rtxtMota.Text = model.Description;
                txtGia.Text = model.Price.ToString("N0");

                // Chọn danh mục phù hợp trong ComboBox
                if (cbbDanhMuc.DataSource != null)
                {
                    cbbDanhMuc.SelectedValue = model.CateId; // Giả sử model có CateId
                }

                // Load ảnh từ URL
                ptbFood.Image = LoadImage(model.ImageUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi hiển thị dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchKeyword = txtSearch.Text.Trim(); // Lấy từ khóa tìm kiếm từ textbox

                // Gọi phương thức tìm kiếm với từ khóa
                var foods = await GetFoodByKeyword(searchKeyword);

                // Xóa các control hiện tại trong FlowLayoutPanel
                flowLayoutPanel1.Controls.Clear();

                // Thêm các món ăn vào FlowLayoutPanel
                foreach (var food in foods)
                {
                    var foodPanel = CreateFoodPanel(food); // Tạo panel cho mỗi món ăn
                    flowLayoutPanel1.Controls.Add(foodPanel); // Thêm vào FlowLayoutPanel
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}");
            }
        }

        public async Task<List<Food>> GetFoodByKeyword(string keyword)
        {
            try
            {
                // Lấy danh sách tất cả các món ăn
                var response = await GetFood();

                // Kiểm tra nếu không có món ăn hoặc danh sách rỗng
                if (response == null || !response.Any())
                {
                    return new List<Food>(); // Trả về danh sách rỗng nếu không có món ăn
                }

                // Lọc món ăn theo từ khóa (kiểm tra tên món ăn có chứa từ khóa không)
                var listFoodSearch = response.Where(p => p.Name != null && p.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

                return listFoodSearch;
            }
            catch (Exception ex)
            {
                // Ghi lại lỗi nếu có
                Debug.WriteLine(ex.Message);
                return new List<Food>(); // Trả về danh sách rỗng nếu có lỗi
            }
        }

        private Panel CreateFoodPanel(Food food)
        {
            var panel = new Panel
            {
                Width = flowLayoutPanel1.Width / 4 - 20, // Adjust width to fit 4 items per row
                Height = 180, // Adjust height as needed
                Margin = new Padding(10),
                Padding = new Padding(10),
                BorderStyle = BorderStyle.None,
                BackColor = Color.LightGray
            };

            var pictureBox = new PictureBox
            {
                Image = LoadImage(food.ImageUrl), // Use a method to load the image
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Top,
                Height = 120, // Adjust height as needed
                Margin = new Padding(5),
                BorderStyle = BorderStyle.FixedSingle
            };
            pictureBox.Click += (s, e) =>
            {
                FillFood(food);
            };

            var label = new Label
            {
                Text = food.Name,
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 40, // Adjust height as needed
                BackColor = Color.DarkSlateGray,
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Padding = new Padding(5)
            };

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(label);

            // Make the panel have rounded corners
            panel.Paint += (s, e) =>
            {
                var graphics = e.Graphics;
                var rect = panel.ClientRectangle;
                var radius = 10;
                var path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();
                panel.Region = new Region(path);
            };

            return panel;
        }
        private Image LoadImage(string imageUrl)
        {
            try
            {
                // Check if the image URL is a web URL
                if (Uri.IsWellFormedUriString(imageUrl, UriKind.Absolute) && (imageUrl.StartsWith("http://") || imageUrl.StartsWith("https://")))
                {
                    using (var webClient = new System.Net.WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var ms = new System.IO.MemoryStream(imageBytes))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                }
                // Check if the image URL is a valid local path
                else if (System.IO.File.Exists(imageUrl))
                {
                    return Image.FromFile(imageUrl);
                }
                else
                {
                    // Load a default image if path is invalid
                    return Image.FromFile(@"D:\CSharp\Winforms\FilmsManage\FilmsManage\FilmsManage\Image\Logo.jpg");
                }
            }
            catch (System.Net.WebException webEx)
            {
                Debug.WriteLine($"Error loading image from URL: {webEx.Message}");
                // Load a default image if URL loading fails
                return Image.FromFile(@"D:\CSharp\Winforms\FilmsManage\FilmsManage\FilmsManage\Image\Logo.jpg");
            }
            catch (System.IO.FileNotFoundException fileEx)
            {
                Debug.WriteLine($"Error loading image from file: {fileEx.Message}");
                // Load a default image if file loading fails
                return Image.FromFile(@"Winform/FilmsManage/FilmsManage/Image/Logo.jpg");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unexpected error loading image: {ex.Message}");
                // Load a default image for any other errors
                return Image.FromFile(@"Winform/FilmsManage/FilmsManage/Image/Logo.jpg");
            }
        }
        private void btnThem_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Xóa nền bằng màu nền của nút
                e.Graphics.Clear(btn.BackColor);

                // Vẽ viền cho nút với màu xanh dương đậm và bóng mờ
                using (Pen pen = new Pen(Color.DeepSkyBlue, 2))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, btn.Width - 1, btn.Height - 1);
                }

                // Tạo gradient nền cho nút (hiệu ứng mờ dần)
                using (LinearGradientBrush brush = new LinearGradientBrush(btn.ClientRectangle, Color.LightSkyBlue, Color.SkyBlue, 45f))
                {
                    e.Graphics.FillRectangle(brush, btn.ClientRectangle);
                }

                // Vẽ văn bản trên nút với màu trắng
                using (Font textFont = new Font("Segoe UI", 10, FontStyle.Bold))
                {
                    using (SolidBrush textBrush = new SolidBrush(Color.White))
                    {
                        string buttonText = "Thêm mới";
                        SizeF textSize = e.Graphics.MeasureString(buttonText, textFont);
                        // Căn giữa văn bản trên nút
                        e.Graphics.DrawString(buttonText, textFont, textBrush,
                            new PointF((btn.Width - textSize.Width) / 2, (btn.Height - textSize.Height) / 2));
                    }
                }
            }
        }

        private void btnSua_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Xóa nền nút
                e.Graphics.Clear(btn.BackColor);

                // Vẽ viền cho nút với màu vàng đậm và bóng mờ
                using (Pen pen = new Pen(Color.Goldenrod, 2))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, btn.Width - 1, btn.Height - 1);
                }

                // Tạo gradient nền cho nút (hiệu ứng mờ dần)
                using (LinearGradientBrush brush = new LinearGradientBrush(btn.ClientRectangle, Color.Goldenrod, Color.Yellow, 45f))
                {
                    e.Graphics.FillRectangle(brush, btn.ClientRectangle);
                }

                // Vẽ văn bản trên nút với màu trắng
                using (Font textFont = new Font("Segoe UI", 10, FontStyle.Bold))
                {
                    using (SolidBrush textBrush = new SolidBrush(Color.White))
                    {
                        string buttonText = "Sửa";
                        SizeF textSize = e.Graphics.MeasureString(buttonText, textFont);
                        // Căn giữa văn bản trên nút
                        e.Graphics.DrawString(buttonText, textFont, textBrush,
                            new PointF((btn.Width - textSize.Width) / 2, (btn.Height - textSize.Height) / 2));
                    }
                }
            }
        }

        private void btnXoa_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Xóa nền nút
                e.Graphics.Clear(btn.BackColor);

                // Vẽ viền cho nút với màu đỏ đậm và bóng mờ
                using (Pen pen = new Pen(Color.DarkRed, 2))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, btn.Width - 1, btn.Height - 1);
                }

                // Tạo gradient nền cho nút (hiệu ứng mờ dần)
                using (LinearGradientBrush brush = new LinearGradientBrush(btn.ClientRectangle, Color.LightCoral, Color.IndianRed, 45f))
                {
                    e.Graphics.FillRectangle(brush, btn.ClientRectangle);
                }

                // Vẽ văn bản trên nút với màu trắng
                using (Font textFont = new Font("Segoe UI", 10, FontStyle.Bold))
                {
                    using (SolidBrush textBrush = new SolidBrush(Color.White))
                    {
                        string buttonText = "Xóa";
                        SizeF textSize = e.Graphics.MeasureString(buttonText, textFont);
                        // Căn giữa văn bản trên nút
                        e.Graphics.DrawString(buttonText, textFont, textBrush,
                            new PointF((btn.Width - textSize.Width) / 2, (btn.Height - textSize.Height) / 2));
                    }
                }
            }
        }
        private void txtSearch_Paint(object sender, PaintEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                // Vẽ nền TextBox (màu nền)
                e.Graphics.Clear(Color.White); // Màu nền sáng cho TextBox

                // Vẽ viền mượt mà cho TextBox
                using (Pen pen = new Pen(Color.Gray, 2)) // Màu viền xám nhạt và độ dày viền
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, txt.Width - 1, txt.Height - 1);
                }

                // Vẽ biểu tượng kính lúp (🔍)
                using (Font iconFont = new Font("Segoe UI", 12))
                {
                    using (SolidBrush iconBrush = new SolidBrush(Color.Gray))
                    {
                        // Vẽ biểu tượng kính lúp ở bên trái TextBox
                        e.Graphics.DrawString("🔍", iconFont, iconBrush, new PointF(10, (txt.Height - iconFont.Height) / 2));
                    }
                }

                // Đảm bảo văn bản trong TextBox không bị vẽ lại
                txt.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            var rect = flowLayoutPanel1.ClientRectangle;

            // Vẽ viền cho FlowLayoutPanel
            int borderWidth = 2; // Độ dày của viền
            var pen = new Pen(Color.Black, borderWidth); // Chọn màu và độ dày viền

            // Vẽ viền xung quanh FlowLayoutPanel
            graphics.DrawRectangle(pen, rect);

            // Nếu bạn muốn viền có góc bo tròn, hãy thêm mã sau:
            var radius = 10; // Độ bo góc
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Thiết lập vùng cho FlowLayoutPanel để hiển thị bo góc
            flowLayoutPanel1.Region = new Region(path);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Vẽ nền màu trắng
            e.Graphics.Clear(Color.White);

            // Lấy kích thước của panel
            var rect = panel1.ClientRectangle;

            // Vẽ viền cho panel
            int borderWidth = 2; // Độ dày của viền
            var pen = new Pen(Color.Black, borderWidth); // Màu viền và độ dày
            e.Graphics.DrawRectangle(pen, rect);

            // Bo góc panel
            var radius = 10; // Độ bo góc
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Góc trên trái
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90); // Góc trên phải
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90); // Góc dưới phải
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90); // Góc dưới trái
            path.CloseFigure();

            // Thiết lập vùng cho panel để bo góc
            panel1.Region = new Region(path);
        }

        private void btnThayDoi_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Xóa nền nút
                e.Graphics.Clear(btn.BackColor);

                // Vẽ viền cho nút với màu vàng đậm và bóng mờ
                using (Pen pen = new Pen(Color.Goldenrod, 2))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, btn.Width - 1, btn.Height - 1);
                }

                // Tạo gradient nền cho nút (hiệu ứng mờ dần)
                using (LinearGradientBrush brush = new LinearGradientBrush(btn.ClientRectangle, Color.Goldenrod, Color.Yellow, 45f))
                {
                    e.Graphics.FillRectangle(brush, btn.ClientRectangle);
                }

                // Vẽ văn bản trên nút với màu trắng
                using (Font textFont = new Font("Segoe UI", 10, FontStyle.Bold))
                {
                    using (SolidBrush textBrush = new SolidBrush(Color.White))
                    {
                        string buttonText = "Thay đổi";
                        SizeF textSize = e.Graphics.MeasureString(buttonText, textFont);
                        // Căn giữa văn bản trên nút
                        e.Graphics.DrawString(buttonText, textFont, textBrush,
                            new PointF((btn.Width - textSize.Width) / 2, (btn.Height - textSize.Height) / 2));
                    }
                }
            }
        }

        public Food GetFoodFromForm(string feature, int? id)
        {
            try
            {
                string pattern = @"^\d+([.,]\d+)?$";
                if (!Regex.IsMatch(txtGia.Text, pattern))
                {
                    MessageBox.Show("Giá không hợp lệ. Vui lòng nhập đúng định dạng số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                var price = decimal.Parse(txtGia.Text);

                var food = new Food()
                {
                    Name = txtTen.Text,
                    Description = rtxtMota.Text,
                    Price = price,
                    CateId = Convert.ToInt32(cbbDanhMuc.SelectedValue),
                    ImageUrl = fileName ?? "" // Đảm bảo không có giá trị null
                };

                if (feature.ToLower() == "update" && id != 0)
                {
                    food.Id = id.Value; // Gán Id khi update
                }

                return food; // Trả về đối tượng Food
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        private async void btnSua_Click(object sender, EventArgs e)
        {
            var food = GetFoodFromForm("update", food1.Id);
            try
            {
                var response = await sv.PutAsync<Models.ApiRespone>("/api/Food/UpdateFood", food);
                if (response != null)
                {
                    MessageBox.Show(response.Message);
                    LoadFood();
                    return;
                }
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        private async void btnThem_Click(object sender, EventArgs e)
        {
            var food = GetFoodFromForm("add", 0); // Gọi hàm GetFoodFromForm, không cần ID cho món ăn mới
            if (food == null)
            {
                MessageBox.Show("Thông tin món ăn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi API để thêm món ăn
                var response = await sv.PostAsync<Models.ApiRespone>("/api/Food/AddFood", food);
                if (response != null)
                {
                    MessageBox.Show(response.Message);
                    LoadFood();
                    return;
                }
                MessageBox.Show("Có lỗi xảy ra khi thêm món ăn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void saveImage()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(fileName))
                {
                    string destinationFolder = Path.Combine(Application.StartupPath, "Image");
                    string fileNamePath = Path.GetFileName(fileName);

                    // Tạo thư mục nếu chưa tồn tại
                    if (!Directory.Exists(destinationFolder))
                    {
                        Directory.CreateDirectory(destinationFolder);
                    }

                    // Sao chép file vào thư mục đích
                    string destinationPath = Path.Combine(destinationFolder, fileNamePath);
                    File.Copy(fileName, destinationPath, true);

                    MessageBox.Show("Ảnh đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chưa chọn ảnh để upload.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.Title = "Chọn ảnh để upload";

            // Kiểm tra nếu người dùng chọn file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file
                string filePath = openFileDialog1.FileName;

                // Hiển thị ảnh trong PictureBox
                ptbFood.Image = Image.FromFile(filePath);
                ptbFood.SizeMode = PictureBoxSizeMode.StretchImage;

                // Lưu đường dẫn file vào TextBox (nếu cần lưu vào DB)
                fileName = filePath;
            }


        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (food1 == null)
            {
                MessageBox.Show("Chọn 1 sản phẩm để xóa!");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {

                    var response = await sv.DeleteAsync($"/api/Food/DeleteFood/{food1.Id}");


                    if (response)
                    {
                        LoadFood();
                    }
                    else
                    {
                        MessageBox.Show("Xóa món ăn không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        
    }
}
