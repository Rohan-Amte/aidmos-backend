using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("receiptnotedetails")]
public partial class Receiptnotedetail
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("receiptnoteid", TypeName = "numeric(18, 0)")]
    public decimal? Receiptnoteid { get; set; }

    [Column("productid", TypeName = "numeric(18, 0)")]
    public decimal? Productid { get; set; }

    [Column("rate", TypeName = "numeric(18, 2)")]
    public decimal? Rate { get; set; }

    [Column("quantity", TypeName = "numeric(18, 0)")]
    public decimal? Quantity { get; set; }

    [Column("subtotal", TypeName = "numeric(18, 2)")]
    public decimal? Subtotal { get; set; }

    [Column("discountpercent", TypeName = "numeric(18, 2)")]
    public decimal? Discountpercent { get; set; }

    [Column("discountamount", TypeName = "numeric(18, 2)")]
    public decimal? Discountamount { get; set; }

    [Column("gstpercent", TypeName = "numeric(18, 2)")]
    public decimal? Gstpercent { get; set; }

    [Column("gstamount", TypeName = "numeric(18, 2)")]
    public decimal? Gstamount { get; set; }

    [Column("totalamount", TypeName = "numeric(18, 2)")]
    public decimal? Totalamount { get; set; }

    [Column("lotno")]
    [StringLength(500)]
    public string? Lotno { get; set; }

    [Column("salerate", TypeName = "numeric(18, 2)")]
    public decimal? Salerate { get; set; }

    [Column("taxableamount", TypeName = "numeric(18, 2)")]
    public decimal? Taxableamount { get; set; }

    [Column("mfgdate", TypeName = "date")]
    public DateTime? Mfgdate { get; set; }

    [Column("expdate", TypeName = "date")]
    public DateTime? Expdate { get; set; }

    [Column("location")]
    public string? Location { get; set; }

    [Column("status")]
    [StringLength(50)]
    public string? Status { get; set; }

    [Column("salegstamount", TypeName = "numeric(18, 2)")]
    public decimal? Salegstamount { get; set; }

    [Column("totalsalerate", TypeName = "numeric(18, 2)")]
    public decimal? Totalsalerate { get; set; }

    [Column("entrytype")]
    [StringLength(50)]
    public string? Entrytype { get; set; }

    [Column("mrp", TypeName = "numeric(18, 2)")]
    public decimal? Mrp { get; set; }

    [Column("creditsalerate", TypeName = "numeric(18, 2)")]
    public decimal? Creditsalerate { get; set; }

    [Column("creditsalegstamount", TypeName = "numeric(18, 2)")]
    public decimal? Creditsalegstamount { get; set; }

    [Column("credittotalsalerate", TypeName = "numeric(18, 2)")]
    public decimal? Credittotalsalerate { get; set; }

    [ForeignKey("Productid")]
    [InverseProperty("Receiptnotedetails")]
    public virtual Product? Product { get; set; }

    [InverseProperty("Rnd")]
    public virtual ICollection<Productlotwisestock> Productlotwisestocks { get; set; } = new List<Productlotwisestock>();

    [ForeignKey("Receiptnoteid")]
    [InverseProperty("Receiptnotedetails")]
    public virtual Receiptnote? Receiptnote { get; set; }
}
