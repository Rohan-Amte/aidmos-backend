using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("notices")]
public partial class Notice
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("noticefor")]
    [StringLength(50)]
    public string? Noticefor { get; set; }

    [Column("noticecontents")]
    public string? Noticecontents { get; set; }
}
