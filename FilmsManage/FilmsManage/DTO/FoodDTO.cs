using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsManage.DTO
{
    public class FoodDTO
    {

        public int Id { get; set; }        // ID sản phẩm
        public string Name { get; set; }   // Tên sản phẩm
        public string ImageUrl { get; set; } // Đường dẫn hình ảnh
        public decimal Price { get; set; }   // Giá sản phẩm
        public int Quantity { get; set; }
    }
}
