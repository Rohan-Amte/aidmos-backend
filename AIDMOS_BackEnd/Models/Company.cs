using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("companies")]
public partial class Company
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("name")]
    [StringLength(500)]
    public string? Name { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
