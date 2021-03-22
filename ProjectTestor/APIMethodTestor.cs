using APIHome.Controllers;
using HAA.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Http;
using System.Web.Http.Results;

namespace Testor
{
    [TestClass]
    public class APIMethodTestor
    {

        public APIMethodTestor()
        {
            DependencyInjection.InjectTypes();
        }

        [TestMethod]
        public void TestLookupNameGoodData()
        {
            //arrange
            APIController api = new APIController();
            //act
            decimal lat = (decimal)-123.3646335;
            decimal lang = (decimal)48.4251378;
            var api_result = api.LookupName(lat, lang);
            var result = api_result as OkNegotiatedContentResult<string>;
            string name = result.Content;
            //assert
            Assert.IsTrue(name == "Downtown Victoria/Vic West");
        }

        [TestMethod]
        public void TestLookupNameBadData()
        {
            //arrange
            APIController api = new APIController();
            //act
            decimal lat = (decimal)-123.3646335;
            decimal lang = (decimal)148.4251378;
            var api_result = api.LookupName(lat, lang);
            var result = api_result as OkNegotiatedContentResult<Exception>;
            string name = result.Content.Message;
            //assert
            Assert.IsTrue(name == "Name not found.");
        }

        [TestMethod]
        public void GetRequestCountGood()
        {
            //arrange
            APIController api = new APIController();
            //act
            var api_result = api.GetRequestCount("https_openmaps_gov_bc_ca_geo_pub_ows", "LookupName");
            var result = api_result as OkNegotiatedContentResult<int>;
            int count = result.Content;
            //assert
            Assert.IsTrue(count > 0);
        }


    }
}
