using NUnit.Framework;
using System;
using System.Net;

namespace LeeSoft.TestUtils.CustomWebRequest
{
    [TestFixture]
    public class ExampleTest
    {
        [Test]
        public void CanRequestData()
        {
            const string testUri = "http://api.somesite.com/Traffic/thing.ashx?Action=GetSecurityToken";
            const string expectedResponse = "<thing>Some data</thing>";

            WebRequest.RegisterPrefix(testUri, new CustomWebRequest());
            CustomWebRequest.CreateRequestWithResponse(expectedResponse);

            var sut = new ExampleClass();
            var data = sut.RequestData(new Uri(testUri));

            Assert.AreEqual(expectedResponse, data);
        }
    }
}
