using System;
using System.Collections.Generic;

namespace FilmsManage.Models.Entities;

public partial class Quyen
{
    public int MaQuyen { get; set; }

    public string TenQuyen { get; set; } = null!;

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
