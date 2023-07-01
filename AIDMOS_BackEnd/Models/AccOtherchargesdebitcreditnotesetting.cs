using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("acc_otherchargesdebitcreditnotesettings")]
public partial class AccOtherchargesdebitcreditnotesetting
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("title")]
    [StringLength(500)]
    public string? Title { get; set; }

    [Column("applytodebitnote")]
    [StringLength(50)]
    public string? Applytodebitnote { get; set; }

    [Column("debitnoteledgerid", TypeName = "numeric(18, 0)")]
    public decimal? Debitnoteledgerid { get; set; }

    [Column("debitnotegstpercent", TypeName = "numeric(18, 2)")]
    public decimal? Debitnotegstpercent { get; set; }

    [Column("applytocreditnote")]
    [StringLength(50)]
    public string? Applytocreditnote { get; set; }

    [Column("creditnoteledgerid", TypeName = "numeric(18, 0)")]
    public decimal? Creditnoteledgerid { get; set; }

    [Column("creditnotegstpercent", TypeName = "numeric(18, 2)")]
    public decimal? Creditnotegstpercent { get; set; }

    [Column("todebit")]
    [StringLength(50)]
    public string? Todebit { get; set; }

    [Column("tocredit")]
    [StringLength(50)]
    public string? Tocredit { get; set; }
}
