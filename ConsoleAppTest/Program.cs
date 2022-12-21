using System;
using BoredAPI_Client;
using BoredAPI_Client.Models;
namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ActivityProvider activity = new ActivityProvider();
            var res = activity.RandomTask();
            Console.WriteLine(res);
        }
    }
}
