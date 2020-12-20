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
            List<Sku> skulist = new List<Sku>()
            {
              new Sku("A"),
              new Sku("A"),
              new Sku("A"),
              new Sku("B"),
              new Sku("B"),
              new Sku("C"),
              new Sku("D"),
            };
            IPriceCalculation priceCalculation = new PriceCalculation();

            var program = new Program(priceCalculation);

            var total = _priceCalculation.GetTotalPrice(skulist);
            Console.WriteLine("Total price of the Items added in the cart is :"+total);

            Console.ReadLine();
        }
    }
}
