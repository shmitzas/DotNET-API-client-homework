using BoredAPI_Client.Models;
using System;
using Newtonsoft.Json;

namespace BoredAPI_Client
{
    public class ActivityProvider : IActivityProvider
    {

        public string BaseAddress => "http://www.boredapi.com/api/activity";

        public Activity QueryResults()
        {
            throw new NotImplementedException();
        }

    }
}
