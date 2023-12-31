﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("acc_settings")]
public partial class AccSetting
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("cname")]
    public string? Cname { get; set; }

    [Column("cvalue")]
    public string? Cvalue { get; set; }
}
