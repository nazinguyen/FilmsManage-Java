using ClosedXML.Excel;
using FilmsAPI.Models;
using FilmsManage.GUI.DataUserControl;
using FilmsManage.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsManage.GUI.UserControls.Data
{
    public partial class CinemaUC : UserControl
    {
        private DataUC dataUC;
        private readonly DangPhimSV _PhongChieu;
        public CinemaUC(DataUC data)
        {
            InitializeComponent();
            _PhongChieu = new DangPhimSV("https://localhost:7085");
            dataUC = data;
            LoadData();
            LoadComboBoxData();
            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaPhong",
                HeaderText = "Mã phòng",
                DataPropertyName = "MaPhongChieu" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenPhong",
                HeaderText = "Tên phòng chiếu",
                DataPropertyName = "TenPhongChieu" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "tenManHinh",
                HeaderText = "Tên màn hình",
                DataPropertyName = "TenManHinh" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "soChoNgoi",
                HeaderText = "Số chỗ ngồi",
                DataPropertyName = "SoGhe" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "soHangGhe",
                HeaderText = "Số hàng ghế",
                DataPropertyName = "SoHangGhe" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "soGheMoiHang",
                HeaderText = "Số ghế mỗi hàng",
                DataPropertyName = "SoGheMotHang" // Tên trường chính xác trong dữ liệu
            });
            // Thêm sự kiện CellClick
            dtgvCinema.CellClick += DtgvFormat_CellClick;
            txtCinemaID.Enabled = false;
            txtNumberOfRows.Visible = false;
        }

        public async Task LoadData()
        {
            try
            {
                // Gọi API để lấy danh sách DangPhim
                List<PhongChieu> phongChieuList = await _PhongChieu.GetAsync<List<PhongChieu>>("/api/PhongChieu");

                var phongChieuDisplayList = phongChieuList.Select(d => new
                {
                    d.MaPhongChieu,
                    d.TenPhongChieu,
                    d.SoGhe,
                    TenManHinh = d.MaManHinhNavigation?.TenManHinh,
                    d.SoHangGhe,
                    d.SoGheMotHang,
                }).ToList();

                dtgvCinema.DataSource = phongChieuDisplayList;
                dtgvCinema.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void DtgvFormat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra hàng hợp lệ
            {
                DataGridViewRow selectedRow = dtgvCinema.Rows[e.RowIndex];

                // Gán giá trị từ hàng được chọn vào các ô nhập liệu
                txtCinemaID.Text = selectedRow.Cells["MaPhong"].Value?.ToString();
                txtCinemaName.Text = selectedRow.Cells["TenPhong"].Value?.ToString();
                cboCinemaScreenType.Text = selectedRow.Cells["tenManHinh"].Value?.ToString();
                txtCinemaSeats.Text = selectedRow.Cells["soChoNgoi"].Value?.ToString();
                txtNumberOfRows.Text = selectedRow.Cells["soHangGhe"].Value?.ToString();
                txtSeatsPerRow.Text = selectedRow.Cells["soGheMoiHang"].Value?.ToString();
            }
        }

        public async Task LoadComboBoxData()
        {
            try
            {
                // Lấy danh sách phòng chiếu từ API
                var manHinh = await _PhongChieu.GetAsync<List<ManHinh>>("/api/ManHinh");



                cboCinemaScreenType.DataSource = manHinh;
                cboCinemaScreenType.DisplayMember = "TenManHinh";
                cboCinemaScreenType.ValueMember = "MaManHinh";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải dữ liệu ComboBox: {ex.Message}");
            }
        }
        private void dtgvCinema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnInsertCinema_Click_1(object sender, EventArgs e)
        {
            string tenPhong = txtCinemaName.Text;
            string manHinh = cboCinemaScreenType.Text;
            int.TryParse(txtSeatsPerRow.Text, out int gheMoiHang);
            int.TryParse(txtCinemaSeats.Text, out int soGhe);

            if (!ValidateInput(out string errorMessage))
            {
                // Hiển thị thông báo lỗi nếu nhập sai
                MessageBox.Show(errorMessage, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var phongChieu = new PhongChieu
            {
                TenPhongChieu = tenPhong,
                SoGhe = soGhe,
                SoGheMotHang = gheMoiHang,
                MaManHinh = Convert.ToInt32(cboCinemaScreenType.SelectedValue),
            };

            try
            {
                string endpoint = "/api/PhongChieu";
                var response = await _PhongChieu.PostAsync<Models.ApiRespone>(endpoint, phongChieu);

                //them ghe tu phong chieu
                var loaiGheList = await _PhongChieu.GetAsync<List<LoaiGhe>>("/api/LoaiGhe");
                if (loaiGheList == null || !loaiGheList.Any())
                {
                    MessageBox.Show("Dữ liệu loại ghế không có!");
                    return;
                }

                int loaiGheVIP = 0;
                int loaiGheThuong = 0;
                foreach (var item in loaiGheList)
                {
                    if (item.TenLoaiGhe == "VIP")
                    {
                        loaiGheVIP = item.MaLoai;
                        Debug.WriteLine(loaiGheVIP);
                    }
                    else
                    {
                        loaiGheThuong = item.MaLoai;
                        Debug.WriteLine(loaiGheThuong);
                    }
                }

                var listGhe = new List<Ghe>();

                // Tạo ghế
                var getPhong = await _PhongChieu.GetAsync<List<PhongChieu>>("/api/PhongChieu");
                var phong = new PhongChieu();
                int idPhong = 0;
                foreach (var item in getPhong)
                {
                    if (item.TenPhongChieu == tenPhong)
                    {
                        idPhong = item.MaPhongChieu;
                        phong = item;
                        Debug.WriteLine(idPhong);
                        break;
                    }
                }
                for (int i = 0; i < phong.SoHangGhe; i++)
                {
                    char rowChar = (char)('A' + i); // 'A' là mã ASCII của A, cộng thêm i để tạo chữ cái kế tiếp

                    for (int j = 0; j < phong.SoGheMotHang; j++)
                    {
                        Debug.WriteLine("ok");
                        string seatCode = $"{rowChar}{j + 1}";  // ghế 1, 2, 3, ... trong hàng A, B, C,...

                        Ghe ghe = new Ghe
                        {
                            TenGhe = seatCode,
                            TrangThai = false,
                            MaPhong = idPhong,
                            MaLoaiGhe = (i >= 4) ? loaiGheVIP : loaiGheThuong // Ghế VIP bắt đầu từ hàng số 4, ghế Thường cho các hàng còn lại
                        };
                        Debug.WriteLine("hang " + i);
                        var addGhe = await _PhongChieu.PostAsync<Models.ApiRespone>("/api/Ghe", ghe);
                        listGhe.Add(ghe);

                        if (listGhe.Count >= phong.SoGhe)
                        {
                            break;
                        }
                    }

                    if (listGhe.Count >= phong.SoGhe)
                    {
                        break;
                    }
                }

                MessageBox.Show(response.Message);
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnUpdateCinema_Click_1(object sender, EventArgs e)
        {
            string tenPC = txtCinemaName.Text.Trim();
            string tenMH = cboCinemaScreenType.Text.Trim();
            int.TryParse(txtSeatsPerRow.Text, out int soGheMoiHang);
            int.TryParse(txtCinemaSeats.Text, out int soGhe);
            int.TryParse(txtCinemaID.Text, out int maPC);
            if (!ValidateInput(out string errorMessage))
            {
                // Hiển thị thông báo lỗi nếu nhập sai
                MessageBox.Show(errorMessage, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var phongChieu = new PhongChieu
            {
                MaPhongChieu = maPC,
                TenPhongChieu = tenPC,
                MaManHinhNavigation = new ManHinh
                {
                    TenManHinh = tenMH
                },
                SoGhe = soGhe,
                SoGheMotHang = soGheMoiHang
            };

            try
            {
                string endpoint = "api/PhongChieu"; // Đảm bảo rằng endpoint là đúng
                var response = await _PhongChieu.PutAsync<Models.ApiRespone>(endpoint, phongChieu);

                MessageBox.Show(response.Message);
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private bool ValidateInput(out string errorMessage)
        {
            // Lấy giá trị từ các control
            string tenPhong = txtCinemaName.Text.Trim();
            string manHinh = cboCinemaScreenType.Text.Trim();
            string soGheText = txtCinemaSeats.Text.Trim();
            string gheMoiHangText = txtSeatsPerRow.Text.Trim();

            // Kiểm tra tên phòng chiếu (không được bỏ trống, không chứa ký tự đặc biệt)
            if (string.IsNullOrWhiteSpace(tenPhong))
            {
                errorMessage = "Vui lòng nhập tên phòng chiếu.";
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(tenPhong, @"^[a-zA-Z0-9\s]+$"))
            {
                errorMessage = "Vui lòng nhập tên phòng chiếu hợp lệ (không có ký tự đặc biệt).";
                return false;
            }

            // Kiểm tra loại màn hình (phải được chọn)
            if (string.IsNullOrWhiteSpace(manHinh))
            {
                errorMessage = "Vui lòng chọn loại màn hình.";
                return false;
            }

            // Kiểm tra số ghế (phải là số nguyên dương, nằm trong khoảng hợp lệ)
            if (!int.TryParse(soGheText, out int soGhe) || soGhe <= 0)
            {
                errorMessage = "Số ghế phải là số nguyên dương.";
                return false;
            }
            if (soGhe < 10 || soGhe > 500)
            {
                errorMessage = "Số ghế phải nằm trong khoảng từ 10 đến 500.";
                return false;
            }

            // Kiểm tra số ghế mỗi hàng (phải là số nguyên dương và không vượt quá tổng số ghế)
            if (!int.TryParse(gheMoiHangText, out int gheMoiHang) || gheMoiHang <= 0)
            {
                errorMessage = "Số ghế mỗi hàng phải là số nguyên dương.";
                return false;
            }
            if (gheMoiHang > soGhe)
            {
                errorMessage = "Số ghế mỗi hàng không được lớn hơn tổng số ghế.";
                return false;
            }
            if (soGhe % gheMoiHang != 0)
            {
                errorMessage = "Tổng số ghế phải chia hết cho số ghế mỗi hàng.";
                return false;
            }

            // Nếu tất cả đều hợp lệ
            errorMessage = null;
            return true;
        }

        private async void btnExport_Click_1(object sender, EventArgs e)
        {
            if (dtgvCinema.DataSource is not null)
            {
                // Chuyển dữ liệu từ DataGridView sang DataTable
                var dataTable = new DataTable();

                foreach (DataGridViewColumn column in dtgvCinema.Columns)
                {
                    dataTable.Columns.Add(column.HeaderText);
                }

                foreach (DataGridViewRow row in dtgvCinema.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var dataRow = dataTable.NewRow();
                        foreach (DataGridViewColumn column in dtgvCinema.Columns)
                        {
                            dataRow[column.HeaderText] = row.Cells[column.Name].Value ?? DBNull.Value;
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }

                // Chọn nơi lưu file Excel
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Lưu file Excel";
                    saveFileDialog.FileName = "DanhSachPhongChieu.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // Dùng ClosedXML để xuất ra file Excel với định dạng đẹp
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.AddWorksheet("Danh sách phòng chiếu");

                            // Chèn dữ liệu từ DataTable vào Excel
                            worksheet.Cell(1, 1).InsertTable(dataTable);

                            // Định dạng tiêu đề cột (tô đậm, căn giữa, nền màu)
                            var headerRow = worksheet.Range(worksheet.Cell(1, 1), worksheet.Cell(1, dataTable.Columns.Count));
                            headerRow.Style.Font.Bold = true;
                            headerRow.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            headerRow.Style.Fill.BackgroundColor = XLColor.LightGray;

                            // Căn chỉnh số liệu
                            for (int col = 1; col <= dataTable.Columns.Count; col++)
                            {
                                worksheet.Column(col).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            }

                            // Lưu file Excel
                            workbook.SaveAs(filePath);
                            MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}