using System.Xml.Linq;

namespace LeeSoft.TestUtils.SimpleProxy
{
    public class ConcreteService: IService
    {
        protected IServiceProxy ServiceProxy;

        public ConcreteService(IServiceProxy serviceProxy)
        {
            ServiceProxy = serviceProxy;
        }

        public XDocument GetData()
        {
            return ServiceProxy.Load();
        }
    }
}
 