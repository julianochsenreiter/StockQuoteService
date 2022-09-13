using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StockClient.StockQuoteServiceRef
{
    public partial class CompanyInfo
    {
        public override string ToString()
        {
            return Name + " (" + Address + ")";
        }
    }
}
