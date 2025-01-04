using DocumentFormat.OpenXml.Bibliography;
using FilmsAPI.Models;
using FilmsManage.Helper;
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

namespace FilmsManage.GUI.UserControls
{
    public partial class Staff : UserControl
    {
        private readonly DangPhimSV _staff;
        public Staff()
        {
            InitializeComponent();
            _staff = new DangPhimSV("https://localhost:7085");
            LoadData();
            dtgvStaff.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StaffId",
                HeaderText = "Mã nhân viên",
                DataPropertyName = "MaNv" // Tên trường chính xác trong dữ liệu
            });
            dtgvStaff.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StaffName",
                HeaderText = "Tên nhân viên",
                DataPropertyName = "TenNv" // Tên trường chính xác trong dữ liệu
            });
            dtgvStaff.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StaffPhone",
                HeaderText = "Số điện thoại",
                DataPropertyName = "Sdt" // Tên trường chính xác trong dữ liệu
            });
            dtgvStaff.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StaffEmail",
                HeaderText = "Email", // Tên cột
                DataPropertyName = "Email" // Tên trường chính xác trong dữ liệu
            });
            dtgvStaff.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StaffRole",
                HeaderText = "Mã Quyền", // Tên cột
                DataPropertyName = "MaQuyen" // Tên trường chính xác trong dữ liệu
            });
            dtgvStaff.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StaffRoleName",
                HeaderText = "Tên Quyền", // Tên cột
                DataPropertyName = "TenQuyen" // Tên trường chính xác trong dữ liệu
            });
            // Thêm sự kiện CellClick
            dtgvStaff.CellClick += DtgvFormat_CellClick;
        }

        public async Task LoadData()
        {
            try
            {
                // Gọi API để lấy danh sách nhân viên
                List<NhanVien> staffList = await _staff.GetAsync<List<NhanVien>>("api/NhanVien");
                var staffDisplayList = staffList.Select(d => new
                {
                    d.MaNv,
                    d.TenNv,
                    d.Sdt,
                    d.Email,
                    MaQuyen = d.MaQuyenNavigation.MaQuyen,
                    TenQuyen = d.MaQuyenNavigation?.TenQuyen
                })
                .Where(s => s.MaQuyen == 2) // Chỉ lấy nhân viên có mã quyền là 2
                .ToList();
                dtgvStaff.DataSource = staffDisplayList;
                dtgvStaff.Refresh();

                // Gọi API để lấy danh sách quyền
                List<Quyen> roleList = await _staff.GetAsync<List<Quyen>>("api/Quyen");
                // Bind dữ liệu vào combobox (nếu cần)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DtgvFormat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // Kiểm tra nếu không phải hàng dữ liệu
            {
                return;
            }
            // Lấy hàng hiện tại được chọn
            DataGridViewRow selectedRow = dtgvStaff.Rows[e.RowIndex];
            // Gán giá trị từ hàng được chọn vào các ô nhập liệu
            txtStaffId.Text = selectedRow.Cells["StaffId"].Value?.ToString();
            txtStaffName.Text = selectedRow.Cells["StaffName"].Value?.ToString();
            txtStaffPhone.Text = selectedRow.Cells["StaffPhone"].Value?.ToString();
            txtStaffEmail.Text = selectedRow.Cells["StaffEmail"].Value?.ToString();
        }

        private async void btnSearchStaff_Click_1(object sender, EventArgs e)
        {
            string searchValue = txtSearchStaff.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi API để lấy danh sách nhân viên
                var staffList = await _staff.GetAsync<List<NhanVien>>("api/NhanVien");
                if (staffList == null || !staffList.Any())
                {
                    MessageBox.Show("Không có dữ liệu nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Tìm kiếm theo tên
                var searchResult = staffList
                    .Where(d => !string.IsNullOrEmpty(d.TenNv) && d.TenNv.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    .Where(s => s.MaQuyen == 2) // Chỉ lấy nhân viên có mã quyền là 2
                    .ToList();
                if (searchResult.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Chuẩn bị dữ liệu để hiển thị
                var staffDisplayList = searchResult.Select(d => new
                {
                    d.MaNv,
                    d.TenNv,
                    d.Sdt,
                    d.Email,
                    d.MaQuyen,
                    TenQuyen = d.MaQuyenNavigation?.TenQuyen
                }).ToList();
                // Cập nhật DataGridView
                dtgvStaff.DataSource = staffDisplayList;
                dtgvStaff.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddStaff_Click(object sender, EventArgs e)
        {
            string newStaffName = txtStaffName.Text.Trim();
            string newStaffPhone = txtStaffPhone.Text.Trim();
            string newStaffEmail = txtStaffEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(newStaffName) ||
                string.IsNullOrWhiteSpace(newStaffPhone) ||
                string.IsNullOrWhiteSpace(newStaffEmail))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng số điện thoại
            if (!System.Text.RegularExpressions.Regex.IsMatch(newStaffPhone, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại có 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng email
            if (!System.Text.RegularExpressions.Regex.IsMatch(newStaffEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi API để kiểm tra danh sách tên nhân viên
                List<NhanVien> staffList = await _staff.GetAsync<List<NhanVien>>("api/NhanVien");
                if (staffList.Any(c => c.Sdt == newStaffPhone))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại, vui lòng nhập số khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (staffList.Any(c => c.Email == newStaffEmail))
                {
                    MessageBox.Show("Email đã tồn tại, vui lòng nhập email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string key = GenerateRamdomKey.GenerateRamdomKeyFunc();
                NhanVien newStaff = new NhanVien
                {
                    TenNv = newStaffName,
                    Sdt = newStaffPhone,
                    Email = newStaffEmail,
                    MaQuyen = 2, // Mặc định mã quyền là 2 (nhân viên)
                    RandomKey = key,
                    TenAlias = Helper.GenerateRamdomKey.GetLastWord(newStaffName),
                };
                string endpoint = "api/NhanVien";
                var response = await _staff.PostAsync<string>(endpoint, newStaff);
                if (response != null)
                {
                    MessageBox.Show("Thêm nhân viên thành công" + " Mật khẩu: " + response);
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể thêm nhân viên, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            string newStaffName = txtStaffName.Text.Trim();
            string newStaffPhone = txtStaffPhone.Text.Trim();
            string newStaffEmail = txtStaffEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(newStaffName) ||
                string.IsNullOrWhiteSpace(newStaffPhone) ||
                string.IsNullOrWhiteSpace(newStaffEmail))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(newStaffPhone, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại có 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(newStaffEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStaffId.Text, out int manhanvien))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ. Vui lòng nhập một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string endpointGet = $"api/NhanVien/{manhanvien}";
                NhanVien currentStaff = await _staff.GetAsync<NhanVien>(endpointGet);

                if (currentStaff == null)
                {
                    MessageBox.Show("Nhân viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isChanged = !(currentStaff.TenNv.Equals(newStaffName, StringComparison.OrdinalIgnoreCase) &&
                                   currentStaff.Sdt.Equals(newStaffPhone, StringComparison.OrdinalIgnoreCase) &&
                                   currentStaff.Email.Equals(newStaffEmail, StringComparison.OrdinalIgnoreCase));

                if (!isChanged)
                {
                    MessageBox.Show("Không có thông tin nào được thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var staff = new NhanVien
                {
                    MaNv = manhanvien,
                    TenNv = newStaffName,
                    Sdt = newStaffPhone,
                    Email = newStaffEmail,
                    MaQuyen = 2 // Mặc định mã quyền là 2 (nhân viên)
                };

                string endpointUpdate = $"api/NhanVien/{manhanvien}";
                var response = await _staff.PutAsync<string>(endpointUpdate, staff);

                if (response != null)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật nhân viên, vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text.Trim();
            if (string.IsNullOrWhiteSpace(staffId))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy thông tin nhân viên hiện tại từ API
                string endpointGet = $"api/NhanVien/{staffId}";
                NhanVien currentStaff = await _staff.GetAsync<NhanVien>(endpointGet);

                if (currentStaff == null)
                {
                    MessageBox.Show("Nhân viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string endpoint = $"api/NhanVien/{staffId}";
                    var response = await _staff.DeleteAsync(endpoint);
                    if (response)
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                        await LoadData(); // Tải lại dữ liệu
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhân viên, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng ExcelExporter
            var exporter = new ExcelExporter();
            // Gọi hàm ExportDataGridViewToExcel và truyền vào DataGridView
            exporter.ExportDataGridViewToExcel(dtgvStaff);
        }

        private async void txtSearchStaff_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchStaff.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi API để lấy danh sách nhân viên
                var staffList = await _staff.GetAsync<List<NhanVien>>("api/NhanVien");

                // Tìm kiếm theo tên
                var searchResult = staffList
                    .Where(d => !string.IsNullOrEmpty(d.TenNv) && d.TenNv.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    .Where(s => s.MaQuyen == 2) // Chỉ lấy nhân viên có mã quyền là 2
                    .ToList();

                if (searchResult.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Chuẩn bị dữ liệu để hiển thị
                var staffDisplayList = searchResult.Select(d => new
                {
                    d.MaNv,
                    d.TenNv,
                    d.Sdt,
                    d.Email,
                    d.MaQuyen,
                    TenQuyen = d.MaQuyenNavigation?.TenQuyen
                }).ToList();

                // Cập nhật DataGridView
                dtgvStaff.DataSource = staffDisplayList;
                dtgvStaff.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCapMK_Click(object sender, EventArgs e)
        {
            int staffId = int.Parse(txtStaffId.Text);

            if (staffId == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cấp lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var result = await _staff.GetAsync<string>($"api/NhanVien/DoiMatKhau/{staffId}");
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}