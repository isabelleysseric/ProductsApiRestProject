using System.Collections.Generic;

/// <summary>
/// Interface for item management service.
/// </summary>
public interface IItemService
{
    /// <summary>
    /// Gets all items.
    /// </summary>
    /// <returns>A list of all items.</returns>
    IEnumerable<string> GetAllItems();

    /// <summary>
    /// Gets an item by its ID.
    /// </summary>
    /// <param name="id">The ID of the item.</param>
    /// <returns>The item if found; otherwise, null.</returns>
    string GetItemById(int id);

    /// <summary>
    /// Adds a new item.
    /// </summary>
    /// <param name="item">The item to add.</param>
    void AddItem(ItemDto item);

    /// <summary>
    /// Updates an existing item.
    /// </summary>
    /// <param name="id">The ID of the item to update.</param>
    /// <param name="item">The updated item data.</param>
    void UpdateItem(int id, ItemDto item);

    /// <summary>
    /// Deletes an item by its ID.
    /// </summary>
    /// <param name="id">The ID of the item to delete.</param>
    void DeleteItem(int id);
}
