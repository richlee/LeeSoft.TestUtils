using System.Xml.Linq;

namespace LeeSoft.TestUtils.SimpleProxy
{
    public interface IService
    {
        XDocument GetData();
    }
}