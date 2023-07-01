using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("sales")]
public partial class Sale
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("businessid", TypeName = "numeric(18, 0)")]
    public decimal? Businessid { get; set; }

    [Column("financialyear")]
    [StringLength(50)]
    public string? Financialyear { get; set; }

    [Column("invoiceno", TypeName = "numeric(18, 0)")]
    public decimal? Invoiceno { get; set; }

    [Column("sdate", TypeName = "date")]
    public DateTime? Sdate { get; set; }

    [Column("ledgerid", TypeName = "numeric(18, 0)")]
    public decimal? Ledgerid { get; set; }

    [Column("subtotal", TypeName = "numeric(18, 2)")]
    public decimal? Subtotal { get; set; }

    [Column("discountamount", TypeName = "numeric(18, 2)")]
    public decimal? Discountamount { get; set; }

    [Column("gstamount", TypeName = "numeric(18, 2)")]
    public decimal? Gstamount { get; set; }

    [Column("billamount", TypeName = "numeric(18, 2)")]
    public decimal? Billamount { get; set; }

    [Column("otherchargestotal", TypeName = "numeric(18, 2)")]
    public decimal? Otherchargestotal { get; set; }

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

    [Column("referenceno")]
    [StringLength(500)]
    public string? Referenceno { get; set; }

    [Column("customername")]
    public string? Customername { get; set; }

    [Column("customeraddress")]
    public string? Customeraddress { get; set; }

    [Column("customeradharno")]
    public string? Customeradharno { get; set; }

    [Column("taxableamount", TypeName = "numeric(18, 2)")]
    public decimal? Taxableamount { get; set; }

    [Column("roundoff", TypeName = "numeric(18, 2)")]
    public decimal? Roundoff { get; set; }

    [Column("grandtotal", TypeName = "numeric(18, 2)")]
    public decimal? Grandtotal { get; set; }

    [Column("calculateroundoff")]
    [StringLength(50)]
    public string? Calculateroundoff { get; set; }

    [Column("deliverynoteid", TypeName = "numeric(18, 0)")]
    public decimal? Deliverynoteid { get; set; }

    [Column("entrytype")]
    [StringLength(50)]
    public string? Entrytype { get; set; }

    [Column("purchaseinvoicegenerated")]
    [StringLength(50)]
    public string? Purchaseinvoicegenerated { get; set; }

    [Column("saleimpactledgerid")]
    public int? Saleimpactledgerid { get; set; }

    [ForeignKey("Businessid")]
    [InverseProperty("Sales")]
    public virtual Business? Business { get; set; }

    [InverseProperty("Sale")]
    public virtual ICollection<Creditnote> Creditnotes { get; set; } = new List<Creditnote>();

    [ForeignKey("Deliverynoteid")]
    [InverseProperty("Sales")]
    public virtual Debitnote? Deliverynote { get; set; }

    [InverseProperty("Sale")]
    public virtual ICollection<Deliverynote> Deliverynotes { get; set; } = new List<Deliverynote>();

    [ForeignKey("Ledgerid")]
    [InverseProperty("Sales")]
    public virtual AccLedger? Ledger { get; set; }

    [InverseProperty("Sale")]
    public virtual ICollection<Saledetail> Saledetails { get; set; } = new List<Saledetail>();

    [InverseProperty("Sale")]
    public virtual ICollection<Saleotherchargesdetail> Saleotherchargesdetails { get; set; } = new List<Saleotherchargesdetail>();
}
