using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsManage.DTO
{
    public class LoginDTO
    {
        public required string Sdt { get; set; }
        public required string Password { get; set; }
    }
}
