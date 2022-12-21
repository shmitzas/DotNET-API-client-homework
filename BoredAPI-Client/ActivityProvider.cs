using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using BoredAPI_Client.Models;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace BoredAPI_Client
{
    public class ActivityProvider
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string BaseAddress = "http://www.boredapi.com/api/activity/?";

        public async Task<List<ActivityModel>> GetRandomTasks()
        {
            List<ActivityModel> activities = new List<ActivityModel>();
            for (int i = 0; i < 10; i++)
            {
                var task = await GetRandomTask();
                if (task != null) activities.Add(task);
            }
            return activities;
        }

        public async Task<ActivityModel> GetRandomTask()
        {
            ActivityModel result = null;
            string response = await client.GetStringAsync(BaseAddress);
            if (response != null)
                result = JsonConvert.DeserializeObject<ActivityModel>(response);
            return result;
        }
        public async Task<List<ActivityModel>> GetTasks(ActivityModel activity)
        {
            List<ActivityModel> activities = new List<ActivityModel>();
            for(int i=0; i<10; i++)
            {
                var task = await GetTask(activity);
                if (task != null) activities.Add(task);
            }
            return activities;
        }

        public async Task<ActivityModel> GetTask(ActivityModel activity)
        {
            string ModAddress = BaseAddress;
            if (activity.Key != null) ModAddress += "&key=" + activity.Key.ToString();
            else
            {
                if (activity.Type != "Random") ModAddress += "&type=" + activity.Type.ToString().ToLower();
                if (activity.Participants != null) ModAddress += "&participants=" + activity.Participants.ToString();
                if (activity.AccessibilityMin != null) ModAddress += "&minaccessibility=" + activity.AccessibilityMin.ToString();
                if (activity.AccessibilityMax != null) ModAddress += "&maxaccessibility=" + activity.AccessibilityMax.ToString();
                if (activity.PriceMin != null) ModAddress += "&minprice=" + activity.PriceMin.ToString();
                if (activity.PriceMax != null) ModAddress += "&maxprice=" + activity.PriceMax.ToString();
            }

            var response = await client.GetStringAsync(ModAddress);
            ActivityModel result = null;
            if (response != null)
                result = JsonConvert.DeserializeObject<ActivityModel>(response);
            Debug.WriteLine($"Query: {ModAddress}\nResult:{result.GetActivityDetails()}");
            return result;
        }
    }
}
