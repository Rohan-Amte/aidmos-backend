using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("wholesaletoreatailtransfer")]
public partial class Wholesaletoreatailtransfer
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("productid", TypeName = "numeric(18, 0)")]
    public decimal? Productid { get; set; }

    [Column("plsid", TypeName = "numeric(18, 0)")]
    public decimal? Plsid { get; set; }

    [Column("quantity", TypeName = "numeric(18, 0)")]
    public decimal? Quantity { get; set; }

    [Column("transferdate", TypeName = "datetime")]
    public DateTime? Transferdate { get; set; }
}
