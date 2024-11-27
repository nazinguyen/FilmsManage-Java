using Azure;
using FilmsAPI.Models;
using FilmsManage.GUI.DataUserControl;
using FilmsManage.Models;
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
using Newtonsoft.Json;

namespace FilmsManage.GUI.UserControls.Data.ChucNang_Phim
{
    public partial class Them_Sua : UserControl
    {
        private Phim _dto;
        private DataUC dataUc;
        private readonly DangPhimSV _dangPhimSV;
        private List<TheLoaiCuaPhim> _listLoaiPhim;

        public Them_Sua(string chucNang, Phim dto, DataUC dataUc)
        {
            _dangPhimSV = new DangPhimSV("https://localhost:7085");
            _dto = dto;
            _listLoaiPhim = new List<TheLoaiCuaPhim>();
            this.dataUc = dataUc;
            InitializeComponent();
            CheckChucNang(chucNang);

            LoadDangPhim();
            loadLoaiPhim();

        }

        public async Task CheckChucNang(string chucNang)
        {
            if (chucNang == "Them")
            {
                btnThem.Visible = true;
                btnSua.Visible = false;
                btnBack.Visible = false;
                txtMovieID.Enabled = false;
            }
            else if (chucNang == "Sua")
            {
                btnThem.Visible = false;
                btnSua.Visible = true;
                txtMovieID.Enabled = false;
                btnBack.Visible = false;

                txtMovieID.Text = _dto.MaPhim.ToString();
                txtMovieName.Text = _dto.TenPhim;
                txtMovieDesc.Text = _dto.Mota;
                txtGhiChu.Text = _dto.GhiChu;
                txtNoiDung.Text = _dto.NoiDung;
                txtMovieLength.Text = _dto.ThoiLuong.ToString();
                dtmMovieStart.Value = DateTime.Parse(_dto.NgayKc.ToString()); // Chuyển đổi từ DateOnly sang DateTime
                dtmMovieEnd.Value = DateTime.Parse(_dto.NgayKt.ToString());
                txtDoTuoi.Text = _dto.DoTuoi.ToString();
                txtMovieDirector.Text = _dto.TenDaoDien;
                ccbDangPhim.SelectedValue = _dto.MaDangPhim; // Gán giá trị cho ComboBox
                picFilm.Image = LoadImageFromFileSystem(_dto.AnhBia);

                _listLoaiPhim = await _dangPhimSV.GetAsync<List<TheLoaiCuaPhim>>("/api/LoaiCuaPhim/" + _dto.MaPhim);
                
                    foreach (var loai in _listLoaiPhim)
                    {
                        Debug.WriteLine($"Mã thể loại: {loai.MaTheLoai}");
                    }
              

                await loadLoaiPhim_Update(_listLoaiPhim ?? new List<TheLoaiCuaPhim>());
            }
            else
            {
                btnThem.Visible = false;
                btnSua.Visible = false;
                btnHuy.Visible = false;
                txtMovieID.Enabled = false;

                txtMovieID.Text = _dto.MaPhim.ToString();
                txtMovieName.Text = _dto.TenPhim;
                txtMovieDesc.Text = _dto.Mota;
                txtGhiChu.Text = _dto.GhiChu;
                txtNoiDung.Text = _dto.NoiDung;
                txtMovieLength.Text = _dto.ThoiLuong.ToString();
                dtmMovieStart.Value = DateTime.Parse(_dto.NgayKc.ToString());
                dtmMovieEnd.Value = DateTime.Parse(_dto.NgayKt.ToString());
                txtDoTuoi.Text = _dto.DoTuoi.ToString();
                txtMovieDirector.Text = _dto.TenDaoDien;
                ccbDangPhim.SelectedValue = _dto.MaDangPhim;
                picFilm.Image = LoadImageFromFileSystem(_dto.AnhBia);

                _listLoaiPhim = await _dangPhimSV.GetAsync<List<TheLoaiCuaPhim>>("/api/LoaiCuaPhim/" + _dto.MaPhim);

                foreach (var loai in _listLoaiPhim)
                {
                    Debug.WriteLine($"Mã thể loại: {loai.MaTheLoai}");
                }

                await loadLoaiPhim_Update(_listLoaiPhim);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            string anhBiaPath = null;

            if (picFilm.Image != null)
            {
                anhBiaPath = SaveImageToFileSystem(picFilm.Image);
            }
            else
            {
                anhBiaPath = "abc.jpg";
                MessageBox.Show("Vui lòng chọn ảnh");
            }

            if (string.IsNullOrWhiteSpace(txtMovieID.Text) ||
                string.IsNullOrWhiteSpace(txtMovieName.Text) ||
                string.IsNullOrWhiteSpace(txtMovieLength.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            Phim phim = new Phim()
            {
                MaPhim = _dto.MaPhim,
                TenPhim = txtMovieName.Text,
                Mota = txtMovieDesc.Text,
                GhiChu = txtGhiChu.Text,
                NoiDung = txtNoiDung.Text,
                ThoiLuong = int.Parse(txtMovieLength.Text),
                NgayKc = ParseDate(dtmMovieStart.Text) ?? DateOnly.MinValue,
                NgayKt = ParseDate(dtmMovieEnd.Text) ?? DateOnly.MinValue,
                DoTuoi = int.Parse(txtDoTuoi.Text),
                AnhBia = anhBiaPath,
                TenDaoDien = txtMovieDirector.Text,
                MaDangPhim = Convert.ToInt32(ccbDangPhim.SelectedValue)

            };



            btnSua.Enabled = false;
            try
            {
                // Lấy danh sách thể loại mới

                var listLoaiPhimCapNhat = layLoaiPhim().GroupBy(p => p.MaTheLoai)
                                                        .Select(g => g.First())
                                                        .ToList();

                foreach (var item in listLoaiPhimCapNhat)
                {
                    Debug.WriteLine(item.MaTheLoai);
                }
                if (_listLoaiPhim != null)
                {
                    var listMaTheLoai = _listLoaiPhim;
                    var response = await _dangPhimSV.DeleteAsync("/api/LoaiCuaPhim", listMaTheLoai);
                    
                }

                // Gửi danh sách thể loại mới lên API
                var postDangCuaPhim = await _dangPhimSV.PostAsync<Models.ApiRespone>("/api/LoaiCuaPhim", listLoaiPhimCapNhat);

                var putPhim = await _dangPhimSV.PutAsync<Models.ApiRespone>("/api/Phim", phim);

                MessageBox.Show(putPhim.Message);
                BackPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                btnSua.Enabled = true;
            }
        }

        public List<TheLoaiCuaPhim> layLoaiPhim()
        {
            var danhSachLoaiPhim = new List<TheLoaiCuaPhim>();

            foreach (var control in pnlLoaiPhim.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    if (int.TryParse(checkBox.Tag?.ToString(), out int maTheLoai))
                    {
                        var theLoai = new TheLoaiCuaPhim
                        {
                            MaTheLoai = maTheLoai,
                            Maphim = _dto.MaPhim
                        };

                        if (!danhSachLoaiPhim.Any(l => l.MaTheLoai == theLoai.MaTheLoai))
                        {
                            danhSachLoaiPhim.Add(theLoai);
                        }
                    }
                }
            }

            return danhSachLoaiPhim;
        }

        public async Task loadLoaiPhim_Update(List<TheLoaiCuaPhim> loaiCuaPhim)
        {
            pnlLoaiPhim.Controls.Clear();

            // Lấy danh sách các loại phim từ API
            var loaiPhim = await _dangPhimSV.GetAsync<List<LoaiPhim>>("/api/LoaiPhim");

            if (loaiPhim == null || !loaiPhim.Any())
            {
                MessageBox.Show("Không có loại phim nào!");
                return;
            }

            if (loaiCuaPhim.Count == 0)
            {
                MessageBox.Show("Khong co loai phim");
            }
            foreach (var item in loaiPhim)
            {
                Debug.WriteLine($"LoaiPhim - MaTheLoai: {item.MaTheLoai}, TenTheLoai: {item.TenTheLoai}");
            }

            foreach (var item in loaiCuaPhim)
            {
                Debug.WriteLine($"LoaiCuaPhim - MaTheLoai: {item.MaTheLoai}");
            }

            int i = 1;

            foreach (var item in loaiPhim)
            {
                CheckBox checkbox = new CheckBox
                {
                    Text = item.TenTheLoai,
                    Top = (i - 1) * 30,
                    Left = 10,
                    AutoSize = true,
                    Tag = item.MaTheLoai,
                    Checked = loaiCuaPhim.Count != 0 && loaiCuaPhim.Any(l => l.MaTheLoai.ToString() == item.MaTheLoai.ToString())
                };

                if (loaiCuaPhim.Count != 0 && loaiCuaPhim.Any(l => l.MaTheLoai.ToString() == item.MaTheLoai.ToString()))
                {
                    Debug.WriteLine("khớp");
                }
                pnlLoaiPhim.Controls.Add(checkbox);

                i++;
            }

        }

        private Image LoadImageFromFileSystem(string filePath)
        {
            // Kiểm tra nếu đường dẫn hợp lệ và file tồn tại
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Đường dẫn ảnh không hợp lệ hoặc file không tồn tại!");
                return null;
            }

            try
            {
                // Tải ảnh từ file hệ thống
                return Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
                return null;
            }
        }

        public void LoadData()
        {

        }
        public void BackPage()
        {
            var phim = dataUc.pnData.Controls.OfType<PhimUC>().FirstOrDefault();
            if (phim != null)
            {
                dataUc.pnData.Controls.Remove(phim);
                phim.Dispose();
            }

            Debug.WriteLine("ok");

            // Ẩn tất cả các control khác
            foreach (Control control in dataUc.pnData.Controls)
            {
                control.Visible = false;
            }

            // Khởi tạo control Them_Sua cho "Sửa"
            phim = new PhimUC(dataUc);
            phim.Dock = DockStyle.Fill;
            dataUc.pnData.Controls.Add(phim);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            var phimUC = dataUc.pnData.Controls.OfType<PhimUC>().FirstOrDefault();
            if (phimUC == null)
            {
                // Nếu chưa có, tạo mới PhimUC và thêm vào pnData
                phimUC = new PhimUC(dataUc);
                phimUC.Dock = DockStyle.Fill;
                dataUc.pnData.Controls.Add(phimUC);
            }

            // Ẩn tất cả các control khác trong pnData
            foreach (Control control in dataUc.pnData.Controls)
            {
                control.Visible = false;
            }

            // Hiển thị lại PhimUC
            phimUC.Visible = true;
        }
        public async Task LoadDangPhim()
        {
            try
            {
                var listDangPhim = await _dangPhimSV.GetAsync<List<DangPhim>>("DangPhim");

                if (listDangPhim == null || listDangPhim.Count == 0)
                {
                    MessageBox.Show("Không có dạng phim nào!");
                    return;
                }

                ccbDangPhim.DataSource = listDangPhim;
                ccbDangPhim.ValueMember = "MaDangPhim";
                ccbDangPhim.DisplayMember = "TenDangPhim";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dạng phim: {ex.Message}");
            }
        }
        public DateOnly? ParseDate(string dateStr)
        {
            string[] formats = { "dd/MM/yyyy", "MM/dd/yyyy", "yyyy/MM/dd" };  // Các định dạng ngày khác nhau
            DateTime parsedDate;
            if (DateTime.TryParseExact(dateStr, formats, null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                return DateOnly.FromDateTime(parsedDate);
            }
            else
            {
                return null;  // Hoặc ném exception tùy nhu cầu
            }
        }


        private string SaveImageToFileSystem(Image image)
        {
            // Đặt thư mục lưu ảnh
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "FilmsManage", "FilmsManage", "FilmsManage", "Image");
            // Cần thay đổi theo thư mục bạn muốn
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath); // Tạo thư mục nếu chưa tồn tại
            }

