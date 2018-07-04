using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using System.Net;

using System.Threading;



namespace ConsoleApplication1
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

        public override String ToString()
        {
            return "\n{\n\tStudentPersonId : " + StudentPersonId +
                      "\n\tFirstName : " + FirstName +
                      "\n\tLastName : " + LastName +
                      "\n\tHouseHoldID : " + HouseHoldID +
                      "\n\tHouseHoldGuardian : " + HouseHoldGuardian + "\n}";
        }
    }
    class Program
    {
        static  void Main(string[] args)
        {
            using (var apiClient = new HttpClient())
            {

                apiClient.BaseAddress = new Uri("https://sample20180612014702.azurewebsites.net/api/");
                apiClient.DefaultRequestHeaders.Accept.Clear();
                apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = apiClient.GetAsync("HouseHold/1233-3/Details").Result;


                if (response.IsSuccessStatusCode)
                {
                    var queryResults = response.Content.ReadAsAsync<IEnumerable<HouseHold>>().Result.ToList();
                    foreach(HouseHold hhRec in queryResults)
                    {
                       string ss  = hhRec.ToString();
                    }


                }
                else
                {
                    // log.Info($"error");
                }



            }
        }
    }
}
