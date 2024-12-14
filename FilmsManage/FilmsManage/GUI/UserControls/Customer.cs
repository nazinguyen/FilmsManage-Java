using FilmsAPI.Models;
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
    public partial class Customer : UserControl
    {
        private readonly DangPhimSV _customer;

        public Customer()
        {

            InitializeComponent();

            _customer = new DangPhimSV("https://localhost:7085");
            LoadData();

            dtgvCustomer.CellClick += dtgvCustomer_CellClick;

        }

        public async Task LoadData()
        {
            try
            {
                List<KhachHang> customerList = await _customer.GetAsync<List<KhachHang>>("api/KhachHang");
                var customerDisplayList = customerList.Select(d => new
                {
                    d.MaKh,
                    d.TenKh,
                    d.Sdt,
                    d.CCCD,
                    d.NgaySinh,
                    d.DiaChi,
                    d.DiemTichluy,
                }).ToList();



                dtgvCustomer.DataSource = customerDisplayList;
                dtgvCustomer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }


            txtCusID.Text = dtgvCustomer.Rows[e.RowIndex].Cells["maKH"].Value.ToString();
            txtCusName.Text = dtgvCustomer.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
            txtCusPhone.Text = dtgvCustomer.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            txtCusAddress.Text = dtgvCustomer.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            txtCusBirth.Text = dtgvCustomer.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
            txtCusINumber.Text = dtgvCustomer.Rows[e.RowIndex].Cells["CCCD"].Value.ToString();
            CusDate.Value = Convert.ToDateTime(dtgvCustomer.Rows[e.RowIndex].Cells["NgaySinh"].Value);


            // Tạm thời vô hiệu hóa sự kiện ValueChanged
            nudPoint.ValueChanged -= nudPoint_ValueChanged;

            try
            {
                    nudPoint.Value = int.Parse(dtgvCustomer.Rows[e.RowIndex].Cells["DiemTichLuy"].Value.ToString());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bật lại sự kiện ValueChanged
                nudPoint.ValueChanged += nudPoint_ValueChanged;
            }
        }

        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {

            string newCusName = txtCusName.Text.Trim();
            string newCusPhone = txtCusPhone.Text.Trim();
            DateTime newCusBird = CusDate.Value;
            string newCusAdress = txtCusAddress.Text.Trim();
            string newCusNumID = txtCusINumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(newCusName) || string.IsNullOrWhiteSpace(newCusPhone) /*|| string.IsNullOrWhiteSpace(newCusBird)*/ || string.IsNullOrWhiteSpace(newCusNumID))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

                List<KhachHang> CusList = await _customer.GetAsync<List<KhachHang>>("api/KhachHang");


                var newCus = new KhachHang
                {

                    Sdt = newCusPhone,
                    TenKh = newCusName,
                    NgaySinh = newCusBird,
                    DiaChi = newCusAdress,
                    CCCD = newCusNumID,
                    DiemTichluy = 1,
                    Email = null



                };
                string endpoint = "api/KhachHang";
                var response = await _customer.PostAsync<KhachHang>(endpoint, newCus);
                if (response != null)
                {
                    MessageBox.Show("Thêm khách hàng thành công");
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể thêm khách hàng, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            int newCusID = int.Parse(txtCusID.Text);
            string newCusName = txtCusName.Text.Trim();
            string newCusPhone = txtCusPhone.Text.Trim();
            DateTime newCusBird = CusDate.Value;
            string newCusAdress = txtCusAddress.Text.Trim();
            string newCusNumID = txtCusINumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(newCusName) || string.IsNullOrWhiteSpace(newCusNumID) || string.IsNullOrWhiteSpace(newCusAdress) || string.IsNullOrWhiteSpace(newCusPhone))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string endpointGet = $"api/KhachHang/{newCusID}";
                KhachHang currentCus = await _customer.GetAsync<KhachHang>(endpointGet);

                if (currentCus == null)
                {
                    MessageBox.Show("Khach hang không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool isChanged = !(currentCus.Sdt.Equals(newCusPhone, StringComparison.OrdinalIgnoreCase)&&
                                   currentCus.DiaChi.Equals(newCusAdress, StringComparison.OrdinalIgnoreCase)
                                   );


                if (!isChanged)
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật thông tin nếu có thay đổi
                var Customer = new KhachHang
                {
                    MaKh = newCusID,
                    Sdt = newCusPhone,
                    TenKh = newCusName,
                    NgaySinh = newCusBird,
                    DiaChi = newCusAdress,
                    CCCD = newCusNumID,
                    DiemTichluy = int.Parse(nudPoint.Value.ToString()),
                    Email = null
                };

                string endpointUpdate = $"api/KhachHang";
                var response = await _customer.PutAsync<string>(endpointUpdate, Customer);

                if (response != null)
                {
                    MessageBox.Show("Cập nhật khach hàng  thành công");
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật khách hàng, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string cusID = txtCusID.Text.Trim();
            if (string.IsNullOrWhiteSpace(cusID))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string endpoint = $"api/KhachHang/{cusID}";
                    var response = await _customer.DeleteAsync(endpoint);
                    if (response)
                    {
                        MessageBox.Show("Xóa khách hàng thành công");
                        await LoadData(); //Tải lại dữ liệu
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa khách hàng, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void txtSearchCus_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchCus.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi API để lấy danh sách khách hàng
                var cusList = await _customer.GetAsync<List<KhachHang>>("api/KhachHang");

                if (cusList == null || !cusList.Any())
                {
                    MessageBox.Show("Không có dữ liệu khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Tìm kiếm theo tên
                var searchResult = cusList
                    .Where(d => !string.IsNullOrEmpty(d.TenKh) && d.TenKh.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (searchResult.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Chuẩn bị dữ liệu để hiển thị
                var cusDisplayList = searchResult.Select(d => new
                {
                    d.MaKh,
                    d.TenKh,
                    d.Sdt,
                    d.Email,
                    d.CCCD,
                    d.NgaySinh,
                    d.DiaChi,

                }).ToList();

                dtgvCustomer.DataSource = cusDisplayList;
                dtgvCustomer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void nudPoint_ValueChanged(object sender, EventArgs e)
        {
            int newDiemTichLuy = int.Parse(nudPoint.Value.ToString());

            await UpdateDiemTichLuyAsync(int.Parse(txtCusID.Text.ToString()), newDiemTichLuy);
        }

        private async Task UpdateDiemTichLuyAsync(int khachHangId, int newDiemTichLuy)
        {

            string endpointGet = $"api/KhachHang/{khachHangId}";
            KhachHang currentCus = await _customer.GetAsync<KhachHang>(endpointGet);

            if (currentCus != null)
            {
                var newPoint = new KhachHang
                {
                    MaKh = currentCus.MaKh,
                    CCCD = currentCus.CCCD,
                    NgaySinh = currentCus.NgaySinh,
                    DiaChi = currentCus.DiaChi,
                    Sdt = currentCus.Sdt,
                    Email = currentCus.Email,
                    DiemTichluy = newDiemTichLuy,
                    TenKh = currentCus.TenKh,
                };
                string endpointUpdate = "api/KhachHang";
                var response = await _customer.PutAsync<string>(endpointUpdate, newPoint);

                if (response != null)
                {
                    MessageBox.Show("Cập nhật điểm của khach hàng  thành công");
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật khách hàng, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCusAddress.Clear();
            CusDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            txtCusID.Clear();
            txtCusName.Clear();
            txtCusPhone.Clear();
            txtCusINumber.Clear();
            // Tạm thời vô hiệu hóa sự kiện ValueChanged
            nudPoint.ValueChanged -= nudPoint_ValueChanged;

            try

            {     
                nudPoint.Value = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bật lại sự kiện ValueChanged
                nudPoint.ValueChanged += nudPoint_ValueChanged;
            }
        }
    }
    }
