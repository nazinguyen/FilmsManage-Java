using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsManage.Models
{

    //model để ánh xạ dữ liệu cho datagridviwew
    public class DoanhThuPhim
        {
            public string TenPhim { get; set; }

            public decimal TongDoanhThu { get; set; }
        public DateOnly NgayKc { get; set; }
        public int SoVeBan { get; set; }
        }

    }
