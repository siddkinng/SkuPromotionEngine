using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Model
{
    public class Sku
    {
        public string SkuId { get; set; }
        public SkuUnitPrice unitPrice { get; set; }

        public Sku(string skuid)
        {
            SkuId = skuid;

            switch (SkuId)
            {
                case "A":
                    unitPrice = SkuUnitPrice.A;
                    break;

                case "B":
                    unitPrice = SkuUnitPrice.B;
                    break;

                case "C":
                    unitPrice = SkuUnitPrice.C;
                    break;

                case "D":
                    unitPrice = SkuUnitPrice.D;
                    break;
            }
        }
    }

    public enum SkuUnitPrice
    {
        A = 50,
        B = 30,
        C = 20,
        D = 15
    }
}
