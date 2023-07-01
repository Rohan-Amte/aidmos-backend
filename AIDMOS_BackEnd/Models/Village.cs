using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("villages")]
public partial class Village
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("talukaid", TypeName = "numeric(18, 0)")]
    public decimal? Talukaid { get; set; }

    [Column("name")]
    [StringLength(500)]
    public string? Name { get; set; }

    [Column("isdefault")]
    [StringLength(50)]
    public string? Isdefault { get; set; }

    [Column("businessid", TypeName = "numeric(18, 0)")]
    public decimal? Businessid { get; set; }

    [InverseProperty("Village")]
    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    [ForeignKey("Businessid")]
    [InverseProperty("Villages")]
    public virtual Business? Business { get; set; }

    [InverseProperty("Village")]
    public virtual ICollection<Business> Businesses { get; set; } = new List<Business>();

    [ForeignKey("Talukaid")]
    [InverseProperty("Villages")]
    public virtual Taluka? Taluka { get; set; }
}
