using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StockQuoteService
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "IStockService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface IStockService
    {
        [OperationContract]
        decimal GetQuote(string symbol);
    }
}
