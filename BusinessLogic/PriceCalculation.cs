using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.BusinessLogic
{
    public interface IPriceCalculation
    {
        double GetTotalPrice(List<Sku> skus);
    }
    public class PriceCalculation : IPriceCalculation
    {
        public double GetTotalPrice(List<Sku> skus)
        {
            var skuA = skus.Where(x => x.SkuId == "A").Count();
            var skuB = skus.Where(x => x.SkuId == "B").Count();
            var skuC = skus.Where(x => x.SkuId == "C").Count();
            var skuD = skus.Where(x => x.SkuId == "D").Count();
            var promotions = new Promotions();
            var priceOfAB = promotions.Promotion1(skuA, skuB);
            var priceOfCD = promotions.Promotion2(skuC, skuD);

            return priceOfAB + priceOfCD;
        }
    }
}
