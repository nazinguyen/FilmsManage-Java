using FilmsAPI.Models;
using FilmsManage.GUI.DataUserControl;
using FilmsManage.Models;
using FilmsManage.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsManage.GUI.UserControls.Data
{
    public partial class TheLoaiPhimUC : UserControl
    {
        private readonly DangPhimSV _dangPhimSV;
        private DataUC dataUC;

        public TheLoaiPhimUC(DataUC data)
        {
            dataUC = data;
            InitializeComponent();
            _dangPhimSV = new DangPhimSV("https://localhost:7085");
            ConfigureDataGridView();
            LoadData();
            txtGenreID.Enabled = false;

        }

        public void ConfigureDataGridView()
        {
            dtgvGenre.Columns.Clear();

            dtgvGenre.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TitleId",
                HeaderText = "Mã Thể Loại",
                DataPropertyName = "MaTheLoai",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dtgvGenre.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GenreName",
                HeaderText = "Tên Thể Loại",
                DataPropertyName = "TenTheLoai",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dtgvGenre.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Number",
                HeaderText = "Số phim đang có",
                DataPropertyName = "SoLuongPhim",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Tùy chọn cho DataGridView
            dtgvGenre.AutoGenerateColumns = false; // Ngăn việc tự động tạo cột
            dtgvGenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng
            dtgvGenre.MultiSelect = false; // Không cho phép chọn nhiều dòng
        }

        public async Task LoadData()
        {
            try
            {
                // Gọi API lấy dữ liệu
                List<LoaiPhim> dangPhimList = await _dangPhimSV.GetAsync<List<LoaiPhim>>("/api/LoaiPhim");

                if (dangPhimList == null || !dangPhimList.Any())
                {
                    MessageBox.Show("Không có dữ liệu.");
                    return;
                }

                // Xử lý dữ liệu để hiển thị
                var dangPhimDisplayList = dangPhimList.Select(d => new
                {
                    d.MaTheLoai,
                    d.TenTheLoai,
                    SoLuongPhim = d.TheLoaiCuaPhims.Where(t => t.MaTheLoai == d.MaTheLoai).ToList().Count
                }).ToList();

                // Hiển thị dữ liệu lên DataGridView
                dtgvGenre.DataSource = dangPhimDisplayList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }



        private void dtgvGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Logic khi click vào một ô trong DataGridView nếu cần
        }

        private void panel40_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGenreID_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnInsertGenre_Click(object sender, EventArgs e)
        {
            string genreName = txtGenreName.Text;

            if (string.IsNullOrWhiteSpace(genreName))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại phim.");
                return;
            }

            var loaiPhim = new LoaiPhim
            {
                MaTheLoai = 0,
                TenTheLoai = genreName,

            };

            try
            {
                string endpoint = "/api/LoaiPhim"; // Đảm bảo đường dẫn API đúng
                var response = await _dangPhimSV.PostAsync<Models.ApiRespone>(endpoint, loaiPhim);

                MessageBox.Show(response.Message);  // Hiển thị thông báo từ API
                await LoadData();                   // Tải lại dữ liệu sau khi thêm mới thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            string genreId = txtGenreID.Text;
            string genreName = txtGenreName.Text;

            if (string.IsNullOrWhiteSpace(genreId) || string.IsNullOrWhiteSpace(genreName))
            {
                MessageBox.Show("Vui lòng nhập mã và tên thể loại phim.");
                return;
            }

            var loaiPhim = new LoaiPhim
            {
                MaTheLoai = int.Parse(genreId),
                TenTheLoai = genreName,
            };

            try
            {
                string endpoint = $"/api/LoaiPhim/{int.Parse(genreId)}"; // Đảm bảo rằng endpoint là đúng
                var response = await _dangPhimSV.PutAsync<Models.ApiRespone>(endpoint, loaiPhim);

                MessageBox.Show(response.Message);  // Hiển thị thông báo từ API
                await LoadData();  // Tải lại dữ liệu sau khi cập nhật thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void dtgvGenre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var tenTheLoai = dtgvGenre.Rows[e.RowIndex].Cells["GenreName"].Value?.ToString();
            var soLuongPhim = dtgvGenre.Rows[e.RowIndex].Cells["Number"].Value?.ToString();
            if (int.TryParse(dtgvGenre.Rows[e.RowIndex].Cells["TitleId"].Value?.ToString(), out int maTheLoai))
            {
                txtGenreID.Text = maTheLoai.ToString();
                txtGenreName.Text = tenTheLoai;
                await LoadPhim(maTheLoai);
            }

        }
        public async Task LoadPhim(int maTheLoai)
        {

            dtgvPhim.Columns.Clear();

            // Thêm cột để hiển thị tên phim
            dtgvPhim.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TitleId",
                HeaderText = "Mã phim",
                DataPropertyName = "MaPhim",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dtgvPhim.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Tên phim",
                DataPropertyName = "TenPhim",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dtgvPhim.AutoGenerateColumns = false; // Ngăn việc tự động tạo cột
            dtgvPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng
            dtgvPhim.MultiSelect = false; // Không cho phép chọn nhiều dòng

            try
            {
                // Gọi API lấy danh sách phim
                var listPhim = await _dangPhimSV.GetAsync<List<Phim>>("/api/Phim");

                // Kiểm tra dữ liệu phim
                if (listPhim == null || !listPhim.Any())
                {
                    MessageBox.Show("Không có dữ liệu phim.");
                    return;
                }
                dtgvPhim.DataSource = null;

                // Lọc phim theo thể loại
                var ListPhimTheoTheLoai = listPhim
                .Where(p => p.TheLoaiCuaPhims != null && p.TheLoaiCuaPhims.Any(t => t.MaTheLoai == maTheLoai))
                .ToList();


                // Nếu không có phim thuộc thể loại này
                if (!ListPhimTheoTheLoai.Any())
                {
                    dtgvPhim.Rows.Clear();
                    return;
                }

                // Hiển thị danh sách phim lên DataGridView
                dtgvPhim.DataSource = ListPhimTheoTheLoai; // Gán danh sách phim vào DataSource

            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                Debug.WriteLine("Lỗi: " + ex.Message);
            }
        }

        private async void chiTiếtPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng nào được chọn trong DataGridView
            if (dtgvPhim.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                var selectedRow = dtgvPhim.SelectedRows[0];

                var maPhim = selectedRow.Cells["TitleId"].Value?.ToString();

                // Kiểm tra nếu có giá trị ID phim
                if (!string.IsNullOrEmpty(maPhim))
                {
                    int maPhim_int = int.Parse(maPhim);

                    // Tiến hành xử lý khác, ví dụ mở form chi tiết phim
                    var themSua = dataUC.pnData.Controls.OfType<ChucNang_Phim.Them_Sua>().FirstOrDefault();
                    if (themSua != null)
                    {
                        dataUC.pnData.Controls.Remove(themSua);
                        themSua.Dispose();
                    }

                    // Ẩn tất cả các control khác
                    foreach (Control control in dataUC.pnData.Controls)
                    {
                        control.Visible = false;
                    }


                    var phim = await _dangPhimSV.GetAsync<Phim>($"/api/Phim/{maPhim_int}");
                    // Khởi tạo control Them_Sua cho "ChiTiet"
                    themSua = new ChucNang_Phim.Them_Sua("ChiTiet", phim, dataUC);
                    themSua.Dock = DockStyle.Fill;
                    dataUC.pnData.Controls.Add(themSua);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ID phim.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phim để xem chi tiết.");
            }
        }

        private async void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dtgvGenre.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                var selectedRow = dtgvGenre.SelectedRows[0];

                var maLoai = selectedRow.Cells["TitleId"].Value?.ToString();

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa nếu người dùng chọn Yes
                    var response = await _dangPhimSV.DeleteAsync($"/api/LoaiPhim/{maLoai}");

                    if (response)
                    {
                        MessageBox.Show("Xóa thành công");
                        await LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thể loại này! Vui lòng liên hệ với bộ phận IT");
                    }
                }
            
            }
            else
            {
                MessageBox.Show("Hãy chọn một thể loại để xóa");
                return;
            }
        }
    }
}