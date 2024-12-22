using FilmsAPI.Models;
using FilmsManage.GUI.UserControls;
using FilmsManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsManage.GUI.Forms
{
    public partial class Account : UserControl
    {
        private readonly DangPhimSV _dangphimSV;
        public Account()
        {
            InitializeComponent();
            _dangphimSV = new DangPhimSV("https://localhost:7085");
            LoadData();
            dtgvAccount.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AccountId",
                HeaderText = "Mã tài khoản",
                DataPropertyName = "MaTaiKhoan" // Tên trường chính xác trong dữ liệu
            });
            dtgvAccount.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerId",
                HeaderText = "Mã Khách hàng",
                DataPropertyName = "MaKh" // Tên trường chính xác trong dữ liệu
            });
            dtgvAccount.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AccountName",
                HeaderText = "Tên Khách hàng",
                DataPropertyName = "TenKH" // Tên trường chính xác trong dữ liệu
            });
            dtgvAccount.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UserName",
                HeaderText = "Tên đăng nhập",
                DataPropertyName = "TenDangNhap" // Tên trường chính xác trong dữ liệu
            });
            dtgvAccount.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Password",
                HeaderText = "Mật khẩu",//Tên cột
                DataPropertyName = "MatKhau" // Tên trường chính xác trong dữ liệu
            });
            dtgvAccount.CellClick += DtgvFormat_CellClick;
            cbbAccountID.SelectedIndexChanged += cbbAccountID_SelectedIndexChanged;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nudAccountType_ValueChanged(object sender, EventArgs e)
        {

        }
        public async Task LoadData()
        {
            try
            {
                //Gọi api để lấy danh sách tài khoản
                var accounts = await _dangphimSV.GetAsync<List<TaiKhoan>>("api/TaiKhoan");
                var accountDisplayList = accounts.Select(x => new
                {
                    x.MaTaiKhoan,
                    x.MaKh,
                    TenKH = x.MaKhNavigation?.TenKh,
                    x.TenDangNhap,
                    x.MatKhau
                }).ToList();
                dtgvAccount.DataSource = accountDisplayList;
                dtgvAccount.Refresh();
                //Gọi api để lấy danh sách khách hàng
                var customers = await _dangphimSV.GetAsync<List<KhachHang>>("api/KhachHang");
                cbbAccountID.DataSource = customers;
                cbbAccountID.DisplayMember = "MaKh";
                cbbAccountID.ValueMember = "MaKh";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DtgvFormat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var row = dtgvAccount.Rows[e.RowIndex];
            txtMaTK.Text = row.Cells["AccountId"].Value.ToString();
            txtAccountName.Text = row.Cells["AccountName"].Value.ToString();
            cbbAccountID.Text = row.Cells["CustomerId"].Value.ToString();
            txtUserName.Text = row.Cells["UserName"].Value.ToString();
            txtPassWord.Text = row.Cells["Password"].Value.ToString();
        }



        private async void btnSearchAccount_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchAccount.Text;
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi API để lấy danh sách tài khoản
                var accountsList = await _dangphimSV.GetAsync<List<TaiKhoan>>("api/TaiKhoan");
                if (accountsList == null || !accountsList.Any())
                {
                    MessageBox.Show("Không tìm thấy tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tìm kiếm theo tên
                var searchResult = accountsList
                    .Where(d => d.MaKhNavigation != null &&
                                !string.IsNullOrEmpty(d.MaKhNavigation.TenKh) &&
                                d.MaKhNavigation.TenKh.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (searchResult.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hiển thị danh sách kết quả tìm kiếm
                var accountDisplayList = searchResult.Select(x => new
                {
                    x.MaTaiKhoan,
                    x.MaKh,
                    TenKH = x.MaKhNavigation?.TenKh,
                    x.TenDangNhap,
                    x.MatKhau
                }).ToList();

                dtgvAccount.DataSource = accountDisplayList;
                dtgvAccount.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnInsertAccount_Click(object sender, EventArgs e)
        {
            string maKh = cbbAccountID.Text;
            string tenDangNhap = txtUserName.Text;
            string matKhau = txtPassWord.Text;
            if (string.IsNullOrWhiteSpace(maKh) || string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tenDangNhap.Length < 6)
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(tenDangNhap, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập hợp lệ (không có ký tự đặc biệt).");
                return;
            }

            if (matKhau.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                //Gọi api để kiểm tra danh sách tài khoản
                List<TaiKhoan> staffAccount = await _dangphimSV.GetAsync<List<TaiKhoan>>("api/TaiKhoan");
                if (staffAccount != null && staffAccount.Any(x => x.MaKh.ToString() == maKh))
                {
                    MessageBox.Show("Khách hàng đã có tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (staffAccount.Any(d => d.TenDangNhap == tenDangNhap))
                {
                    MessageBox.Show("Tên Đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (staffAccount.Any(d => d.MatKhau == matKhau))
                {
                    MessageBox.Show("Mật Khẩu đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var account = new TaiKhoan
                {
                    MaKh = int.Parse(maKh),
                    TenDangNhap = tenDangNhap,
                    MatKhau = matKhau
                };

                string endpoint = "api/TaiKhoan";
                var response = await _dangphimSV.PostAsync<string>(endpoint, account);
                if (response != null)
                {
                    MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string accountId = txtMaTK.Text.Trim();
            if (string.IsNullOrWhiteSpace(accountId))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string endpoint = $"api/TaiKhoan/{accountId}";
                    var response = _dangphimSV.DeleteAsync(endpoint);
                    if (response != null)
                    {
                        MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string newAccountID = txtMaTK.Text.Trim();
            string newCustomerID = cbbAccountID.Text.Trim(); // Mã Khách Hàng mới
            string newUserName = txtUserName.Text.Trim();
            string newPassword = txtPassWord.Text.Trim();

            if (string.IsNullOrWhiteSpace(newAccountID) || string.IsNullOrWhiteSpace(newCustomerID) ||
                string.IsNullOrWhiteSpace(newUserName) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(newUserName, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập hợp lệ (không có ký tự đặc biệt).");
                return;
            }

            if (!int.TryParse(newAccountID, out int mataikhoan))
            {
                MessageBox.Show("Mã tài khoản không hợp lệ. Vui lòng nhập một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy thông tin tài khoản hiện tại từ API
                var endpointGet = $"api/TaiKhoan/{mataikhoan}";
                TaiKhoan currentAccount = await _dangphimSV.GetAsync<TaiKhoan>(endpointGet);

                if (currentAccount == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra nếu Mã Khách Hàng bị thay đổi
                if (currentAccount.MaKh.ToString() != newCustomerID)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn không thể thay đổi mã khách hàng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        return; // Nếu người dùng chọn "Yes", thoát khỏi hàm và không tiếp tục cập nhật
                    }
                }

                // Kiểm tra nếu không có thay đổi nào
                bool isChanged = !(currentAccount.TenDangNhap.Equals(newUserName, StringComparison.OrdinalIgnoreCase) &&
                                   currentAccount.MatKhau.Equals(newPassword, StringComparison.OrdinalIgnoreCase) &&
                                   currentAccount.MaKh.ToString() == newCustomerID);

                if (!isChanged)
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng cập nhật
                var updatedAccount = new TaiKhoan
                {
                    MaTaiKhoan = mataikhoan,
                    MaKh = currentAccount.MaKh,
                    TenDangNhap = newUserName,
                    MatKhau = newPassword,
                };

                // Gửi yêu cầu cập nhật đến API
                var endpointUpdate = $"api/TaiKhoan/{mataikhoan}";
                var response = await _dangphimSV.PutAsync<string>(endpointUpdate, updatedAccount);

                if (response != null)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công");
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbbAccountID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu SelectedItem không null và là KhachHang
            if (cbbAccountID.SelectedItem is KhachHang selectedCustomer)
            {
                txtAccountName.Text = selectedCustomer.TenKh; // Gán tên khách hàng vào ô text
            }
            else
            {
                txtAccountName.Clear(); // Xóa ô text nếu không chọn khách hàng
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaTK.Clear();

            // Đặt lại ComboBox nếu không null và có mục
            if (cbbAccountID != null && cbbAccountID.Items.Count > 0)
            {
                cbbAccountID.SelectedIndex = -1;
            }
            else
            {
                cbbAccountID.Text = string.Empty; // Đặt trạng thái trống
            }

            txtUserName.Clear();
            txtPassWord.Clear();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                // Chuyển dữ liệu trong DataGridView sang DataTable
                DataTable dataTable = new DataTable();

                // Thêm các cột vào DataTable từ DataGridView
                foreach (DataGridViewColumn column in dtgvAccount.Columns)
                {
                    dataTable.Columns.Add(column.HeaderText);
                }

                // Thêm các dòng dữ liệu vào DataTable
                foreach (DataGridViewRow row in dtgvAccount.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < dtgvAccount.Columns.Count; i++)
                        {
                            dataRow[i] = row.Cells[i].Value;
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }

                // Sử dụng dịch vụ ExportSV để xuất dữ liệu ra file Excel
                string filePath = "C:\\path_to_your_file\\AccountData.xlsx"; // Đường dẫn lưu file Excel
                ExportSV exportSV = new ExportSV();
                bool isExported = exportSV.ExportToExcel(dataTable, filePath);

                if (isExported)
                {
                    MessageBox.Show("Dữ liệu đã được xuất ra Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xuất dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
