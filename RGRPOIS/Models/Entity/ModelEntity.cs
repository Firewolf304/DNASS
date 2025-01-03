﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RGRPOIS.Helpers.Models;

[Table("Models")]
public class ModelEntity
{
    [Key] public int Id { get; set; }

    [Required]
    public int ProductId { get; set; }
    public ProductEntity? Product { get; set; } = null!;

    [Required]
    public string Model { get; set; } = "";

    [Required]
    public int Quantity { get; set; } = 0;

    public IEnumerable<OrderItemEntity> OrderItems { get; set; } = null!;
}
