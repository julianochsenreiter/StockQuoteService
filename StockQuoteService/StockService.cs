using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StockQuoteService
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "StockService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class StockService : IStockService
    {
        public CompanyInfo GetInfo(string symbol)
        {
            if (symbol.ToLower() == "msft")
                return new CompanyInfo
                {
                    Name = "Microsoft Corporation",
                    Address = "One Microsoft Way, 97852 Redmond"
                };
            if (symbol.ToLower() == "goog")
                return new CompanyInfo
                {
                    Name = "Alphabet Inc.",
                    Address = "99 Google Boulevard, 2341 Palo Alto"
                };
            return null;
        }

        public decimal GetQuote(string symbol)
        {
            if (symbol.ToLower() == "msft")
                return 266.65m;
            if (symbol.ToLower() == "goog")
                return 111.87m;
            return 123.123m;
        }
    }
}
