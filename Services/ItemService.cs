using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Service for managing items.
/// </summary>
public class ItemService : IItemService
{
    private readonly List<ItemDto> _items = new List<ItemDto>
    {
        new ItemDto { Id = 1, Name = "Item1" },
        new ItemDto { Id = 2, Name = "Item2" },
    };

    /// <summary>
    /// Gets all items.
    /// </summary>
    /// <returns>A list of all item names.</returns>
    public IEnumerable<string> GetAllItems()
    {
        return _items.Select(i => i.Name).ToList();
    }

    /// <summary>
    /// Gets an item by its ID.
    /// </summary>
    /// <param name="id">The ID of the item.</param>
    /// <returns>The item name if found; otherwise, null.</returns>
    public string GetItemById(int id)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        return item?.Name;
    }

    /// <summary>
    /// Adds a new item.
    /// </summary>
    /// <param name="item">The item to add.</param>
    public void AddItem(ItemDto item)
    {
        item.Id = _items.Max(i => i.Id) + 1;
        _items.Add(item);
    }

    /// <summary>
    /// Updates an existing item.
    /// </summary>
    /// <param name="id">The ID of the item to update.</param>
    /// <param name="item">The updated item data.</param>
    public void UpdateItem(int id, ItemDto item)
    {
        var existingItem = _items.FirstOrDefault(i => i.Id == id);
        if (existingItem != null)
        {
            existingItem.Name = item.Name;
        }
    }

    /// <summary>
    /// Deletes an item by its ID.
    /// </summary>
    /// <param name="id">The ID of the item to delete.</param>
    public void DeleteItem(int id)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        if (item != null)
        {
            _items.Remove(item);
        }
    }
}
