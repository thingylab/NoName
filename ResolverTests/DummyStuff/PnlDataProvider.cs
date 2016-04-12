using System;
using System.Collections.Generic;
using System.Linq;

namespace DummyStuff
{
    public class PnlDataProvider
    {
        public IEnumerable<PnlItem> GetData(DateTime asOfDate)
        {
            var rnd = new Random();

            return Enumerable
                .Range(0, 50)
                .Select(i => new PnlItem
                {
                    PortfolioName = Guid.NewGuid().ToString(),
                    YtdPnl = (decimal)rnd.NextDouble()
                });
        }
    }
}