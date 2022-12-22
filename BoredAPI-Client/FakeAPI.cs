using BoredAPI_Client.Interfaces;
using BoredAPI_Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoredAPI_Client
{
    public class FakeAPI : IFakeAPI
    {
        public readonly List<ActivityModel> activities = new List<ActivityModel>
        {
                new ActivityModel {Activity = "Act 1", Type ="Activity", Participants = 4, Accessibility = 0.5m, Price = 0.3m, Key=0, Link=""},
                new ActivityModel {Activity = "Act 2", Type ="Chore", Participants = 2, Accessibility = 0.1m, Price = 0.7m, Key=1, Link="https://google.com"},
                new ActivityModel {Activity = "Act 3", Type ="Activity", Participants = 3, Accessibility = 0.3m, Price = 0.8m, Key=2, Link=""},
                new ActivityModel {Activity = "Act 4", Type ="Chore", Participants = 1, Accessibility = 0.2m, Price = 0.4m, Key=3, Link="https://boredapi.com"},
                new ActivityModel {Activity = "Act 5", Type ="Chore", Participants = 1, Accessibility = 0.1m, Price = 0.1m, Key=4, Link=""}
        };
        public readonly List<string> activityTypes = new List<string>
        {
            "Activity", "Chore" 
        };

        public ActivityModel GetTask(string type=null, int? participants = null, decimal? access = null, decimal? accessMin = null, decimal? accessMax = null, decimal? price = null, decimal ? priceMin = null, decimal? priceMax = null)
        {
            ActivityModel res = activities.Where(a => (type == null || a.Type == type)
                && (participants == null || a.Participants == participants)
                && (access == null || a.Accessibility == access)
                && (price == null || a.Price == price)
                && (accessMin == null || a.Accessibility >= accessMin)
                && (accessMax == null || a.Accessibility <= accessMax)
                && (priceMin == null || a.Price >= priceMin)
                && (priceMax == null || a.Price <= priceMax)).FirstOrDefault();
            return res != null ? res : new ActivityModel();
        }

        public ActivityModel GetTaskByKey(int key)
        {
            ActivityModel res = activities.FirstOrDefault(a => a.Key == key);
            return res != null ? res : new ActivityModel();
        }
    }
}
