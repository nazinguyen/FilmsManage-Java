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

namespace FilmsManage
{
    public partial class LichChieu : Form
    {
        private readonly DangPhimSV _LichChieu;
        public LichChieu()
        {
            _LichChieu = new DangPhimSV("https://localhost:7085");
            InitializeComponent();
            LoadData();
        }

        public async Task LoadData()
        {
            try
            {
                // Gọi API để lấy danh sách xuất chiếu
                var xuatChieuList = await _LichChieu.GetAsync<List<XuatChieu>>("/api/XuatChieu");

                if (xuatChieuList == null || !xuatChieuList.Any())
                {
                    MessageBox.Show("Không tìm thấy dữ liệu lịch chiếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Xóa dữ liệu cũ trong ListView
                lvLichChieu.Items.Clear();

                // Chuẩn bị và thêm dữ liệu vào ListView
                foreach (var xuatChieu in xuatChieuList)
                {
                    var item = new ListViewItem(xuatChieu.MaXuatChieu.ToString()); // Cột đầu tiên (Mã xuất chiếu)
                    item.SubItems.Add(xuatChieu.MaPhongNavigation?.TenPhongChieu ?? "Chưa gắn phòng"); // Cột thứ hai (Tên phòng chiếu)
                    item.SubItems.Add(xuatChieu.MaPhimNavigation?.TenPhim ?? "Chưa gắn phim"); // Cột thứ ba (Tên phim)
                    item.SubItems.Add(xuatChieu.ThoiGianBatDau.ToString("dd/MM/yyyy HH:mm")); // Cột thứ tư (Thời gian bắt đầu)
                    item.SubItems.Add(xuatChieu.ThoiGianKetThuc.ToString("dd/MM/yyyy HH:mm")); // Cột thứ năm (Thời gian kết thúc)

                    // Thêm vào ListView
                    lvLichChieu.Items.Add(item);
                }

                // Làm mới giao diện ListView
                lvLichChieu.Refresh();
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Lỗi kết nối tới API: {httpEx.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
