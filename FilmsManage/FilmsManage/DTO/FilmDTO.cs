using FilmsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsManage.DTO
{
    public class FilmDTO
    {
        public Phim? phim {  get; set; }
        public string? Message { get; set; }
    }
}
