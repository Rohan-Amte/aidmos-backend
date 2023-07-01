using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("purchasereturnotherchargesdetails")]
public partial class Purchasereturnotherchargesdetail
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("purchasereturnid", TypeName = "numeric(18, 0)")]
    public decimal? Purchasereturnid { get; set; }

    [Column("otherchargesid", TypeName = "numeric(18, 0)")]
    public decimal? Otherchargesid { get; set; }

    [Column("charges", TypeName = "numeric(18, 2)")]
    public decimal? Charges { get; set; }

    [Column("gstpercent", TypeName = "numeric(18, 2)")]
    public decimal? Gstpercent { get; set; }

    [Column("gstamount", TypeName = "numeric(18, 2)")]
    public decimal? Gstamount { get; set; }

    [Column("totalcharges", TypeName = "numeric(18, 2)")]
    public decimal? Totalcharges { get; set; }
}
