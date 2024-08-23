using System.ComponentModel.DataAnnotations;

/// <summary>
/// Data Transfer Object for Product.
/// </summary>
public class ProductDto
{
    /// <summary>
    /// Gets or sets the ID of the product.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the product.
    /// </summary>
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the description of the product.
    /// </summary>
    [StringLength(500)]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the price of the product.
    /// </summary>
    [Range(0, 10000)]
    public decimal Price { get; set; }
}
