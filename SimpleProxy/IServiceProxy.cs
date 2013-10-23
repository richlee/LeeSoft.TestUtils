using System.Xml.Linq;

namespace LeeSoft.TestUtils.SimpleProxy
{
    public interface IServiceProxy
    {
        XDocument Load();
    }
}