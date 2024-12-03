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
            dtgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerID",
                HeaderText = "Mã khách hàng",
                DataPropertyName = "MaKh" // Tên trường chính xác trong dữ liệu
            });
            dtgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerName",
                HeaderText = "Họ tên",
                DataPropertyName = "TenKh" // Tên trường chính xác trong dữ liệu
            });
            dtgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerPhone",
                HeaderText = "Số điện thoại",
                DataPropertyName = "Sdt" // Tên trường chính xác trong dữ liệu
            });
            dtgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerEmail",
                HeaderText = "Email",//Tên cột
                DataPropertyName = "Email" // Tên trường chính xác trong dữ liệu
            });
            //txtStaffId.Enabled = false;
            //txtTenQuyen.Enabled = false;
            //Thêm sự kiện CellClick
            dtgvCustomer.CellClick += dtgvCustomer_CellClick;
            //cbbMaQuyen.SelectedIndexChanged += CbbMaQuyen_SelectedIndexChanged;
            btnAddCustomer.Click += btnAddCustomer_Click;

        }

        public async Task LoadData()
        {
            try
            {
                // Gọi API để lấy danh sách Khach hang
                List<KhachHang> customerList = await _customer.GetAsync<List<KhachHang>>("api/KhachHang");
                var customerDisplayList = customerList.Select(d => new
                {
                    d.MaKh,
                    d.TenKh,
                    d.Sdt,
                    d.Email,
                    //MaQuyen = d.MaQuyenNavigation.MaQuyen,
                    //TenQuyen = d.MaQuyenNavigation?.TenQuyen
                }).ToList();
                dtgvCustomer.DataSource = customerDisplayList;
                dtgvCustomer.Refresh();
                //Gọi Api để lấy danh sách quyền
                //List<Quyen> roleList = await _customer.GetAsync<List<Quyen>>("api/Quyen");
                ////Bind dữ liệu vào combobox
                //cbbMaQuyen.DataSource = roleList;
                //cbbMaQuyen.DisplayMember = "MaQuyen";
                //cbbMaQuyen.ValueMember = "MaQuyen";
                ////Bind dữ liệu vào combobox
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
            //Gán giá trị từ hàng được chọn vào các ô nhập liệu
            txtCusID.Text = dtgvCustomer.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
            txtCusName.Text = dtgvCustomer.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
            txtCusPhone.Text = dtgvCustomer.Rows[e.RowIndex].Cells["CustomerPhone"].Value.ToString();
            //txt.Text = dtgvCustomer.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
            //txtStaffPass.Text = dtgvCustomer.Rows[e.RowIndex].Cells["StaffPassword"].Value.ToString();
            //cbbMaQuyen.Text = dtgvCustomer.Rows[e.RowIndex].Cells["StaffRole"].Value.ToString();
            //txtTenQuyen.Text = dtgvCustomer.Rows[e.RowIndex].Cells["StaffRoleName"].Value.ToString();
        }

        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            int newCusID = int.Parse(txtCusID.Text);
            string newCusName = txtCusName.Text.Trim();
            string newCusPhone = txtCusPhone.Text.Trim();
            //string newCusEmail = txtCusEmail.Text.Trim();
            string newCusBird = txtCusBirth.Text.Trim();
            string newCusAdress = txtCusAddress.Text.Trim();
            string newCusNumID = txtCusINumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(newCusName) || string.IsNullOrWhiteSpace(newCusPhone) || string.IsNullOrWhiteSpace(newCusBird) || string.IsNullOrWhiteSpace(newCusNumID))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                //Gọi API để kiểm tra danh sách tên kach hang
                List<KhachHang> CusList = await _customer.GetAsync<List<KhachHang>>("api/KhachHang");

                if (CusList.Any(d => d.MaKh == newCusID))
                {
                    MessageBox.Show("Mã khach hang đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Gọi API để thêm nhân viên
                var newCus = new KhachHang
                {
                    MaKh = newCusID,
                    Sdt = newCusPhone,
                    TenKh = newCusName,
                };
                string endpoint = "api/NhanVien";
                var response = await _customer.PostAsync<string>(endpoint, newCus);
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
    }
    }
