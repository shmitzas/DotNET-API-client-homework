using BoredAPI_Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace BoredAPI_Client.Models
{
    public class ActivityModel : IActivityModel
    {
        public string Activity { get; set; }
        public decimal? Accessibility { get; set; }
        public decimal? AccessibilityMin { get; set; }
        public decimal? AccessibilityMax { get; set; }
        public string Type { get; set; }
        public int? Participants { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceMin { get; set; }
        public decimal? PriceMax { get; set; }
        public string Link { get; set; }
        public int? Key { get; set; }

        public string GetActivityDetails()
        {
            return $"\n Activity: {this.Activity}\n Accessibility: {this.Accessibility}\n Type: {this.Type}\n Participants: {this.Participants}\n Price: {this.Price}\n Key: {this.Key}\n Link: {this.Link}";
        }
    }
    
}
