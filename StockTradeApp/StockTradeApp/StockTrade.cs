using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradeApp
{
    static class StockTrade
    {
        public static Account CreateAccount(string EmailAddress, decimal InitialAmount=0.0M)
        {
            var account = new Account
            {
                EmailAddress = "test1@test.co"
            };
            if (InitialAmount > 0)
            {
                account.TransferTo(InitialAmount);
            }
            return account;
        }

    }
}
