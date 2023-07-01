using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("productlotwisestock")]
public partial class Productlotwisestock
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("productid", TypeName = "numeric(18, 0)")]
    public decimal? Productid { get; set; }

    [Column("purchaseid", TypeName = "numeric(18, 0)")]
    public decimal? Purchaseid { get; set; }

    [Column("lotno")]
    [StringLength(500)]
    public string? Lotno { get; set; }

    [Column("pquantity", TypeName = "numeric(18, 0)")]
    public decimal? Pquantity { get; set; }

    [Column("stock", TypeName = "numeric(18, 0)")]
    public decimal? Stock { get; set; }

    [Column("pdid", TypeName = "numeric(18, 0)")]
    public decimal? Pdid { get; set; }

    [Column("status")]
    [StringLength(50)]
    public string? Status { get; set; }

    [Column("businessid", TypeName = "numeric(18, 0)")]
    public decimal? Businessid { get; set; }

    [Column("salerate", TypeName = "numeric(18, 2)")]
    public decimal? Salerate { get; set; }

    [Column("receiptnoteid", TypeName = "numeric(18, 0)")]
    public decimal? Receiptnoteid { get; set; }

    [Column("rndid", TypeName = "numeric(18, 0)")]
    public decimal? Rndid { get; set; }

    [Column("disposedas")]
    public string? Disposedas { get; set; }

    [Column("location")]
    public string? Location { get; set; }

    [Column("salegstamount", TypeName = "numeric(18, 2)")]
    public decimal? Salegstamount { get; set; }

    [Column("totalsalerate", TypeName = "numeric(18, 2)")]
    public decimal? Totalsalerate { get; set; }

    [Column("entrytype")]
    [StringLength(50)]
    public string? Entrytype { get; set; }

    [Column("mrp", TypeName = "numeric(18, 2)")]
    public decimal? Mrp { get; set; }

    [Column("mfgdate", TypeName = "date")]
    public DateTime? Mfgdate { get; set; }

    [Column("expdate", TypeName = "date")]
    public DateTime? Expdate { get; set; }

    [Column("creditsalerate", TypeName = "numeric(18, 2)")]
    public decimal? Creditsalerate { get; set; }

    [Column("creditsalegstamount", TypeName = "numeric(18, 2)")]
    public decimal? Creditsalegstamount { get; set; }

    [Column("credittotalsalerate", TypeName = "numeric(18, 2)")]
    public decimal? Credittotalsalerate { get; set; }

    [Column("purchaserate", TypeName = "numeric(18, 2)")]
    public decimal? Purchaserate { get; set; }

    [Column("tplsid", TypeName = "numeric(18, 0)")]
    public decimal? Tplsid { get; set; }

    [ForeignKey("Businessid")]
    [InverseProperty("Productlotwisestocks")]
    public virtual Business? Business { get; set; }

    [ForeignKey("Pdid")]
    [InverseProperty("Productlotwisestocks")]
    public virtual Purchasedetail? Pd { get; set; }

    [ForeignKey("Productid")]
    [InverseProperty("Productlotwisestocks")]
    public virtual Product? Product { get; set; }

    [ForeignKey("Purchaseid")]
    [InverseProperty("Productlotwisestocks")]
    public virtual Purchase? Purchase { get; set; }

    [ForeignKey("Receiptnoteid")]
    [InverseProperty("Productlotwisestocks")]
    public virtual Receiptnote? Receiptnote { get; set; }

    [ForeignKey("Rndid")]
    [InverseProperty("Productlotwisestocks")]
    public virtual Receiptnotedetail? Rnd { get; set; }
}
