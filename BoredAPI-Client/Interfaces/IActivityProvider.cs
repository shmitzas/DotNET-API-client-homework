using BoredAPI_Client.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BoredAPI_Client.Interfaces
{
    public interface IActivityProvider
    {
        Task<List<ActivityModel>> GetTasks(ActivityModel act = null, int limit = 1, bool test = false);
        Task<ActivityModel> GetTask(string type = null, int? participants = null, decimal? access = null, decimal? accessMin = null, decimal? accessMax = null, decimal? price = null, decimal? priceMin = null, decimal? priceMax = null);
        Task<ActivityModel> GetTaskByKey(int key, bool test = false);
    }

}
