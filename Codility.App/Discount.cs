namespace ECommerce;

public abstract class Discount {    
    public static DefaultDicount NoDiscount() => new DefaultDicount();
    public virtual decimal Apply(List<Product> products) {
        return 0;
    }
}
