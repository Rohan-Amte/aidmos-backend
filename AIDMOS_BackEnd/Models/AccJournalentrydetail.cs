using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("acc_journalentrydetails")]
public partial class AccJournalentrydetail
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("journalentryid", TypeName = "numeric(18, 0)")]
    public decimal? Journalentryid { get; set; }

    [Column("ledgerid", TypeName = "numeric(18, 0)")]
    public decimal? Ledgerid { get; set; }

    [Column("transactiontype")]
    [StringLength(50)]
    public string? Transactiontype { get; set; }

    [Column("amount", TypeName = "numeric(18, 2)")]
    public decimal? Amount { get; set; }

    [Column("referenceas")]
    [StringLength(50)]
    public string? Referenceas { get; set; }

    [Column("referenceno")]
    public string? Referenceno { get; set; }
}
