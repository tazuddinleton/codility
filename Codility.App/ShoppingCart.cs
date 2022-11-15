
using System.Linq;
namespace ECommerce;

public class ShoppingCart
{
    private List<Product> _products;
    public ShoppingCart() {
        _products = new List<Product>();
    }

    public void AddProduct(Product p) {
        this._products.Add(p);
    }

    public IReadOnlyCollection<Product> GetProducts() {
        return this._products.AsReadOnly();
    }

    public decimal Total(Discount discount) {
        var total = this._products        
        .Select(p => p.Price)
        .Sum();

        var totalDiscount = discount.Apply(this._products.ToList());

        return total - totalDiscount;
    }
    
}
