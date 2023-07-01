using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("districts")]
public partial class District
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("stateid", TypeName = "numeric(18, 0)")]
    public decimal? Stateid { get; set; }

    [Column("name")]
    [StringLength(500)]
    public string? Name { get; set; }

    [Column("isdefault")]
    [StringLength(50)]
    public string? Isdefault { get; set; }

    [ForeignKey("Stateid")]
    [InverseProperty("Districts")]
    public virtual State? State { get; set; }

    [InverseProperty("District")]
    public virtual ICollection<Taluka> Talukas { get; set; } = new List<Taluka>();
}
