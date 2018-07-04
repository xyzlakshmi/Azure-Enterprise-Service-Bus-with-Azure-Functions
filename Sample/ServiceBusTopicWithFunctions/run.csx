#load "PersonHousehold.csx"
#load "Consts.csx"
#load "Messages.csx"
#r "Microsoft.Azure.WebJobs.ServiceBus"
#r "Microsoft.ServiceBus"
#r "System.Net"
#r "System.Net.Http"
#r "Newtonsoft.Json"


using System;
using System.Net;
using System.Net.Http.Headers;
using System.Threading;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Web.Http;
using Microsoft.ServiceBus.Messaging;


private static HttpClient httpClient = new HttpClient();

public async static void Run(TimerInfo myTimer, 
TraceWriter log,
ICollector<string> outputSbMsg
)
{        
      httpClient.BaseAddress = new Uri(Consts._SampleHouseHoldServiceApiBaseAddress);
      httpClient.DefaultRequestHeaders.Accept.Clear();
      httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
      HttpResponseMessage response =  httpClient.GetAsync(Consts.SampleAPI).Result;
      if (response.IsSuccessStatusCode)
      {
        
         var queryResults = response.Content.ReadAsAsync<IEnumerable<HouseHold>>().Result.ToList();
         foreach(HouseHold hhRec in queryResults)
         {
           string Output = "Messages.HHHNew" + hhRec.ToString();
           log.Info($"output: {Output}");
            outputSbMsg.Add(Output);
         }
           
            
       
      }
      else
      {
           log.Info($"error");
      }
      
         
}

// List<BrokeredMessage> result = new List<BrokeredMessage>();
      //   var queryResults = response.Content.ReadAsAsync<IEnumerable<HouseHold>>().Result.ToList();
         //  foreach (HouseHold hhRec in queryResults)
        //   {
         //       BrokeredMessage message = new BrokeredMessage();
        //        message.Properties.Add("MESSAGEID", Messages.HHHNew);
         //       message.Properties.Add("StudentPersonId", hhRec.StudentPersonId);
         //       message.Properties.Add("FirstName", hhRec.FirstName);
         //       message.Properties.Add("LastName", hhRec.LastName);
          //      message.Properties.Add("MiddleName", hhRec.MiddleName);
        //        message.Properties.Add("HouseHoldID", hhRec.HouseHoldID);
         //       message.Properties.Add("HouseHoldGuardian", hhRec.HouseHoldGuardian);
         //       result.Add(message);
          //      outputSbMsg.Add(message.);
         //   }