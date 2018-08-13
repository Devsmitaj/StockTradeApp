using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradeApp
{
    class Transaction
    {
        public enum TransactionType { BUY, SELL };
        #region Properties
        public DateTime TransactionDate { get; set; }
        public int Quantity { get; set; }
        public Stock TradedStock;
        public decimal Price { get; set; }
        public decimal Amount { get { return Quantity * Price; } }
        public TransactionType Type { get; set; }
        public decimal InitialAmount { get; set; }
        #endregion

        #region Method

        public bool Buy (Stock StockToBuy, int Qty, DateTime Date, List<PortfolioItem> Portfolio)
        {
            bool Completed = true;
            TradedStock = StockToBuy;
            Quantity = Qty;
            Price = StockToBuy.CurrentPrice;
            TransactionDate = Date;
            Type = TransactionType.BUY;

            PortfolioItem Pi = new PortfolioItem(StockToBuy.SymbolName, Qty, this.Amount);
            Portfolio.Add(Pi);
            return Completed;
        }
        public bool Sell (Stock StockToSell, int Qty, decimal StockPrice, DateTime Date, List<PortfolioItem> Portfolio)
        {
            bool Completed = true;
            TradedStock = StockToSell;
            Quantity = Qty;
            Price = StockPrice;
            TransactionDate = Date;
            Type = TransactionType.SELL;
            return Completed;
        }
        public bool Deposit (Account Acct, decimal Amount)
        {
            bool Completed = true;
            Acct.Deposit(Amount);
            return Completed;

        }
        #endregion
    }
}
