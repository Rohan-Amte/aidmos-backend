using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("advertisements")]
public partial class Advertisement
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("adfor")]
    [StringLength(50)]
    public string? Adfor { get; set; }

    [Column("adcontents")]
    public string? Adcontents { get; set; }
}
