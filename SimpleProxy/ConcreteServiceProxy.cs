using log4net;
using System.Net;
using System.Xml.Linq;

namespace LeeSoft.TestUtils.SimpleProxy
{
    public class ConcreteServiceProxy: BaseServiceProxy
    {
        public ConcreteServiceProxy(ILog log) : base(log)
        {
            ProxyName = "ConcreteServiceProxy";
        }

        public override XDocument Load()
        {
            var client = new WebClient { Credentials = new NetworkCredential("abc", "xyz") };

            // Add a user agent header in case the requested URI contains a query.
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            var data = client.OpenRead("http://www.somedomain.com/OutgoingData/clientName/DATA.XML");

            var doc = XDocument.Load(data);

            LogReceipt(doc);

            return doc;
        }
    }
}
