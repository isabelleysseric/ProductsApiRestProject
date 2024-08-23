using System.ComponentModel.DataAnnotations;

/// <summary>
/// Data Transfer Object for Item.
/// </summary>
public class ItemDto
{
    /// <summary>
    /// Gets or sets the ID of the item.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the item.
    /// </summary>
    [Required]
    public string Name { get; set; }
}
