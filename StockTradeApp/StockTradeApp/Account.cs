using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradeApp
{
    /// <summary>
    /// Stock trading account
    /// </summary>
    class Account
    {
        #region
        /// <summary>
        /// Unique account number 
        /// </summary>
        public int AccountNumber { get; private set; }
        /// <summary>
        /// Email address of the account holder
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Account Current Balance
        /// </summary>
        public decimal Balance { get; private set; }
        
        public DateTime dateTime { get; private set; }

        #endregion

    }
}
