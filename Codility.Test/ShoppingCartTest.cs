
using Xunit;

namespace ECommerce;

public class ShoppingCartTest
{
    [Fact]
    public void ShouldAddProductToShoppingCartWhenGivenProduct()
    {        
        var cart = new ShoppingCart();
        var productA = new Product("Product A", 1.0M);

        var productB = new Product("Product B", 2.0M);

        cart.AddProduct(productA);
        cart.AddProduct(productB);

        Assert.Equal(2, cart.GetProducts().Count);        
    }

    [Fact]
    public void ShouldGetTotalPriceOfTheProductsInShoppingCart()
    {        
        var cart = new ShoppingCart();
        var tshirt = new Product("T-shirt", 10M);

        var jeans = new Product("Jeans", 20M);

        cart.AddProduct(tshirt);
        cart.AddProduct(jeans);

        Assert.Equal(30M, cart.Total(Discount.NoDiscount()));        
    }



    [Fact]
    public void ShouldApplyDiscountsToJeans()
    {        
        var cart = new ShoppingCart();
        var tshirt = new Product("T-shirt", 10M);

        cart.AddProduct(tshirt);
        cart.AddProduct(new Product("Jeans", 20M));
        cart.AddProduct(new Product("Jeans", 20M));
        cart.AddProduct(new Product("Jeans", 20M));

        Assert.Equal(50M, cart.Total(new JeansDiscount()));        
    }



    [Fact]
    public void ShouldApplyDiscountsToEverySecondPairOfJeansAndTshirt()
    {        
        var cart = new ShoppingCart();
        
        cart.AddProduct(new Product("T-shirt", 10M));
        cart.AddProduct(new Product("T-shirt", 10M));
        cart.AddProduct(new Product("T-shirt", 10M));
        
        cart.AddProduct(new Product("Jeans", 20M));
        cart.AddProduct(new Product("Jeans", 20M));
        cart.AddProduct(new Product("Jeans", 20M));

        Assert.Equal(75M, cart.Total(new JeansTshirtPairDiscount()));        
    }

}