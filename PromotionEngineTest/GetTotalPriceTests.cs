using PromotionEngine.BusinessLogic;
using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace PromotionEngineTest
{
    public class GetTotalPriceTests
    {
        [Fact]
        public void GetTotalPrice_Test()
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
            var response = priceCalculation.GetTotalPrice(skulist);
            //Assert
            Assert.NotNull(response);
            Assert.Equal(210, response);
        }

        [Fact]
        public void GetTotalPrice_AB()
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
          
            };
            //Act
            var response = priceCalculation.GetTotalPrice(skulist);
            //Assert
            Assert.NotNull(response);
            Assert.Equal(175, response);
        }
    }
}
