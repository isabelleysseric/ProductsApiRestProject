using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

/// <summary>
/// Controller responsible for managing item-related operations.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ItemsController : ControllerBase
{
    private readonly IItemService _itemService;

    /// <summary>
    /// Constructor: Initializes a new instance of the <see cref="ItemsController"/> class.
    /// </summary>
    /// <param name="itemService">The service to manage items.</param>
    public ItemsController(IItemService itemService)
    {
        _itemService = itemService;
    }

    /// <summary>
    /// Get All Products: Gets all items.
    /// </summary>
    /// <returns>A list of all items.</returns>
    [HttpGet]
    public ActionResult<IEnumerable<ItemDto>> Get()
    {
        return Ok(_itemService.GetAllItems());
    }

    /// <summary>
    /// Get Product by ID: Gets a specific item by its ID.
    /// </summary>
    /// <param name="id">The ID of the item to retrieve.</param>
    /// <returns>The requested item.</returns>
    [HttpGet("{id}")]
    public ActionResult<ItemDto> Get(int id)
    {
        var item = _itemService.GetItemById(id);
        if (item == null)
        {
            return NotFound();
        }
        return Ok(item);
    }

    /// <summary>
    /// Add a New Product: Adds a new item.
    /// </summary>
    /// <param name="item">The item to add.</param>
    /// <returns>The newly created item.</returns>
    [HttpPost]
    public ActionResult Post([FromBody] ItemDto item)
    {
        _itemService.AddItem(item);
        return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
    }

    /// <summary>
    /// Update an Existing Product: Updates an existing item.
    /// </summary>
    /// <param name="id">The ID of the item to update.</param>
    /// <param name="item">The updated item data.</param>
    /// <returns>An IActionResult indicating the result of the operation.</returns>
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] ItemDto item)
    {
        var existingItem = _itemService.GetItemById(id);
        if (existingItem == null)
        {
            return NotFound();
        }
        _itemService.UpdateItem(id, item);
        return NoContent();
    }

    /// <summary>
    /// Delete a Product: Deletes an item by its ID.
    /// </summary>
    /// <param name="id">The ID of the item to delete.</param>
    /// <returns>An IActionResult indicating the result of the operation.</returns>
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var existingItem = _itemService.GetItemById(id);
        if (existingItem == null)
        {
            return NotFound();
        }
        _itemService.DeleteItem(id);
        return NoContent();
    }
}
