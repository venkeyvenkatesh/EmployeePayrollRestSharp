using NUnit.Framework;
using RestSharp;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

            RestClient client = new RestClient("http://localhost:3000");
        }

        [Test]

        public void GetTheRecords()
        {

            IRestResponse response = getEmployeeList();

            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);

            List<Emp> dataresponse = JsonConvert.DeserializeObject<List<Emp>>(response.Content);

            Assert.AreEqual(4, dataresponse.Count);
        }

        private IRestResponse getEmployeeList()
        {
            RestRequest request = new RestRequest("/employee", Method.GET);

            IRestResponse response = client.Execute(request);

            return response;
        }
    }
}