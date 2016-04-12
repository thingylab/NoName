using System;

namespace DummyStuff
{
    public class PnlItem
    {
        public string PortfolioName{ get; set; }

        public decimal YtdPnl { get; set; }

        public override string ToString()
        {
            return string.Format("[PnlItem: PortfolioName={0}, YtdPnl={1}]", PortfolioName, YtdPnl);
        }
    }
}