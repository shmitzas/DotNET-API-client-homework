using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using BoredAPI_Client.Models;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using BoredAPI_Client.Interfaces;

namespace BoredAPI_Client
{
    public class ActivityProvider : IActivityProvider
    {
        static readonly HttpClient client = new HttpClient();
        static readonly FakeAPI fakeClient = new FakeAPI();
        static readonly string BaseAddress = "http://www.boredapi.com/api/activity/?";

        public async Task<List<ActivityModel>> GetTasks(ActivityModel act = null, int limit = 1, bool test = false)
        {
            List<ActivityModel> activities = new List<ActivityModel>();
            ActivityModel task;
            for (int i = 0; i < limit; i++)
            {
                if (test)
                {
                    if (act == null) task = fakeClient.GetTask();
                    else
                    {
                        task = fakeClient.GetTask(
                        type: act.Type,
                        participants: act.Participants,
                        accessMin: act.AccessibilityMin,
                        accessMax: act.AccessibilityMax,
                        priceMin: act.PriceMin,
                        priceMax: act.PriceMax,
                        price: act.Price,
                        access: act.Accessibility);
                    }
                    if (task != null) activities.Add(task);
                }
                else
                {
                    if (act == null) task = await GetTask();
                    else
                    {
                        task = await GetTask(
                        type: act.Type,
                        participants: act.Participants,
                        accessMin: act.AccessibilityMin,
                        accessMax: act.AccessibilityMax,
                        priceMin: act.PriceMin,
                        priceMax: act.PriceMax,
                        price: act.Price,
                        access: act.Accessibility);
                    }
                    if (task != null) activities.Add(task);
                }
            }
            return activities;
        }

        public async Task<ActivityModel> GetTaskByKey(int key, bool test = false)
        {
            string? response = null;
            if (test)       
                return fakeClient.GetTaskByKey(key);
            else 
                response = await client.GetStringAsync(BaseAddress + "&key=" + key.ToString().ToLower());
            return response != null ? JsonConvert.DeserializeObject<ActivityModel>(response) : new ActivityModel { };
        }

        public async Task<ActivityModel> GetTask(string type = null, int? participants = null, decimal? access = null, decimal? accessMin = null, decimal? accessMax = null, decimal? price = null, decimal? priceMin = null, decimal? priceMax = null)
        {
            string ModAddress = BaseAddress;
            if (type != "Random" && type != null) ModAddress += "&type=" + type.ToString().ToLower();
            if (participants != null) ModAddress += "&participants=" + participants.ToString();
            if (accessMin != null) ModAddress += "&minaccessibility=" + accessMin.ToString();
            if (accessMax != null) ModAddress += "&maxaccessibility=" + accessMax.ToString();
            if (priceMin != null) ModAddress += "&minprice=" + priceMin.ToString();
            if (priceMax != null) ModAddress += "&maxprice=" + priceMax.ToString();

            var response = await client.GetStringAsync(ModAddress);
            return response != null ? JsonConvert.DeserializeObject<ActivityModel>(response) : new ActivityModel { };
        }
    }
}
