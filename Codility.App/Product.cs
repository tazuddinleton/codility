namespace ECommerce;

public class Product {    
    public Product(string label, decimal price) {
        Label = label;
        Price = price;
    }
    public string Label { get; }
    public decimal Price {get; }
}