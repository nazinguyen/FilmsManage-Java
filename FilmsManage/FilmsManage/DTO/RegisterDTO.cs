using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsManage.DTO
{
    public class RegisterDTO
    {
        public required string userName {  get; set; }
        public required string password { get; set; }
    }
}
