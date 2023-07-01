using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("usermodulemapping")]
public partial class Usermodulemapping
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("FKUserId", TypeName = "numeric(18, 0)")]
    public decimal? FkuserId { get; set; }

    [Column("FKModuleId", TypeName = "numeric(38, 0)")]
    public decimal? FkmoduleId { get; set; }

    [ForeignKey("FkmoduleId")]
    [InverseProperty("Usermodulemappings")]
    public virtual Module? Fkmodule { get; set; }

    [ForeignKey("FkuserId")]
    [InverseProperty("Usermodulemappings")]
    public virtual User? Fkuser { get; set; }
}