            // Tạo tên tệp ảnh duy nhất
            string fileName = Guid.NewGuid().ToString() + ".jpg"; // Dùng GUID để tạo tên tệp duy nhất
            string filePath = Path.Combine(folderPath, fileName);

            // Lưu ảnh vào tệp
            image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);

            return filePath; // Trả về đường dẫn ảnh
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string anhBiaPath = null;

            if (picFilm.Image != null)
            {
                anhBiaPath = SaveImageToFileSystem(picFilm.Image);
            }
            else
            {
                anhBiaPath = "default_image_path.jpg";
            }
            Phim newPhim = new Phim
            {
                TenPhim = txtMovieName.Text,
                Mota = txtMovieDesc.Text,
                GhiChu = txtGhiChu.Text,
                NoiDung = txtNoiDung.Text,
                ThoiLuong = int.Parse(txtMovieLength.Text),
                NgayKc = ParseDate(dtmMovieStart.Text) ?? DateOnly.MinValue,
                NgayKt = ParseDate(dtmMovieEnd.Text) ?? DateOnly.MinValue,
                DoTuoi = int.Parse(txtDoTuoi.Text),
                AnhBia = anhBiaPath,
                TenDaoDien = txtMovieDirector.Text,
                MaDangPhim = Convert.ToInt32(ccbDangPhim.SelectedValue)
            };
            string json = JsonConvert.SerializeObject(newPhim);
            Debug.WriteLine(json);
            try
            {
                // Gửi yêu cầu thêm phim và nhận phản hồi
                var response = await _dangPhimSV.PostAsync<DTO.FilmDTO>("api/Phim", newPhim);

                if (response != null && response.phim != null)
                {
                    // Lấy ID của phim vừa tạo
                    int idPhim = response.phim.MaPhim;

                    MessageBox.Show($"Thêm phim thành công! Mã phim: {idPhim}");

                    // Thêm các loại phim vào phim vừa tạo
                    await ThemLoaiChoPhim(idPhim);
                    BackPage();
                }
                else
                {
                    MessageBox.Show($"Lỗi: {response?.Message ?? "Không nhận được phản hồi từ API"}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm phim: {ex.Message}");
            }
        }

