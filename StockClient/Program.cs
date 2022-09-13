using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockClient.StockQuoteServiceRef;

namespace StockClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StockServiceClient client = new StockServiceClient())
            {
                decimal quote = client.GetQuote("msft");
                Console.WriteLine(quote);

                CompanyInfo info = client.GetInfo("msft");
                Console.WriteLine(info);
            }
        }
    }
}
