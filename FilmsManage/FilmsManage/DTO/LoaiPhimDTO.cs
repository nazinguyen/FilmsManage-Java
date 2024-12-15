using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsManage.DTO
{
    internal class LoaiPhimDTO
    {
        public class PhimDTO
        {
            public int MaPhim { get; set; }
            public string TenPhim { get; set; }
            public string AnhBia { get; set; }
            public int ThoiLuong { get; set; }
            public DateTime NgayKc { get; set; }
            public List<TheLoaiDTO> TheLoai { get; set; }
            public List<XuatChieuDTO> MaXuatChieu { get; set; }
            public List<XuatChieuDTO> ThoiGianBatDau { get; set; }

        }

        public class TheLoaiDTO
        {
            public int MaTheLoai { get; set; }
            public string TenTheLoai { get; set; }
        }

        public class XuatChieuDTO
        {
            public int MaXuatChieu { get; set; }
            public int ThoiGianBatDau { get;set; }
        }
    }
}
