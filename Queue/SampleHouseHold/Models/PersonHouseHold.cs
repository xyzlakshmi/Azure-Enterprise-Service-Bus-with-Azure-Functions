using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleHouseHold.Models
{
    public class HouseHold
    {
        public string StudentPersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string HouseHoldID { get; set; }
        public string HouseHoldGuardian { get; set; }
        public string HouseHoldLegalGuardian { get; set; }
    }
}