using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("purchasereturndetails")]
public partial class Purchasereturndetail
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("prid", TypeName = "numeric(18, 0)")]
    public decimal? Prid { get; set; }

    [Column("plsid", TypeName = "numeric(18, 0)")]
    public decimal? Plsid { get; set; }

    [Column("returnquantity", TypeName = "numeric(18, 0)")]
    public decimal? Returnquantity { get; set; }

    [Column("returnrate", TypeName = "numeric(18, 2)")]
    public decimal? Returnrate { get; set; }

    [Column("returndiscountpercent", TypeName = "numeric(18, 2)")]
    public decimal? Returndiscountpercent { get; set; }

    [Column("returndiscountamount", TypeName = "numeric(18, 2)")]
    public decimal? Returndiscountamount { get; set; }

    [Column("returngstpercent", TypeName = "numeric(18, 2)")]
    public decimal? Returngstpercent { get; set; }

    [Column("returngstamount", TypeName = "numeric(18, 2)")]
    public decimal? Returngstamount { get; set; }

    [Column("returntaxableamount", TypeName = "numeric(18, 2)")]
    public decimal? Returntaxableamount { get; set; }

    [Column("returntotalamount", TypeName = "numeric(18, 2)")]
    public decimal? Returntotalamount { get; set; }

    [Column("entrytype")]
    [StringLength(50)]
    public string? Entrytype { get; set; }

    [Column("returnsubtotalamount", TypeName = "numeric(18, 2)")]
    public decimal? Returnsubtotalamount { get; set; }
}
