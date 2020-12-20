using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.BusinessLogic
{
    interface Ipromotion
    {
        double Promotion1(int a, int b);
        double Promotion2(int c, int d);
    }
    public class Promotions : Ipromotion
    {
        private static bool mutualExclusionOfPromotions = false;  //to make the promotions mutually exclusive 
        public double Promotion1(int a, int b)
        {
            var totalA = (a / 3) * Convert.ToDouble(PromotionConstants.A3) + a % 3 * Convert.ToDouble(SkuUnitPrice.A);
            var totalB = (b / 2) * Convert.ToDouble(PromotionConstants.B2) + b % 2 * Convert.ToDouble(SkuUnitPrice.B);
            mutualExclusionOfPromotions = true;

            return totalA + totalB;
        }

        public double Promotion2(int c, int d)
        {
            //flag to check if 1st promotion1  is applied or not 
            if (!mutualExclusionOfPromotions)
            {
                if (c == 1 && d == 1)
                {
                    return Convert.ToDouble(PromotionConstants.CD);
                }
                else
                {
                    var p1 = (c - 1) * Convert.ToDouble(SkuUnitPrice.C) + (d - 1) * Convert.ToDouble(SkuUnitPrice.D); //when C and D are more than 1 
                    var p2 = Convert.ToDouble(PromotionConstants.CD); //C+D= 30
                    return p1 + p2;
                }

            }

            var totalofCAndD = d * Convert.ToDouble(SkuUnitPrice.D) + c * Convert.ToDouble(SkuUnitPrice.C);
            return totalofCAndD;
        }
    }

    public enum PromotionConstants
    {
        A3 = 130,
        B2 = 45,
        CD = 30
    }
}
