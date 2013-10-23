using log4net;
using System.Globalization;
using System.Xml.Linq;

namespace LeeSoft.TestUtils.SimpleProxy
{
    public abstract class BaseServiceProxy : IServiceProxy
    {
        protected ILog Log;

        protected string ProxyName = "BaseServiceProxy";

        protected BaseServiceProxy(ILog log)
        {
            Log = log;
        }

        public abstract XDocument Load();

        protected void LogReceipt(XDocument data)
        {
            Log.Info(string.Format(CultureInfo.InvariantCulture, "Loaded data from {0}. Content: {1}", ProxyName, data));
        }
    }
}
