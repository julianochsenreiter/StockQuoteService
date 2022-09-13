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
