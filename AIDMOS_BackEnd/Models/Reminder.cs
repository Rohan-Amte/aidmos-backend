using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("reminders")]
public partial class Reminder
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("ledgerid", TypeName = "numeric(18, 0)")]
    public decimal? Ledgerid { get; set; }

    [Column("rdate", TypeName = "date")]
    public DateTime? Rdate { get; set; }

    [Column("message")]
    public string? Message { get; set; }

    [Column("status")]
    [StringLength(10)]
    public string? Status { get; set; }
}
