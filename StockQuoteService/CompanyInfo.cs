using System.Runtime.Serialization;

namespace StockQuoteService
{
    [DataContract]
    public class CompanyInfo
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember] public string Address { get; set; }

        public override string ToString()
        {
            return Name + " (" + Address + " )";
        }
    }
}