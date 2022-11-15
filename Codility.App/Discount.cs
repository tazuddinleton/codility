namespace ECommerce;

public abstract class Discount {    
    public static DefaultDiscount NoDiscount() => new DefaultDiscount();
    public virtual decimal Apply(List<Product> products) {
        return 0;
    }
}