        public async Task ThemLoaiChoPhim(int idPhim)
        {
            // Lấy danh sách ID của các loại phim đã được chọn
            var selectedLoaiPhimIds = pnlLoaiPhim.Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked) // Chỉ lấy các checkbox được chọn
                .Select(cb => int.Parse(cb.Tag.ToString())) // Giả sử bạn lưu `idLoaiPhim` trong thuộc tính `Tag`
                .ToList();

            if (!selectedLoaiPhimIds.Any())
            {
                MessageBox.Show("Chưa chọn loại phim nào!");
                return;
            }

            // Tạo danh sách các đối tượng liên kết `TheLoaiCuaPhim`
            var phimLoaiPhimList = selectedLoaiPhimIds.Select(loaiPhimId => new TheLoaiCuaPhim
            {
                Maphim = idPhim,
                MaTheLoai = loaiPhimId
            }).ToList();

            // Ghi log JSON để kiểm tra
            foreach (var item in phimLoaiPhimList)
            {
                string json = JsonConvert.SerializeObject(item);
                Debug.WriteLine(json);
            }

            try
            {
                // Gửi danh sách lên API
                var response = await _dangPhimSV.PostAsync<Models.ApiRespone>("api/LoaiCuaPhim", phimLoaiPhimList);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi gửi yêu cầu
                MessageBox.Show($"Lỗi khi thêm loại phim: {ex.Message}");
            }
        }


        public async Task loadLoaiPhim()
        {
            var loaiPhim = await _dangPhimSV.GetAsync<List<LoaiPhim>>("/api/LoaiPhim");

            if (loaiPhim == null || !loaiPhim.Any())
            {
                MessageBox.Show("Không có loại phim nào!");
                return;
            }

            // Biến đếm để đặt vị trí Top cho các checkbox
            int i = 1;

            foreach (var item in loaiPhim)
            {
                Debug.WriteLine(item.TenTheLoai);

                // Tạo checkbox cho từng loại phim
                CheckBox checkbox = new CheckBox
                {
                    Text = item.TenTheLoai, // Hiển thị tên loại phim
                    Tag = item.MaTheLoai,          // Gắn ID loại phim vào thuộc tính Tag
                    Top = (i - 1) * 30,     // Khoảng cách giữa các checkbox
                    Left = 10,
                    AutoSize = true,
                    //Checked = false,
                };

                // Thêm checkbox vào Panel
                pnlLoaiPhim.Controls.Add(checkbox);

                i++;
            }
        }



        private void btnUpLoadPictureFilm_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Chỉ định bộ lọc tệp (chỉ hiện các file ảnh)
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                openFileDialog.Title = "Chọn ảnh";

                // Nếu người dùng chọn tệp và nhấn OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Lấy đường dẫn tệp được chọn
                        string selectedFilePath = openFileDialog.FileName;

                        // Hiển thị ảnh trong PictureBox
                        picFilm.Image = Image.FromFile(selectedFilePath);
                        picFilm.SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var themSua = dataUc.pnData.Controls.OfType<ChucNang_Phim.Them_Sua>().FirstOrDefault();
            if (themSua != null)
            {
                dataUc.pnData.Controls.Remove(themSua);
                themSua.Dispose();
            }

            // Ẩn tất cả các control khác
            foreach (Control control in dataUc.pnData.Controls)
            {
                control.Visible = false;
            }


            // Khởi tạo control Them_Sua cho "ChiTiet"
            var theLoai = new TheLoaiPhimUC(dataUc);
            theLoai.Dock = DockStyle.Fill;
            dataUc.pnData.Controls.Add(theLoai);
        }
    }
}
