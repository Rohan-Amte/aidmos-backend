using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("saledetails")]
public partial class Saledetail
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("saleid", TypeName = "numeric(18, 0)")]
    public decimal? Saleid { get; set; }

    [Column("categoryfor")]
    [StringLength(50)]
    public string? Categoryfor { get; set; }

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

    [Column("taxableamount", TypeName = "numeric(18, 2)")]
    public decimal? Taxableamount { get; set; }

    [Column("plsid", TypeName = "numeric(18, 0)")]
    public decimal? Plsid { get; set; }

    [Column("ratewithgst", TypeName = "numeric(18, 2)")]
    public decimal? Ratewithgst { get; set; }

    [Column("gstrate", TypeName = "numeric(18, 2)")]
    public decimal? Gstrate { get; set; }

    [Column("entrytype")]
    [StringLength(50)]
    public string? Entrytype { get; set; }

    [ForeignKey("Productid")]
    [InverseProperty("Saledetails")]
    public virtual Product? Product { get; set; }

    [ForeignKey("Saleid")]
    [InverseProperty("Saledetails")]
    public virtual Sale? Sale { get; set; }
}
