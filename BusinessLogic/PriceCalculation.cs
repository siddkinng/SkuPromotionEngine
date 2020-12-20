using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.BusinessLogic
{
    public interface IPriceCalculation
    {
        double GetTotalPrice(List<Sku> skus);
    }
   public class PriceCalculation
    {
    }
}
