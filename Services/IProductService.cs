using System.Collections.Generic;

/// <summary>
/// Interface for product management service.
/// </summary>
public interface IProductService
{
    /// <summary>
    /// Gets all products.
    /// </summary>
    /// <returns>A list of all products.</returns>
    IEnumerable<ProductDto> GetAllProducts();

    /// <summary>
    /// Gets a product by its ID.
    /// </summary>
    /// <param name="id">The ID of the product.</param>
    /// <returns>The product if found; otherwise, null.</returns>
    ProductDto GetProductById(int id);

    /// <summary>
    /// Adds a new product.
    /// </summary>
    /// <param name="product">The product to add.</param>
    void AddProduct(ProductDto product);

    /// <summary>
    /// Updates an existing product.
    /// </summary>
    /// <param name="id">The ID of the product to update.</param>
    /// <param name="product">The updated product data.</param>
    void UpdateProduct(int id, ProductDto product);

    /// <summary>
    /// Deletes a product by its ID.
    /// </summary>
    /// <param name="id">The ID of the product to delete.</param>
    void DeleteProduct(int id);
}
