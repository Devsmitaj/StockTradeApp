using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = StockTrade.CreateAccount("test1@test.co");
            Console.WriteLine($"Account Number:{ account.AccountNumber},"+
                $"Balance:{account.Balance},"+
                $"Email address: {account.EmailAddress},"+
                $"Create Date:{account.CreatedDate}");
        }
    }
}
