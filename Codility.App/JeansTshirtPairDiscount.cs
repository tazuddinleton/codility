namespace ECommerce;

public class JeansTshirtPairDiscount: Discount {
    public override decimal Apply(List<Product> products)
    {
        decimal discount = 0.0M;
        int j = 0;
        int t = 0;

        foreach(var p in products) {
            if (p.Label.ToLower().Contains("jeans")) {
                j++;
            } 
            if (p.Label.ToLower().Contains("shirt")) {
                t++;
            }            
            if (t > 1 && j > 1) {
                discount += 15;
                t -= 2;
                j -= 2;
            }
        }
        return discount;
    }
}
