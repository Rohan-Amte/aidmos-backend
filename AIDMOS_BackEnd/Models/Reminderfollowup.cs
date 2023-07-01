using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("reminderfollowups")]
public partial class Reminderfollowup
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("reminderid", TypeName = "numeric(18, 0)")]
    public decimal? Reminderid { get; set; }

    [Column("fdate", TypeName = "date")]
    public DateTime? Fdate { get; set; }

    [Column("followup")]
    public string? Followup { get; set; }

    [Column("followupby")]
    public string? Followupby { get; set; }

    [Column("nextfollowupdate", TypeName = "date")]
    public DateTime? Nextfollowupdate { get; set; }
}
