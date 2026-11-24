using Products.Models;
using Xunit;

namespace Products.Tests;

public class ProductTests
{
    [Fact]
    public void Product_ShouldStoreNameAndPrice()
    {
        // Arrange
        var product = new Product
        {
            Name = "Milk",
            Price = 32.0m
        };

        // Assert
        Assert.Equal("Milk", product.Name);
        Assert.Equal(32.0m, product.Price);
    }
}
