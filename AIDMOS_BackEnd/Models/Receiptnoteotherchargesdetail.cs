using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("receiptnoteotherchargesdetails")]
public partial class Receiptnoteotherchargesdetail
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("receiptnoteid", TypeName = "numeric(18, 0)")]
    public decimal? Receiptnoteid { get; set; }

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

    [ForeignKey("Receiptnoteid")]
    [InverseProperty("Receiptnoteotherchargesdetails")]
    public virtual Receiptnote? Receiptnote { get; set; }
}
