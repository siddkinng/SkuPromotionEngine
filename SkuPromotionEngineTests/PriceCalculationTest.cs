using PromotionEngine.BusinessLogic;
using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace SkuPromotionEngineTests
{
    public class PriceCalculationTest
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var promotions = new Promotions();
            PriceCalculation priceCalculation = new PriceCalculation(promotions);
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
            //Act
            priceCalculation.GetTotalPrice(skulist);
            //Assert
            Assert.NotNull(priceCalculation);
            //Assert.Equal();

        }
    }
}
