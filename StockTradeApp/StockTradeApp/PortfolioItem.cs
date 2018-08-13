using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradeApp
{
    class PortfolioItem
    {
        #region Properties
        public int Quantity { get; set; }
        public string StockSymbol { get; set; }
        public decimal Balance { get; set; }
        #endregion

        #region methods
        public PortfolioItem(string Symbol, int Qty, decimal Amount)
        {
            StockSymbol = Symbol;
            Quantity = Qty;
            Balance = Amount;
        }
        #endregion
    }
}
