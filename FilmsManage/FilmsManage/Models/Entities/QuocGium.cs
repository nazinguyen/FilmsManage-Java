using System;
using System.Collections.Generic;

namespace FilmsManage.Models.Entities;

public partial class QuocGium
{
    public int IdQuocGia { get; set; }

    public string TenNuoc { get; set; } = null!;

    public virtual ICollection<Phim> Phims { get; set; } = new List<Phim>();
}
