using System;
using System.Collections.Generic;
using System.Text;

namespace BoredAPI_Client.Interfaces
{
    public interface IActivityModel
    {
        string Activity { get; set; }
        decimal? Accessibility { get; set; }
        decimal? AccessibilityMin { get; set; }
        decimal? AccessibilityMax { get; set; }
        string? Type { get; set; }
        int? Participants { get; set; }
        decimal? Price { get; set; }
        decimal? PriceMin { get; set; }
        decimal? PriceMax { get; set; }
        string Link { get; set; }
        int? Key { get; set; }

        string GetActivityDetails();

    }
}
