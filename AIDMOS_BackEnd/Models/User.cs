using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("users")]
public partial class User
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("username")]
    [StringLength(50)]
    public string? Username { get; set; }

    [Column("password")]
    [StringLength(50)]
    public string? Password { get; set; }

    [Column("status")]
    [StringLength(50)]
    public string? Status { get; set; }

    [Column("usertype")]
    [StringLength(50)]
    public string? Usertype { get; set; }

    [Column("businessid", TypeName = "numeric(18, 0)")]
    public decimal? Businessid { get; set; }

    [Column("email")]
    [StringLength(500)]
    public string? Email { get; set; }

    [Column("mobileno")]
    [StringLength(500)]
    public string? Mobileno { get; set; }

    [ForeignKey("Businessid")]
    [InverseProperty("Users")]
    public virtual Business? Business { get; set; }

    [InverseProperty("Fkuser")]
    public virtual ICollection<Usermodulemapping> Usermodulemappings { get; set; } = new List<Usermodulemapping>();
}
