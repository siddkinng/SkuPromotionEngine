using PromotionEngine.BusinessLogic;
using PromotionEngine.Model;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class Program
    {
        private static IPriceCalculation _priceCalculation;

        public Program(IPriceCalculation priceCalculation)  //injecting the dependency via constructor
        {
            _priceCalculation = priceCalculation;
        }
        static void Main(string[] args)
        {
            List<Sku> skulist = new List<Sku>(); //list to hold the skuIds

            //taking input
            Console.WriteLine("How many items you want to order?");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Please enter the SkuId (A,B,C,D)");
                string skuId = Console.ReadLine();
                Sku sku = new Sku(skuId);
                skulist.Add(sku);
            }

            Ipromotion promotion = new Promotions();
            IPriceCalculation priceCalculation = new PriceCalculation(promotion);
            var program = new Program(priceCalculation);

            //Main Operation
            var total = _priceCalculation.GetTotalPrice(skulist);

            //Output
            Console.WriteLine("Total price of the Items added in the cart is :"+total);
            Console.ReadLine();
        }
    }
}
