using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradeApp
{   enum CompanySymbol {MSFT, FB, GOOGL};
    class Stock
    {
        #region Properties
        public String SymbolName { get; set; }
        public String CompanyName { get; set; }
        public decimal CurrentPrice { get; set; }
        #endregion

        #region Method
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public Stock (CompanySymbol Symbol, String Company,decimal Price)
          {
            if (Symbol == CompanySymbol.MSFT)
                SymbolName = "MSFT";
            if (Symbol == CompanySymbol.GOOGL)
                SymbolName = "GOOGL";
            if (Symbol == CompanySymbol.FB)
                SymbolName = "FB";
            CompanyName = Company;
            CurrentPrice = Price;
        }
        #endregion
    }

}
