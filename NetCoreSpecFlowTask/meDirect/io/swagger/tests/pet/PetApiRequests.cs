using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;

namespace NetCoreSpecFlowTask.meDirect.io.swagger.tests.pet
{
    [TestClass]
    public class PetApiRequests
    {
        /*
         * Given accept type is json
         * When user sends post request to pet endpoint with following body
         *  id = 5461
         *  name = "Arwen"
         *  category = "Cat"
         * Then response status code must be 200 (OK)
         * And body is json format
         */
        [TestMethod]
        public void PetPost()
        {
            // Base url
            var client = new RestClient("https://petstore.swagger.io/v2/pet/");
            // Request path
            var request = new RestRequest("", Method.Post);
            // Request body
            request.AddJsonBody(new
            {
                id = 5461,
                category = new
                {
                    id = 1,
                    name = "Cat"
                },
                name = "Arwen",
                photoUrls = new string[] { "https://www.instagram.com/p/CJoerBBj3Jj/?igshid=YmMyMTA2M2Y=" },
                tags = new[]
                {
                    new
                    {
                        id = 1,
                        name = "cat"
                    }
                },
                status = "available"
            });
            // Request headers
            request.AddHeader("accept", "application/json");
            // Execute request
            var content = client.ExecuteAsync(request);
            
            // Assert response status code
            Assert.AreEqual(HttpStatusCode.OK, content.Result.StatusCode);
            
            // Assert response body
            Assert.AreEqual("application/json", content.Result.ContentType);
        }
        
        /*
         * Given accept type is json
         * And path parameter 1
         * When user sends get request to findByStatus endpoint
         * Then response status code must be 200 (OK)
         * And body is json format
         */
        [TestMethod]
        public void PetGet()
        {
            // Base url
            var client = new RestClient("https://petstore.swagger.io/v2/pet/");
            
            // Request path
            var request = new RestRequest("{petId}", Method.Get);

            // Request parameters
            request.AddUrlSegment("petId", 5461);
            
            // Request headers
            request.AddHeader("accept", "application/json");
            
            // Execute request
            var content = client.ExecuteAsync(request);
            
            // Assert response status code
            Assert.AreEqual(HttpStatusCode.OK, content.Result.StatusCode);
            
            // Assert response body
            Assert.AreEqual("application/json", content.Result.ContentType);
            Console.WriteLine(content.Result.Content);
        }
        


        /*
         * Given accept type is json
         * When user sends put request to update pet endpoint with following body
         *  id = 5461
         *  name = "Arwen"
         *  category = "Cat"
         * Then response status code must be 200 (OK)
         * And body is json format
         */
        [TestMethod]
        public void PetPut()
        {
            // Base url
            var client = new RestClient("https://petstore.swagger.io/v2/pet/");
            // Request path
            var request = new RestRequest("", Method.Put);
            // Request body
            request.AddJsonBody(new
            {
                id = 5461,
                category = new
                {
                    id = 1,
                    name = "Cat"
                },
                name = "Arwen2",
                photoUrls = new string[] { "https://www.instagram.com/p/CJoerBBj3Jj/?igshid=YmMyMTA2M2Y=" },
                tags = new[]
                {
                    new
                    {
                        id = 1,
                        name = "cat"
                    }
                },
                status = "available"
            });
            // Request headers
            request.AddHeader("accept", "application/json");
            // Execute request
            var content = client.ExecuteAsync(request);
            
            // Assert response status code
            Assert.AreEqual(HttpStatusCode.OK, content.Result.StatusCode);
            
            // Assert response body
            Assert.AreEqual("application/json", content.Result.ContentType);
        }
        

        [TestMethod]
        public void PetDelete()
        {
            // Base url
            var client = new RestClient("https://petstore.swagger.io/v2/pet/");
            // Request path
            var request = new RestRequest("{petId}", Method.Delete);
            // Request parameters
            request.AddUrlSegment("petId", 1);
            // Request headers
            request.AddHeader("accept", "application/json");
            // Execute request
            var content = client.ExecuteAsync(request);
            // Assert response status code
            Assert.AreEqual(HttpStatusCode.OK, content.Result.StatusCode);
            // Assert response body
            Assert.AreEqual("application/json", content.Result.ContentType);
            
        }

        
        /*
         * Given accept type is Json
         * And path parameters are "status" and "available"
         * When user sends get request to findByStatus endpoint
         * Then response status code must be 200 (OK)
         * And body is json format
         * And json data has following
         *     "id": 9223372036854014000
         *     "name": "Doggie",
         *     "status": "available",
         */
        [TestMethod]
        public void PetRequestAssertion()
        {
            // Base url
            var client = new RestClient("https://petstore.swagger.io/v2/pet/");
            // Request path
            var request = new RestRequest("findByStatus", Method.Get);
            // Request path parameters
            request.AddQueryParameter("status", "available");
            // Request headers
            request.AddHeader("accept", "application/json");
            // Execute request
            var content = client.ExecuteAsync(request);
            
            // Assert response status code
            Assert.AreEqual(HttpStatusCode.OK, content.Result.StatusCode);
            
            // Assert response body
            Assert.AreEqual("application/json", content.Result.ContentType);
            
            
            // Assert json data
            var json = JsonConvert.DeserializeObject<dynamic>(content.Result.Content);
            Assert.AreEqual(9223372036854014000, json.id);
            Assert.AreEqual("Doggie", json.name);
            Assert.AreEqual("available", json.status);
        }
    }
}