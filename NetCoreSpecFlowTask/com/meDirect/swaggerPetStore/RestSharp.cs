using System;
using RestSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace NetCoreSpecFlowTask.com.meDirect.swaggerPetStore
{
    [TestClass]
    public class RestSharp
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client = new RestClient("https://petstore.swagger.io/v2");
            var request = new RestRequest("/pet/{petId}");
            request.AddUrlSegment("petId", 10);

            var content = client.ExecuteAsync(request);
            Console.WriteLine(content.Result.Content);
        }
    }
}