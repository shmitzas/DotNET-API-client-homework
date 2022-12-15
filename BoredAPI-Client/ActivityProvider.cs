using BoredAPI_Client.Models;
using System;
using Newtonsoft.Json;

namespace BoredAPI_Client
{
    public class ActivityProvider : IActivityProvider
    {
        private string address = "http://www.boredapi.com/api/activity";
        private Activity GetModel(object json)
        {
            var activity = new Activity();

            return activity;
        }
    }
}
