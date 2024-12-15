using FilmsAPI.Models;
using FilmsManage.GUI.DataUserControl;
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

namespace FilmsManage.GUI.UserControls.Data.ChucNang_PhongChieu
{
    public partial class ThemSua : UserControl
    {
        private DataUC dataUc;
        private readonly DangPhimSV _PhongChieuSV;
        private PhongChieu phongChieu;

        public ThemSua(string chucNang, PhongChieu phongChieu, DataUC dataUC)
        {
            _PhongChieuSV = new DangPhimSV("https://localhost:7085");
            this.phongChieu = phongChieu;
            this.dataUc = dataUC;
            InitializeComponent();
            LoadComboBoxData();
            CheckChucNang(chucNang);
        }

        public async Task CheckChucNang(string chucNang)
        {
            if (chucNang == "Them")
            {
                btnThem.Visible = true;
                btnSua.Visible = false;
            }
        }

        public async Task LoadComboBoxData()
        {
            try
            {
                // Lấy danh sách phòng chiếu từ API
                var manHinh = await _PhongChieuSV.GetAsync<List<ManHinh>>("/api/ManHinh");
                cboCinemaScreenType.DataSource = manHinh;
                cboCinemaScreenType.DisplayMember = "TenManHinh";
                cboCinemaScreenType.ValueMember = "MaManHinh";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải dữ liệu ComboBox: {ex.Message}");
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string tenPhong = txtCinemaName.Text;
            string manHinh = cboCinemaScreenType.Text;

            if (string.IsNullOrWhiteSpace(tenPhong))
            {
                MessageBox.Show("Vui lòng nhập tên phòng.");
                return;
            }

            if (string.IsNullOrWhiteSpace(manHinh))
            {
                MessageBox.Show("Vui lòng nhập tên màn hình.");
                return;
            }



            if (!int.TryParse(txtCinemaSeats.Text, out int soGhe))
            {
                MessageBox.Show("Số ghế không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            if (!int.TryParse(txtSeatsPerRow.Text, out int gheMoiHang))
            {
                MessageBox.Show("Số ghế mỗi hàng không hợp lệ. Vui lòng nhập một số nguyên.");
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
                var response = await _PhongChieuSV.PostAsync<Models.ApiRespone>(endpoint, phongChieu);

                //them ghe tu phong chieu
                var loaiGheList = await _PhongChieuSV.GetAsync<List<LoaiGhe>>("/api/LoaiGhe");
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
                var getPhong = await _PhongChieuSV.GetAsync<List<PhongChieu>>("/api/PhongChieu");
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
                for (int i = 1; i <= phong.SoHangGhe; i++)
                {
                    char rowChar = (char)('A' + i);
                    for (int j = 1; j <= phong.SoGheMotHang; j++)
                    {
                        Debug.WriteLine("ok");
                        string seatCode = $"{rowChar}{j + 1}";

                        Ghe ghe = new Ghe
                        {
                            TenGhe = seatCode,
                            TrangThai = false,
                            MaPhong = idPhong,
                            MaLoaiGhe = (i >= 4) ? loaiGheVIP : loaiGheThuong // Ghế VIP bắt đầu từ hàng số 4, ghế Thường cho các hàng còn lại
                        };
                        Debug.WriteLine("hang " + i);
                        var addGhe = await _PhongChieuSV.PostAsync<Models.ApiRespone>("/api/Ghe", ghe);
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
                BackPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        public void BackPage()
        {
            var cinema = dataUc.pnData.Controls.OfType<CinemaUC>().FirstOrDefault();
            if (cinema != null)
            {
                dataUc.pnData.Controls.Remove(cinema);
                cinema.Dispose();
            }

            Debug.WriteLine("ok");

            // Ẩn tất cả các control khác
            foreach (Control control in dataUc.pnData.Controls)
            {
                control.Visible = false;
            }

            // Khởi tạo control Them_Sua cho "Sửa"
            cinema = new CinemaUC(dataUc);
            cinema.Dock = DockStyle.Fill;
            dataUc.pnData.Controls.Add(cinema);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BackPage();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
