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
        private Ipromotion _ipromotion;

        public PriceCalculation(Ipromotion ipromotion)  //DI of promotion service
        {
            _ipromotion = ipromotion;
        }

        public double GetTotalPrice(List<Sku> skus)
        {
            var skuA = skus.Where(x => x.SkuId == "A").Count();
            var skuB = skus.Where(x => x.SkuId == "B").Count();
            var skuC = skus.Where(x => x.SkuId == "C").Count();
            var skuD = skus.Where(x => x.SkuId == "D").Count();

            Ipromotion promotion = new Promotions();
            var calculation = new PriceCalculation(promotion);
            var priceOfAB = _ipromotion.Promotion1(skuA, skuB);  //using the dependency - promotion
            var priceOfCD = _ipromotion.Promotion2(skuC, skuD);  //using the dependency - promotion

            return priceOfAB + priceOfCD;
        }
    }
}
