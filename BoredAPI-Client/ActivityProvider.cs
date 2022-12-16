using BoredAPI_Client.Models;
using System;
using Newtonsoft.Json;
using System.Net.Http;

namespace BoredAPI_Client
{
    public class ActivityProvider : IActivityProvider
    {

        public string BaseAddress => "http://www.boredapi.com/api/activity";

        public Activity QueryResults()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            using(var client = new HttpClient())
            {
                var endpoint = new Uri("http://www.boredapi.com/api/activity/");
                var res = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
                Console.WriteLine(res);
            }
        }
    }
}
