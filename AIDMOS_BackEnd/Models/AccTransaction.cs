using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("acc_transactions")]
public partial class AccTransaction
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("businessid", TypeName = "numeric(18, 0)")]
    public decimal? Businessid { get; set; }

    [Column("financialyear")]
    [StringLength(50)]
    public string? Financialyear { get; set; }

    [Column("transactiono", TypeName = "numeric(18, 0)")]
    public decimal? Transactiono { get; set; }

    [Column("effectfrom")]
    [StringLength(500)]
    public string? Effectfrom { get; set; }

    [Column("particular")]
    public string? Particular { get; set; }

    [Column("referenceid", TypeName = "numeric(18, 0)")]
    public decimal? Referenceid { get; set; }

    [Column("ledgerid", TypeName = "numeric(18, 0)")]
    public decimal? Ledgerid { get; set; }

    [Column("transactiontype")]
    [StringLength(50)]
    public string? Transactiontype { get; set; }

    [Column("amount", TypeName = "numeric(18, 2)")]
    public decimal? Amount { get; set; }

    [Column("status")]
    [StringLength(50)]
    public string? Status { get; set; }

    [Column("createdby", TypeName = "numeric(18, 0)")]
    public decimal? Createdby { get; set; }

    [Column("createdon", TypeName = "datetime")]
    public DateTime? Createdon { get; set; }

    [Column("updatedby", TypeName = "numeric(18, 0)")]
    public decimal? Updatedby { get; set; }

    [Column("updatedon", TypeName = "datetime")]
    public DateTime? Updatedon { get; set; }

    [Column("deletedby", TypeName = "numeric(18, 0)")]
    public decimal? Deletedby { get; set; }

    [Column("deletedon", TypeName = "datetime")]
    public DateTime? Deletedon { get; set; }

    [Column("transactiondate", TypeName = "date")]
    public DateTime? Transactiondate { get; set; }

    [Column("voucherno", TypeName = "numeric(18, 0)")]
    public decimal? Voucherno { get; set; }

    [ForeignKey("Businessid")]
    [InverseProperty("AccTransactions")]
    public virtual Business? Business { get; set; }

    [ForeignKey("Ledgerid")]
    [InverseProperty("AccTransactions")]
    public virtual AccLedger? Ledger { get; set; }
}
