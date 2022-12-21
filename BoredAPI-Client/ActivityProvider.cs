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
        static readonly string BaseAddress = "http://www.boredapi.com/api/activity";

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
            if (activity.Key != null) ModAddress = BaseAddress + "?key=" + activity.Key.ToString();
            else
            {
                ModAddress +=
                    "?participants=" + activity.Participants.ToString()
                    + "&minaccessibility=" + activity.AccessibilityMin.ToString()
                    + "&maxaccessibility=" + activity.AccessibilityMax.ToString()
                    + "&minprice=" + activity.PriceMin.ToString()
                    + "&maxprice=" + activity.PriceMax.ToString();
                if (activity.Type != "Random") ModAddress += "&type=" + activity.Type.ToString().ToLower();
            }

            var response = await client.GetStringAsync(ModAddress);
            ActivityModel result = null;
            if (response != null)
                result = JsonConvert.DeserializeObject<ActivityModel>(response);

            return result;
        }
    }
}
