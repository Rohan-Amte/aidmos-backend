using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("acc_receiptentries")]
public partial class AccReceiptentry
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("businessid", TypeName = "numeric(18, 0)")]
    public decimal? Businessid { get; set; }

    [Column("financialyear")]
    [StringLength(50)]
    public string? Financialyear { get; set; }

    [Column("voucherno", TypeName = "numeric(18, 0)")]
    public decimal? Voucherno { get; set; }

    [Column("entrydate", TypeName = "date")]
    public DateTime? Entrydate { get; set; }

    [Column("fromledgerid", TypeName = "numeric(18, 0)")]
    public decimal? Fromledgerid { get; set; }

    [Column("toledgerid", TypeName = "numeric(18, 0)")]
    public decimal? Toledgerid { get; set; }

    [Column("amount", TypeName = "numeric(18, 2)")]
    public decimal? Amount { get; set; }

    [Column("narration")]
    public string? Narration { get; set; }

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

    [Column("status")]
    [StringLength(50)]
    public string? Status { get; set; }

    [Column("referenceas")]
    [StringLength(50)]
    public string? Referenceas { get; set; }

    [Column("referenceno", TypeName = "numeric(18, 0)")]
    public decimal? Referenceno { get; set; }

    [Column("chequeno")]
    public string? Chequeno { get; set; }
}
