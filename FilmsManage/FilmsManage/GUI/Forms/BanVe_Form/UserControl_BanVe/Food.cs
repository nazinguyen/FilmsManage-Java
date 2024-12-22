using FilmsManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmsAPI.Models;
using FilmsManage.DTO;

namespace FilmsManage.GUI.Forms.BanVe_Form.UserControl_BanVe
{
    public partial class Food : UserControl
    {
        private DangPhimSV _sv;
        private List<FoodDTO> addedProducts = new List<FoodDTO>();
        private Main_Form mainForm;
        private List<Ghe> gheChon;
        private XuatChieu xuatChieu;

        public Food(Main_Form mainForm, List<Ghe> ghes, XuatChieu xuatChieu)
        {
            this.xuatChieu = xuatChieu;
            gheChon = ghes;
            this.mainForm = mainForm;
            _sv = new DangPhimSV("https://localhost:7085");
            InitializeComponent();
            btnTatCa_Click(null, null);
        }
        public async void LoadFood(List<FilmsAPI.Models.Food> products)
        {
            flpFillFood.Controls.Clear();

            string defaultImagePath = @"C:\Users\Admin\Downloads\Screenshot 2024-11-11 210536.jpg";

            foreach (var product in products)
            {
                // Tạo panel con cho sản phẩm
                Panel productPanel = new Panel();
                productPanel.Size = new Size(220, 280);
                productPanel.Margin = new Padding(10);
                productPanel.BackColor = Color.White;
                productPanel.BorderStyle = BorderStyle.None;

                productPanel.Paint += (sender, e) =>
                {
                    var panel = (Panel)sender;
                    var graphics = e.Graphics;
                    var rectangle = new Rectangle(0, 0, panel.ClientSize.Width - 1, panel.ClientSize.Height - 1);
                    var borderRadius = 15;
                    var path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddArc(rectangle.X, rectangle.Y, borderRadius, borderRadius, 180, 90);
                    path.AddArc(rectangle.X + rectangle.Width - borderRadius, rectangle.Y, borderRadius, borderRadius, 270, 90);
                    path.AddArc(rectangle.X + rectangle.Width - borderRadius, rectangle.Y + rectangle.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                    path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                    graphics.FillPath(new SolidBrush(Color.White), path);
                    graphics.DrawPath(new Pen(Color.Black, 2), path);
                };

                // Hình ảnh sản phẩm
                PictureBox pictureBox = new PictureBox();
                string imagePath = Path.Combine("Images", product.ImageUrl);
                if (File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox.Image = Image.FromFile(defaultImagePath);
                }
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(180, 120);
                pictureBox.Location = new Point(20, 10);

                // Tên sản phẩm
                Label lblName = new Label();
                lblName.Text = product.Name;
                lblName.AutoSize = false;
                lblName.Size = new Size(180, 40);
                lblName.Location = new Point(20, 140);
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                lblName.Font = new Font("Arial", 12, FontStyle.Bold);

                // Giá sản phẩm
                Label lblPrice = new Label();
                lblPrice.Text = $"{product.Price:#,##0} đ";
                lblPrice.AutoSize = true;
                lblPrice.Location = new Point(20, 200);
                lblPrice.Font = new Font("Arial", 10, FontStyle.Regular);

                // Nút thêm sản phẩm (+)
                Button btnAdd = new Button();
                btnAdd.Text = "+";
                btnAdd.Size = new Size(40, 40);
                btnAdd.Location = new Point(160, 180);
                btnAdd.Font = new Font("Arial", 14, FontStyle.Bold);
                btnAdd.BackColor = Color.FromArgb(0, 123, 255);
                btnAdd.ForeColor = Color.White;
                btnAdd.FlatStyle = FlatStyle.Flat;
                btnAdd.FlatAppearance.BorderSize = 0;

                btnAdd.Click += (s, e) =>
                {
                    var existingProduct = addedProducts.FirstOrDefault(p => p.Id == product.Id); // Kiểm tra sản phẩm đã tồn tại chưa

                    if (existingProduct != null)
                    {
                        // Tăng số lượng sản phẩm nếu đã tồn tại
                        existingProduct.Quantity += 1; // Cần thêm thuộc tính Quantity vào lớp Food
                    }
                    else
                    {

                        var food = new FoodDTO()
                        {
                            Id = product.Id,
                            Name = product.Name,
                            ImageUrl = product.ImageUrl,
                            Quantity = 1,
                            Price = product.Price,
                        };
                        addedProducts.Add(food);
                    }

                    UpdateAddedProducts();
                };

                // Thêm các control vào panel con
                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(lblName);
                productPanel.Controls.Add(lblPrice);
                productPanel.Controls.Add(btnAdd);

                // Thêm panel con vào FlowLayoutPanel
                flpFillFood.Controls.Add(productPanel);
            }

            flpFillFood.WrapContents = true;
            flpFillFood.FlowDirection = FlowDirection.LeftToRight;
            flpFillFood.AutoScroll = true;
            flpFillFood.Padding = new Padding(10);
        }

        private void UpdateAddedProducts()
        {
            // Xóa các panel cũ
            flowLayoutPanel1.Controls.Clear();

            foreach (var product in addedProducts)
            {
                // Tạo Panel sản phẩm
                Panel productPanel = new Panel();

                // Điều chỉnh kích thước nhỏ lại 10 pixel (giảm độ rộng)
                productPanel.Size = new Size(370, 90); // Chiều rộng giảm từ 380 xuống 370

                // Đặt vị trí để dịch sang phải 5 pixel
                productPanel.Location = new Point(productPanel.Location.X + 5, productPanel.Location.Y);

                // Thiết lập màu nền
                productPanel.BackColor = Color.White; // Background màu trắng

                // Bo góc cho Panel
                int radius = 10; // Độ bo tròn
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(productPanel.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(productPanel.Width - radius, productPanel.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, productPanel.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                productPanel.Region = new Region(path);

                // Kiểm tra và lấy hình ảnh sản phẩm
                string imagePath = string.IsNullOrEmpty(product.ImageUrl) ?
                    @"C:\Users\Admin\Downloads\Screenshot 2024-11-11 210536.jpg" :
                    product.ImageUrl;

                PictureBox pictureBox = new PictureBox();
                try
                {
                    pictureBox.Image = Image.FromFile(imagePath); // Kiểm tra đường dẫn hình ảnh
                }
                catch (FileNotFoundException)
                {
                    pictureBox.Image = Image.FromFile(@"C:\Users\Admin\Downloads\Screenshot 2024-11-11 210536.jpg"); // Hình ảnh mặc định khi không tìm thấy
                }

                pictureBox.Size = new Size(70, 70);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Location = new Point(10, 10);

                // Thêm nhãn tên sản phẩm
                Label lblName = new Label();
                lblName.Text = product.Name;
                lblName.Font = new Font("Arial", 10, FontStyle.Bold);
                lblName.AutoSize = true;
                lblName.Location = new Point(100, 10);

                // Thêm nút xóa (icon "X")
                Button btnRemove = new Button();
                btnRemove.Text = "✖";
                btnRemove.Size = new Size(30, 50);
                btnRemove.Location = new Point(340, 10); // Dịch sang trái 10px
                btnRemove.FlatStyle = FlatStyle.Flat;
                btnRemove.FlatAppearance.BorderSize = 0;
                btnRemove.ForeColor = Color.Gray;

                // Thêm sự kiện xóa sản phẩm
                btnRemove.Click += (s, e) =>
                {
                    addedProducts.Remove(product);
                    UpdateAddedProducts(); // Cập nhật lại danh sách sau khi xóa
                };

                // Thêm nhãn giá sản phẩm
                Label lblPrice = new Label();
                lblPrice.Text = (product.Price * product.Quantity).ToString("#,##0 đ");
                lblPrice.Font = new Font("Arial", 10, FontStyle.Bold);
                lblPrice.ForeColor = Color.OrangeRed;
                lblPrice.AutoSize = true;
                lblPrice.Location = new Point(200, 50);

                // Thêm số lượng sản phẩm và nút tăng/giảm
                NumericUpDown numQuantity = new NumericUpDown();
                numQuantity.Minimum = 1;
                numQuantity.Value = product.Quantity;
                numQuantity.Size = new Size(60, 25);
                numQuantity.Location = new Point(130, 45);
                numQuantity.TextAlign = HorizontalAlignment.Center;

                // Cập nhật lại số lượng sản phẩm khi giá trị NumericUpDown thay đổi
                numQuantity.ValueChanged += (s, e) =>
                {
                    var updatedProduct = addedProducts.FirstOrDefault(p => p.Id == product.Id);
                    if (updatedProduct != null)
                    {
                        updatedProduct.Quantity = (int)numQuantity.Value;
                        lblPrice.Text = (updatedProduct.Quantity * updatedProduct.Price).ToString("#,##0 đ");
                    }
                };

                // Thêm tất cả vào Panel sản phẩm
                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(lblName);
                productPanel.Controls.Add(btnRemove);
                productPanel.Controls.Add(numQuantity);
                productPanel.Controls.Add(lblPrice);

                // Thêm Panel vào FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(productPanel);
            }
        }


        private void btnTatCa_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            // Bo góc cho Button
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
            int borderRadius = 15; // Độ bo góc

            // Tạo màu gradient cho Button
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightSkyBlue, Color.DeepSkyBlue, 45f))
            using (GraphicsPath path = GetRoundedRectangle(rect, borderRadius))
            {
                // Vẽ nền gradient bo góc
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillPath(brush, path);
            }

            // Vẽ chữ ở giữa button
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

        private void BtnDoAn_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            // Bo góc cho Button
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
            int borderRadius = 15; // Độ bo góc

            // Tạo màu gradient cho Button
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightSkyBlue, Color.DeepSkyBlue, 45f))
            using (GraphicsPath path = GetRoundedRectangle(rect, borderRadius))
            {
                // Vẽ nền gradient bo góc
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillPath(brush, path);
            }

