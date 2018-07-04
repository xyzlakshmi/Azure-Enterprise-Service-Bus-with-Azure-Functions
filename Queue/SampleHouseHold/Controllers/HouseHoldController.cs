using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using SampleHouseHold.Models;
using System.Web.Http;
using System.Web.Http.Results;


namespace SampleHouseHold.Controllers
{
    [System.Web.Http.RoutePrefix("api/HouseHold")]
    public class HouseHoldController : ApiController
    {

        // GET: HouseHold
        [System.Web.Http.Route("{DateTime}/Details")]
        [System.Web.Http.HttpGet]
        public async Task<IHttpActionResult> HouseHoldDetails(string DateTime)
        {
            var hd = new List<HouseHold>();
            HouseHold hd1 = new HouseHold
            {
                StudentPersonId = "1",
                FirstName = "Lisa",
                LastName = "Harris",
                MiddleName = "",
                HouseHoldID = "100",
                HouseHoldGuardian = "Smith",
                HouseHoldLegalGuardian = "Smith"
            };
            HouseHold hd2 = new HouseHold
            {
                StudentPersonId = "2",
                FirstName = "John",
                LastName = "Riva",
                MiddleName = "MiddleName2",
                HouseHoldID = "101",
                HouseHoldGuardian = "Dan",
                HouseHoldLegalGuardian = "Dan"
            };
            hd.Add(hd1);
            hd.Add(hd2);
            return Ok(hd);

        }
        

       
    }
}
