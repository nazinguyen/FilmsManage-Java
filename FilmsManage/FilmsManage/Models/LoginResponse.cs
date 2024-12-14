using FilmsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsManage.Models
{
    public  class LoginResponse
    {
        public string? Token { get; set; }
        public NhanVien? User { get; set; }
        public string? Message { get; set; }

    }
}
