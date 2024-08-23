using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

/// <summary>
/// Controller responsible for managing product-related operations.
/// It handles CRUD (Create, Read, Update, Delete) operations on products.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductsController"/> class.
    /// </summary>
    /// <param name="productService">The service to manage products.</param>
    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    /// <summary>
    /// Gets all products.
    /// </summary>
    /// <returns>A list of all products.</returns>
    [HttpGet]
    public ActionResult<IEnumerable<ProductDto>> Get()
    {
        var products = _productService.GetAllProducts();
        return Ok(products);
    }

    /// <summary>
    /// Gets a specific product by its ID.
    /// </summary>
    /// <param name="id">The ID of the product to retrieve.</param>
    /// <returns>The requested product.</returns>
    [HttpGet("{id}")]
    public ActionResult<ProductDto> Get(int id)
    {
        var product = _productService.GetProductById(id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    /// <summary>
    /// Adds a new product.
    /// </summary>
    /// <param name="product">The product to add.</param>
    /// <returns>The newly created product.</returns>
    [HttpPost]
    public ActionResult<ProductDto> Post([FromBody] ProductDto product)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _productService.AddProduct(product);
        return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
    }

    /// <summary>
    /// Updates an existing product.
    /// </summary>
    /// <param name="id">The ID of the product to update.</param>
    /// <param name="product">The updated product data.</param>
    /// <returns>An IActionResult indicating the result of the operation.</returns>
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] ProductDto product)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var existingProduct = _productService.GetProductById(id);
        if (existingProduct == null)
        {
            return NotFound();
        }

        _productService.UpdateProduct(id, product);
        return NoContent();
    }

    /// <summary>
    /// Deletes a product by its ID.
    /// </summary>
    /// <param name="id">The ID of the product to delete.</param>
    /// <returns>An IActionResult indicating the result of the operation.</returns>
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var existingProduct = _productService.GetProductById(id);
        if (existingProduct == null)
        {
            return NotFound();
        }

        _productService.DeleteProduct(id);
        return NoContent();
    }
}
