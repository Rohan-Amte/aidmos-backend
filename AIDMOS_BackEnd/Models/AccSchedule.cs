using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("acc_schedules")]
public partial class AccSchedule
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("name")]
    [StringLength(500)]
    public string? Name { get; set; }

    [Column("type")]
    [StringLength(50)]
    public string? Type { get; set; }

    [Column("srno", TypeName = "numeric(18, 0)")]
    public decimal? Srno { get; set; }

    [InverseProperty("Schedule")]
    public virtual ICollection<AccGroup> AccGroups { get; set; } = new List<AccGroup>();
}
