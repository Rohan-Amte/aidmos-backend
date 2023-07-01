using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("stocktransferhistory")]
public partial class Stocktransferhistory
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("businessid", TypeName = "numeric(18, 0)")]
    public decimal? Businessid { get; set; }

    [Column("transferdate", TypeName = "date")]
    public DateTime? Transferdate { get; set; }

    [Column("productid", TypeName = "numeric(18, 0)")]
    public decimal? Productid { get; set; }

    [Column("lotno")]
    public string? Lotno { get; set; }

    [Column("fromlocation")]
    public string? Fromlocation { get; set; }

    [Column("tolocation")]
    public string? Tolocation { get; set; }
}
