using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("products")]
[Index("Businessid", Name = "products_businessid")]
public partial class Product
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("businessid", TypeName = "numeric(18, 0)")]
    public decimal? Businessid { get; set; }

    [Column("categoryfor")]
    [StringLength(50)]
    public string? Categoryfor { get; set; }

    [Column("techname")]
    public string? Techname { get; set; }

    [Column("brandname")]
    public string? Brandname { get; set; }

    [Column("gradetypeformulation")]
    public string? Gradetypeformulation { get; set; }

    [Column("companyid", TypeName = "numeric(18, 0)")]
    public decimal? Companyid { get; set; }

    [Column("marketingcompanyid", TypeName = "numeric(18, 0)")]
    public decimal? Marketingcompanyid { get; set; }

    [Column("hsncode")]
    [StringLength(500)]
    public string? Hsncode { get; set; }

    [Column("gstpercent", TypeName = "numeric(18, 2)")]
    public decimal? Gstpercent { get; set; }

    [Column("cirno")]
    [StringLength(500)]
    public string? Cirno { get; set; }

    [Column("forcrops")]
    public string? Forcrops { get; set; }

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

    [Column("forpest")]
    public string? Forpest { get; set; }

    [Column("packingsize")]
    public double? Packingsize { get; set; }

    [Column("unit")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Unit { get; set; }

    [Column("aidmosuid")]
    public string? Aidmosuid { get; set; }

    [ForeignKey("Businessid")]
    [InverseProperty("Products")]
    public virtual Business? Business { get; set; }

    [ForeignKey("Companyid")]
    [InverseProperty("Products")]
    public virtual Company? Company { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<Deliverynotedetail> Deliverynotedetails { get; set; } = new List<Deliverynotedetail>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductGstrate> ProductGstrates { get; set; } = new List<ProductGstrate>();

    [InverseProperty("Product")]
    public virtual ICollection<Productlotwisestock> Productlotwisestocks { get; set; } = new List<Productlotwisestock>();

    [InverseProperty("Product")]
    public virtual ICollection<Purchasedetail> Purchasedetails { get; set; } = new List<Purchasedetail>();

    [InverseProperty("Product")]
    public virtual ICollection<Receiptnotedetail> Receiptnotedetails { get; set; } = new List<Receiptnotedetail>();

    [InverseProperty("Product")]
    public virtual ICollection<Saledetail> Saledetails { get; set; } = new List<Saledetail>();
}
