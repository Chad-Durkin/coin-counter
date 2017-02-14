using System.Collections.Generic;
using System;

namespace CoinCounterApp.Objects
{
    public class CoinCounter
    {
        private int _change;

        //Types of coins, and how many coins
        private Dictionary<string, int> _coinCounts = new Dictionary<string, int>(){};

        //Types of coins and their values
        private Dictionary<string, int> _coinValues = new Dictionary<string, int>()
        {
            {"Quarter", 25},
            {"Dime", 10},
            {"Nickel", 5},
            {"Penny", 1}
        };
        public int GetChange()
        {
            return _change;
        }
        public void SetChange(int newChange)
        {
            _change = newChange;
        }
        public Dictionary<string, int> GetCoinCounts()
        {
            return _coinCounts;
        }
        public Dictionary<string, int> GetCoinValues()
        {
            return _coinValues;
        }
        public void CalculateChange()
        {
            foreach(KeyValuePair<string, int> coin in _coinValues)
            {
                _coinCounts[coin.Key] = (_change/_coinValues[coin.Key]);
                _change -= _coinCounts[coin.Key] * _coinValues[coin.Key];
            }
        }

    }
}
