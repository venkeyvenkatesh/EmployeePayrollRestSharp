using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharpEmployeePayRoll;
using System;
using System.Collections.Generic;
using System.Net;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        RestClient client = new RestClient("http://localhost:3000");

        [TestMethod]
        public void GetTheRecords()
        {

            IRestResponse response = getEmployeeList();

            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);

            List<Employee> dataresponse = JsonConvert.DeserializeObject<List<Employee>>(response.Content);

            Assert.AreEqual(6, dataresponse.Count);

            Console.WriteLine(response.Content);
        }

        private IRestResponse getEmployeeList()
        {
            RestRequest request = new RestRequest("/employee", Method.GET);

            IRestResponse response = client.Execute(request);

            return response;
        }

    }
}