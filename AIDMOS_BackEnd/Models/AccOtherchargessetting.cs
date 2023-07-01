using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("acc_otherchargessettings")]
public partial class AccOtherchargessetting
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("title")]
    [StringLength(500)]
    public string? Title { get; set; }

    [Column("applytopurchase")]
    [StringLength(50)]
    public string? Applytopurchase { get; set; }

    [Column("purchaseledgerid", TypeName = "numeric(18, 0)")]
    public decimal? Purchaseledgerid { get; set; }

    [Column("purchasegstpercent", TypeName = "numeric(18, 2)")]
    public decimal? Purchasegstpercent { get; set; }

    [Column("applytosale")]
    [StringLength(50)]
    public string? Applytosale { get; set; }

    [Column("saleledgerid", TypeName = "numeric(18, 0)")]
    public decimal? Saleledgerid { get; set; }

    [Column("salegstpercent", TypeName = "numeric(18, 2)")]
    public decimal? Salegstpercent { get; set; }

    [Column("srno", TypeName = "numeric(18, 0)")]
    public decimal? Srno { get; set; }

    [Column("tosale")]
    [StringLength(50)]
    public string? Tosale { get; set; }

    [Column("topurchase")]
    [StringLength(50)]
    public string? Topurchase { get; set; }

    [ForeignKey("Purchaseledgerid")]
    [InverseProperty("AccOtherchargessettingPurchaseledgers")]
    public virtual AccLedger? Purchaseledger { get; set; }

    [ForeignKey("Saleledgerid")]
    [InverseProperty("AccOtherchargessettingSaleledgers")]
    public virtual AccLedger? Saleledger { get; set; }
}
