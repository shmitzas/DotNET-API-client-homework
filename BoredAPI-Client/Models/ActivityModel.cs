using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BoredAPI_Client.Models
{
    public class Activity
    {
		string name { get; set; }
		double difficulty { get; set; }
		string type { get; set; }
		int participants { get; set; }
		BigInteger price { get; set; }
		string link { get; set; }
		int key { get; set; }
    }
}
