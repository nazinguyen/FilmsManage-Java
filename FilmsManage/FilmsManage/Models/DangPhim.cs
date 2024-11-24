using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmsAPI.Models;

public partial class DangPhim
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MaDangPhim { get; set; }

    public string TenDangPhim { get; set; } = null!;

    public int MaManHinh { get; set; }
    [JsonIgnore]
    public virtual ManHinh? MaManHinhNavigation { get; set; } = null!;

    public virtual ICollection<Phim>? Phims { get; set; } = new List<Phim>();
}
