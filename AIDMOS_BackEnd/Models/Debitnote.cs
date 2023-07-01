﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("debitnotes")]
public partial class Debitnote
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("businessid", TypeName = "numeric(18, 0)")]
    public decimal? Businessid { get; set; }

    [Column("voucherno", TypeName = "numeric(18, 0)")]
    public decimal? Voucherno { get; set; }

    [Column("dndate", TypeName = "date")]
    public DateTime? Dndate { get; set; }

    [Column("ledgerid", TypeName = "numeric(18, 0)")]
    public decimal? Ledgerid { get; set; }

    [Column("subtotal", TypeName = "numeric(18, 2)")]
    public decimal? Subtotal { get; set; }

    [Column("discountamount", TypeName = "numeric(18, 2)")]
    public decimal? Discountamount { get; set; }

    [Column("gstamount", TypeName = "numeric(18, 2)")]
    public decimal? Gstamount { get; set; }

    [Column("billamount", TypeName = "numeric(18, 2)")]
    public decimal? Billamount { get; set; }

    [Column("otherchargestotal", TypeName = "numeric(18, 2)")]
    public decimal? Otherchargestotal { get; set; }

    [Column("taxableamount", TypeName = "numeric(18, 2)")]
    public decimal? Taxableamount { get; set; }

    [Column("roundoff", TypeName = "numeric(18, 2)")]
    public decimal? Roundoff { get; set; }

    [Column("grandtotal", TypeName = "numeric(18, 2)")]
    public decimal? Grandtotal { get; set; }

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

    [Column("financialyear")]
    [StringLength(50)]
    public string? Financialyear { get; set; }

    [Column("calculateroundoff")]
    [StringLength(50)]
    public string? Calculateroundoff { get; set; }

    [Column("noteno")]
    [StringLength(500)]
    public string? Noteno { get; set; }

    [Column("purchaseid", TypeName = "numeric(18, 0)")]
    public decimal? Purchaseid { get; set; }

    [ForeignKey("Businessid")]
    [InverseProperty("Debitnotes")]
    public virtual Business? Business { get; set; }

    [InverseProperty("Debitnote")]
    public virtual ICollection<Debitnoteotherchargesdetail> Debitnoteotherchargesdetails { get; set; } = new List<Debitnoteotherchargesdetail>();

    [ForeignKey("Ledgerid")]
    [InverseProperty("Debitnotes")]
    public virtual AccLedger? Ledger { get; set; }

    [ForeignKey("Purchaseid")]
    [InverseProperty("Debitnotes")]
    public virtual Purchase? Purchase { get; set; }

    [InverseProperty("Deliverynote")]
    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
