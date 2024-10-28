using System;
using System.Collections.Generic;

namespace FilmsManage.Models.Entities;

public partial class TinhTrang
{
    public int MaTinhTrang { get; set; }

    public string TenTinhTrang { get; set; } = null!;

    public virtual ICollection<Ghe> Ghes { get; set; } = new List<Ghe>();
}
