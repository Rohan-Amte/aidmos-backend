using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("modulemenus")]
public partial class Modulemenu
{
    [Key]
    [Column("id", TypeName = "numeric(38, 0)")]
    public decimal Id { get; set; }

    [Column("moduleid", TypeName = "numeric(38, 0)")]
    public decimal? Moduleid { get; set; }

    [Column("menuid", TypeName = "numeric(38, 0)")]
    public decimal? Menuid { get; set; }

    [ForeignKey("Menuid")]
    [InverseProperty("Modulemenus")]
    public virtual Menu? Menu { get; set; }

    [ForeignKey("Moduleid")]
    [InverseProperty("Modulemenus")]
    public virtual Module? Module { get; set; }
}