            // Vẽ chữ ở giữa button
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

        private void BtnNuocUong_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            // Bo góc cho Button
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
            int borderRadius = 15; // Độ bo góc

            // Tạo màu gradient cho Button
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightSkyBlue, Color.DeepSkyBlue, 45f))
            using (GraphicsPath path = GetRoundedRectangle(rect, borderRadius))
            {
                // Vẽ nền gradient bo góc
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillPath(brush, path);
            }

            // Vẽ chữ ở giữa button
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

        private async void btnTatCa_Click(object sender, EventArgs e)
        {
            try
            {
                var allFood = await _sv.GetAsync<List<FilmsAPI.Models.Food>>("/api/BanVe/Doan");
                if (allFood == null) return;
                LoadFood(allFood);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void BtnDoAn_Click(object sender, EventArgs e)
        {
            try
            {
                var cates = await _sv.GetAsync<List<Category>>("/api/BanVe/GetCateFood");
                if (cates == null) return;

                var Cate = cates.Where(c => c.Name == "Bỏng ngô").FirstOrDefault();
                if (Cate == null) return;

                var foods = await _sv.GetAsync<List<FilmsAPI.Models.Food>>($"/api/BanVe/GetFoodByCategory/{Cate.Id}");
                if (foods == null) return;

                LoadFood(foods);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private async void BtnNuocUong_Click(object sender, EventArgs e)
        {
            try
            {
                var cates = await _sv.GetAsync<List<Category>>("/api/BanVe/GetCateFood");
                if (cates == null) return;

                var Cate = cates.Where(c => c.Name == "Nước uống").FirstOrDefault();
                if (Cate == null) return;

                var foods = await _sv.GetAsync<List<FilmsAPI.Models.Food>>($"/api/BanVe/GetFoodByCategory/{Cate.Id}");
                if (foods == null) return;

                LoadFood(foods);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;

            // Kiểm tra nếu panel không null
            if (panel != null)
            {
                // Tạo một bút để vẽ viền
                using (Pen pen = new Pen(Color.Black, 2)) // Màu đen, độ dày 2
                {
                    // Vẽ đường thẳng ở dưới cùng của panel
                    e.Graphics.DrawLine(pen,
                        0, panel.Height - 1,      // Điểm bắt đầu (góc trái dưới)
                        panel.Width, panel.Height - 1 // Điểm kết thúc (góc phải dưới)
                    );
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;

            if (panel != null)
            {
                // Đặt bán kính bo góc
                int cornerRadius = 20;

                // Đặt màu viền và độ dày
                Color borderColor = Color.Black;
                int borderWidth = 2;

                // Tạo GraphicsPath cho hình chữ nhật bo góc
                using (GraphicsPath path = new GraphicsPath())
                {
                    // Vẽ hình chữ nhật với góc bo tròn
                    path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Góc trên trái
                    path.AddArc(panel.Width - cornerRadius - 1, 0, cornerRadius, cornerRadius, 270, 90); // Góc trên phải
                    path.AddArc(panel.Width - cornerRadius - 1, panel.Height - cornerRadius - 1, cornerRadius, cornerRadius, 0, 90); // Góc dưới phải
                    path.AddArc(0, panel.Height - cornerRadius - 1, cornerRadius, cornerRadius, 90, 90); // Góc dưới trái
                    path.CloseFigure();

                    // Vẽ viền
                    using (Pen pen = new Pen(borderColor, borderWidth))
                    {
                        pen.Alignment = PenAlignment.Inset; // Vẽ viền bên trong
                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Chống răng cưa
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        private void btnTiepTuc_Paint(object sender, PaintEventArgs e)
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

        private void btnHuy_Paint(object sender, PaintEventArgs e)
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

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                  "Bạn có chắc chắn muốn tiếp tục không?",
                  "Xác nhận tiếp tục",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question
            );

            // Kiểm tra người dùng chọn Yes
            if (result == DialogResult.Yes)
            {
                // Tìm control kiểu ThanhToan nếu đã tồn tại
                var themSua = mainForm.panel4.Controls
                    .OfType<UserControl_BanVe.ThanhToan>()
                    .FirstOrDefault();

                // Nếu tìm thấy, loại bỏ nó
                if (themSua != null)
                {
                    mainForm.panel4.Controls.Remove(themSua);
                    themSua.Dispose();
                }

                // Ẩn tất cả các control trong panel
                foreach (Control control in mainForm.panel4.Controls)
                {
                    control.Visible = false;
                }

                // Tạo và thêm control ThanhToan mới
                themSua = new UserControl_BanVe.ThanhToan(
                    mainForm,
                    gheChon ?? new List<Ghe>(),
                    xuatChieu ?? new XuatChieu(),
                    addedProducts
                );
                themSua.Dock = DockStyle.Fill;
                mainForm.panel4.Controls.Add(themSua);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy không?",
                "Xác nhận hủy",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Kiểm tra người dùng chọn Yes
            if (result == DialogResult.Yes)
            {
                addedProducts.Clear();
                UpdateAddedProducts();
            }

        }
    }
}
