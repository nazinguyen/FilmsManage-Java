using FilmsAPI.Models;
using FilmsManage.Services;
using FilmsManage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsManage.GUI.UserControls.Data
{
    public partial class DinhDangPhimUC : UserControl
    {
        private readonly DangPhimSV _dangPhimSV;
        public DinhDangPhimUC()
        {
            InitializeComponent();
            _dangPhimSV = new DangPhimSV("https://localhost:7085");
            LoadData();
            dtgvFormat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TitleId",
                HeaderText = "Mã định dạng",
                DataPropertyName = "MaDangPhim" // Tên trường chính xác trong dữ liệu
            });

            dtgvFormat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TitleName",
                HeaderText = "Tên dạng phim",
                DataPropertyName = "TenDangPhim" // Tên trường chính xác trong dữ liệu
            });

            dtgvFormat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaMH",
                HeaderText = "Mã màn hình",
                DataPropertyName = "MaManHinh" // Tên trường chính xác trong dữ liệu
            });

            dtgvFormat.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenMH",
                HeaderText = "Tên màn hình",
                DataPropertyName = "TenManHinh" // Tên trường chính xác trong dữ liệu
            });
            // Thêm sự kiện CellClick
            dtgvFormat.CellClick += DtgvFormat_CellClick;
            cbMaMH.SelectedIndexChanged += cbMaMH_SelectedIndexChanged;
            txtFormatID.Enabled = false;
        }

        public async Task LoadData()
        {
            try
            {
                // Gọi API để lấy danh sách DangPhim
                List<DangPhim> dangPhimList = await _dangPhimSV.GetAsync<List<DangPhim>>("DangPhim");

                var dangPhimListDisplay = dangPhimList.Select(d => new
                {
                    d.MaDangPhim,
                    d.TenDangPhim,
                    d.MaManHinh,
                    TenManHinh = d.MaManHinhNavigation?.TenManHinh,
                }).ToList();

                // Binding DataGridView
                dtgvFormat.DataSource = dangPhimListDisplay;
                dtgvFormat.Refresh();

                // Gọi API để lấy danh sách Màn Hình (điều chỉnh theo API của bạn)
                List<ManHinh> manHinhList = await _dangPhimSV.GetAsync<List<ManHinh>>("/api/ManHinh");

                // Bind dữ liệu vào ComboBox
                cbMaMH.DataSource = manHinhList;
                cbMaMH.DisplayMember = "TenManHinh"; // Hiển thị tên màn hình
                cbMaMH.ValueMember = "MaManHinh";   // Dùng mã màn hình làm giá trị
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void cbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// Lấy giá trị MaManHinh được chọn
            //var selectedMaManHinh = cbMaMH.SelectedValue?.ToString();

            //// Hiển thị TenManHinh tương ứng
            //var selectedManHinh = (ManHinh)cbMaMH.SelectedItem; // Lấy đối tượng ManHinh từ ComboBox
            //if (selectedManHinh != null)
            //{
            //    txtTenMh.Text = selectedManHinh.TenManHinh; // Hiển thị tên màn hình trong TextBox
            //}
        }


        private void DtgvFormat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra hàng hợp lệ
            {
                DataGridViewRow selectedRow = dtgvFormat.Rows[e.RowIndex];

                // Gán giá trị từ hàng được chọn vào các ô nhập liệu
                txtFormatID.Text = selectedRow.Cells["TitleId"].Value?.ToString(); // Mã định dạng
                txtTenDangPhim.Text = selectedRow.Cells["TitleName"].Value?.ToString(); // Mã định dạng
                cbMaMH.Text = selectedRow.Cells["TenMH"].Value?.ToString();
            }
        }

        private async void btnInsertFormat_Click_1(object sender, EventArgs e)
        {
           
        }

        private async void btnUpdateFormat_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
           
        }

        private void dtgvFormat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnInsertGenre_Click(object sender, EventArgs e)
        {
            string genreName = txtTenDangPhim.Text;
            var maManHinh = Convert.ToInt32(cbMaMH.SelectedValue);

            if (string.IsNullOrWhiteSpace(genreName))
            {
                MessageBox.Show("Vui lòng nhập tên dạng phim.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(genreName, @"^[\p{L}\p{N}\s]+$"))
            {
                MessageBox.Show("Vui lòng nhập tên dạng phim hợp lệ (không có ký tự đặc biệt).");
                return;
            }

            var dangPhim = new DangPhim
            {
                TenDangPhim = genreName,
                MaManHinh = maManHinh
            };

            try
            {
                string endpoint = "/DangPhim";
                var response = await _dangPhimSV.PostAsync<Models.ApiRespone>(endpoint, dangPhim);

                if (response != null)
                {
                    if (!string.IsNullOrWhiteSpace(response.Message))
                    {
                        MessageBox.Show(response.Message);
                        await LoadData(); // Tải lại dữ liệu sau khi thêm thành công
                    }
                    else
                    {
                        MessageBox.Show("Phản hồi không chứa thông báo.");
                    }
                }
                else
                {
                    MessageBox.Show("Phản hồi null từ API.");
                }
            }
            catch (Exception ex)
            {
                // Log lỗi chi tiết
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}\n{ex.StackTrace}");
            }

        }

        private async void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            string tenDP = txtTenDangPhim.Text.Trim();
            var maManHinh = Convert.ToInt32(cbMaMH.SelectedValue);
            int.TryParse(txtFormatID.Text, out int maDangPhim);

            if (string.IsNullOrWhiteSpace(tenDP))
            {
                MessageBox.Show("Vui lòng nhập tên dạng phim.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(tenDP, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Vui lòng nhập tên dạng phim hợp lệ (không có ký tự đặc biệt).");
                return;
            }

            var dangPhim = new DangPhim
            {
                MaDangPhim = maDangPhim,
                TenDangPhim = tenDP,
                MaManHinh = maManHinh
            };

            try
            {
                string endpoint = "/DangPhim"; // Đảm bảo rằng endpoint là đúng
                var response = await _dangPhimSV.PutAsync<Models.ApiRespone>(endpoint, dangPhim);

                MessageBox.Show(response.Message);
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFormatID.Text, out var maDangPhim) || maDangPhim == 0)
            {
                MessageBox.Show("Vui lòng nhập ID hợp lệ và chọn 1 dạng phim để xóa!");
                return;
            }

            var confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dạng phim này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.No)
                return;

            try
            {
                var result = await _dangPhimSV.DeleteByIdAsync<string>($"/DangPhim/DeleteById/{maDangPhim}");
                MessageBox.Show(result);
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo workbook mới
                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    // Tạo một worksheet
                    var worksheet = workbook.Worksheets.Add("DinhDangPhim");

                    // Ghi tiêu đề cột từ DataGridView vào file Excel
                    for (int col = 0; col < dtgvFormat.Columns.Count; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = dtgvFormat.Columns[col].HeaderText;
                    }

                    // Ghi dữ liệu từ DataGridView vào file Excel
                    for (int row = 0; row < dtgvFormat.Rows.Count; row++)
                    {
                        for (int col = 0; col < dtgvFormat.Columns.Count; col++)
                        {
                            worksheet.Cell(row + 2, col + 1).Value = dtgvFormat.Rows[row].Cells[col].Value?.ToString();
                        }
                    }

                    // Lưu file Excel
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Save an Excel File";
                        saveFileDialog.FileName = "DinhDangPhim.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}