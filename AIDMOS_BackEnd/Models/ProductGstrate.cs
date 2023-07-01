using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("product_gstrates")]
public partial class ProductGstrate
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("productid", TypeName = "numeric(18, 0)")]
    public decimal? Productid { get; set; }

    [Column("fromdate", TypeName = "date")]
    public DateTime? Fromdate { get; set; }

    [Column("gstpercent", TypeName = "numeric(18, 2)")]
    public decimal? Gstpercent { get; set; }

    [ForeignKey("Productid")]
    [InverseProperty("ProductGstrates")]
    public virtual Product? Product { get; set; }
}
