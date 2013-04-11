using Crowbar.Tests.Mvc.Common;
using NUnit.Framework;

namespace Crowbar.Tests.Web.Core
{
    public class XmlBodyTests : TestBase
    {
        [TestCase("DELETE")]
        [TestCase("POST")]
        [TestCase("PUT")]
        public void Should_be_able_to_send_xml(string method)
        {
            Application.Execute(client =>
            {
                var response = client.PerformRequest(method, CrowbarRoute.XmlBody, x => x.XmlBody(new Payload{ Text = "text" }));
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            });            
        }
    }
}