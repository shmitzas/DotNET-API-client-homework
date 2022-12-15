using BoredAPI_Client.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoredAPI_Client
{
    interface IActivityProvider
    {
        string BaseAddress { get; }
       
        Activity QueryResults();
    }
}
