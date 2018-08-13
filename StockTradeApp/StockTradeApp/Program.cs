using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradeApp
{
    class Program
    {
        public List<PortfolioItem> portfolio = new List<PortfolioItem>();
        
        static void Main(string[] args)
        {
            /*var account = StockTrade.CreateAccount("test1@test.co");
            Console.WriteLine($"Account Number:{ account.AccountNumber},"+
                $"Balance:{account.Balance},"+
                $"Email address: {account.EmailAddress},"+
                $"Create Date:{account.CreatedDate}");
        
        */
            List<Transaction> transactions = new List<Transaction>();

            User Person = new User();
            string UserId;
            Console.WriteLine("Enter User Id: ");
            UserId=Console.ReadLine();

            string Password;
            Console.WriteLine("Enter Password: ");
            Password = Console.ReadLine();

            string FirstName;
            Console.WriteLine("Enter First Name: ");
            FirstName = Console.ReadLine();
            
            string LastName;
            Console.WriteLine("Enter Last Name: ");
            LastName = Console.ReadLine();

            DateTime DOB;
            Console.WriteLine("Enter Date of Birth: ");
            DOB = DateTime.Parse(Console.ReadLine());

            string Address;
            Console.WriteLine("Enter Address: ");
            Address = Console.ReadLine();

            Person.Register(UserId, Password, FirstName, "", LastName, DOB, Address);
            Console.WriteLine("Registered " + Person.FirstName + " " + Person.LastName + " DOB = " + Person.DateOfBirth + " Address = " + Person.Address);

            Account Acct = StockTrade.CreateAccount(Person);
            Console.WriteLine(Person.FirstName+" "+ Person.LastName+ " opened a stock trading account.");
            Console.WriteLine("Current Balance: " + Acct.Balance);
            Acct.Deposit(1000M);
            Console.WriteLine("Current Balance: "+Acct.Balance);

            Stock Microsoft = new Stock(CompanySymbol.MSFT, "Microsoft", 100M);
            Console.WriteLine(Microsoft.CompanyName + "(" + Microsoft.SymbolName + ") at $" + Microsoft.CurrentPrice);

            Stock Google = new Stock(CompanySymbol.GOOGL, "Google", 1000M);
            Console.WriteLine(Google.CompanyName + "(" + Google.SymbolName + ") at $" + Google.CurrentPrice);

            Stock Facebook = new Stock(CompanySymbol.FB, "Facebook", 150M);
            Console.WriteLine(Facebook.CompanyName + "(" + Facebook.SymbolName + ") at $" + Facebook.CurrentPrice);

            List<PortfolioItem> Portfolio = new List<PortfolioItem>();

            Transaction Trade1 = new Transaction();
            Trade1.Buy(Microsoft, 10, DateTime.Now, Portfolio);
            Console.WriteLine("Bought " + Trade1.Quantity + " units" + " of " + Trade1.TradedStock.SymbolName + " for $" + Trade1.Price + " each.");
            transactions.Add(Trade1);


            Transaction Trade2 = new Transaction();
            Trade2.Buy(Google, 20, DateTime.Now, Portfolio);
            Console.WriteLine("Bought " + Trade2.Quantity + " units" + " of " + Trade2.TradedStock.SymbolName + " for $" + Trade2.Price + " each.");
            transactions.Add(Trade2);

            Transaction Trade3 = new Transaction();
            Trade3.Buy(Facebook, 30, DateTime.Now, Portfolio);
            Console.WriteLine("Bought " + Trade3.Quantity + " units" + " of " + Trade3.TradedStock.SymbolName + " for $" + Trade3.Price + " each.");
            transactions.Add(Trade3);

            Transaction Cash = new Transaction();
            Cash.Deposit(Acct, 2000M);
            transactions.Add(Cash);
            Console.WriteLine("Desposited Cash= " + Acct.Balance);
            Console.WriteLine("Total Transactions = " + transactions.Count);


            Console.WriteLine(Person.FirstName + " has a portfolio of total " + Portfolio.Count + " items.");

            Decimal TotalBalance = Portfolio[0].Balance + Portfolio[1].Balance + Portfolio[2].Balance;
            Console.WriteLine("Total Balance = $" + TotalBalance);

            Console.ReadKey();

        }
    }
}
