﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SQLDbToEFcModel.Models;

public partial class Product
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<ProductOrder> ProductOrders { get; set; } = new List<ProductOrder>();
}
