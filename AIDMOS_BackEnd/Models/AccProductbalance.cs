using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("acc_productbalances")]
public partial class AccProductbalance
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("businessid", TypeName = "numeric(18, 0)")]
    public decimal? Businessid { get; set; }

    [Column("financialyear")]
    [StringLength(50)]
    public string? Financialyear { get; set; }

    [Column("productid", TypeName = "numeric(18, 0)")]
    public decimal? Productid { get; set; }

    [Column("openingbalance", TypeName = "numeric(18, 0)")]
    public decimal? Openingbalance { get; set; }

    [Column("closingbalance", TypeName = "numeric(18, 0)")]
    public decimal? Closingbalance { get; set; }

    [Column("purchaserateavg", TypeName = "numeric(18, 2)")]
    public decimal? Purchaserateavg { get; set; }

    [Column("salerateavg", TypeName = "numeric(18, 2)")]
    public decimal? Salerateavg { get; set; }
}
