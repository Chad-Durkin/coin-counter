using Nancy;
using System.Collections.Generic;
using CoinCounterApp.Objects;

namespace CoinCounterApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };
            Post["/coincount"] = _ => {
                CoinCounter newChange = new CoinCounter();
                newChange.SetChange(int.Parse(Request.Form["change"]));
                newChange.CalculateChange();
                return View["coincounts.cshtml", newChange.GetCoinCounts()];
            };
        }

    }
}
