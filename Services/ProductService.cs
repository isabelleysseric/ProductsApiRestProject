using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Service for managing products.
/// </summary>
public class ProductService : IProductService
{
    // A simple in-memory list to store products. In a real application, this would be replaced by a database.
    private readonly List<ProductDto> _products = new List<ProductDto>
    {
        new ProductDto { Id = 1, Name = "Laptop", Description = "A powerful laptop", Price = 999.99M },
        new ProductDto { Id = 2, Name = "Smartphone", Description = "A modern smartphone", Price = 599.99M },
    };

    /// <summary>
    /// Gets all products.
    /// </summary>
    /// <returns>A list of all products.</returns>
    public IEnumerable<ProductDto> GetAllProducts()
    {
        return _products.ToList();
    }

    /// <summary>
    /// Gets a product by its ID.
    /// </summary>
    /// <param name="id">The ID of the product.</param>
    /// <returns>The product if found; otherwise, null.</returns>
    public ProductDto GetProductById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }

    /// <summary>
    /// Adds a new product.
    /// </summary>
    /// <param name="product">The product to add.</param>
    public void AddProduct(ProductDto product)
    {
        // Generate a new ID for the product
        product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1;
        _products.Add(product);
    }

    /// <summary>
    /// Updates an existing product.
    /// </summary>
    /// <param name="id">The ID of the product to update.</param>
    /// <param name="product">The updated product data.</param>
    public void UpdateProduct(int id, ProductDto product)
    {
        var existingProduct = _products.FirstOrDefault(p => p.Id == id);
        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
        }
    }

    /// <summary>
    /// Deletes a product by its ID.
    /// </summary>
    /// <param name="id">The ID of the product to delete.</param>
    public void DeleteProduct(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _products.Remove(product);
        }
    }
}
