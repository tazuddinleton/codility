namespace ECommerce;

public class JeansDiscount : Discount {     
    public override decimal Apply(List<Product> products) {
        var jeans = products.Where(x => x.Label.ToLower().Contains("jeans")).ToList();
        var discount = 0.0M;        
        for (int i = 0; i < jeans.Count(); i++) {
            if (i % 3 ==0) {
                discount += jeans[i].Price;             
            }            
        }
        return discount;
    }
}
