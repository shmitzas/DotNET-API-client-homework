using BoredAPI_Client.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoredAPI_Client.Interfaces
{
    public interface IFakeAPI
    {
        ActivityModel GetTask(string type = null, int? participants = null, decimal? access = null, decimal? accessMin = null, decimal? accessMax = null, decimal? price = null, decimal? priceMin = null, decimal? priceMax = null);
        ActivityModel GetTaskByKey(int key);
    }
}
