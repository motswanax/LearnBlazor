﻿using System.ComponentModel.DataAnnotations;

namespace LearnBlazor.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public bool IsActive { get; set; }

    [Range(1, 1000)]
    public decimal Price { get; set; }
    public List<ProductProp> ProductProperties { get; set; }

    public Category Category { get; set; }
    public DateOnly AvailableAfter { get; set; }
}

public enum Category
{
    Entree,
    Appetizer,
    Dessert
}
