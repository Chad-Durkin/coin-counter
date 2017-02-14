using Xunit;
using System;
using System.Collections.Generic;
using CoinCounterApp.Objects;

namespace CoinCounterAppTest
{
    public class CoinCountAppTest
    {
        [Fact]
        public void  CoinCounter_ChangeDivision_ChangeGiven()
        {
            //Arrange
                int newChange = 15;
                CoinCounter newCoinCounter = new CoinCounter();

            //Act
            newCoinCounter.SetChange(newChange);
            //Assert
            Assert.Equal(newChange, newCoinCounter.GetChange());
        }
        [Fact]
        public void CoinCounter_CalculateChange_CorrectChange()
        {
            //Arrange
            CoinCounter newCoinCounter = new CoinCounter();
            int newChange = 97;
            newCoinCounter.SetChange(newChange);

            Dictionary<string, int> expectedChange = new Dictionary<string, int>()
            {
                {"Quarter", 3},
                {"Dime", 2},
                {"Nickel", 0},
                {"Penny", 2}
            };

            //Act
            newCoinCounter.CalculateChange();

            //Assert
            foreach(KeyValuePair<string, int> coin in expectedChange)
            {
                Assert.Equal(expectedChange[coin.Key], newCoinCounter.GetCoinCounts()[coin.Key]);
            }
        }
    }
}
