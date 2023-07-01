using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("acc_ledgerbalances")]
public partial class AccLedgerbalance
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("businessid", TypeName = "numeric(18, 0)")]
    public decimal? Businessid { get; set; }

    [Column("ledgerid", TypeName = "numeric(18, 0)")]
    public decimal? Ledgerid { get; set; }

    [Column("openingbalance", TypeName = "numeric(18, 2)")]
    public decimal? Openingbalance { get; set; }

    [Column("balancetype")]
    [StringLength(50)]
    public string? Balancetype { get; set; }

    [Column("financialyear")]
    [StringLength(50)]
    public string? Financialyear { get; set; }

    [Column("closingbalance", TypeName = "numeric(18, 2)")]
    public decimal? Closingbalance { get; set; }

    [ForeignKey("Businessid")]
    [InverseProperty("AccLedgerbalances")]
    public virtual Business? Business { get; set; }

    [ForeignKey("Ledgerid")]
    [InverseProperty("AccLedgerbalances")]
    public virtual AccLedger? Ledger { get; set; }
}
