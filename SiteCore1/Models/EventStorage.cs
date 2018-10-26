using SiteCore1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SiteCore1.Storage
{
    public class EventStorage
    {
        public static string GetMarkup()
        {
            StringBuilder builder = new StringBuilder();
            foreach (EventModel model in Events)
            {
                builder.AppendLine("<div class=\"col-md-3\" style='margin-bottom: 2vh'>" +
                    $"<div>{model.Name}</div>" +
                    $"<div>{model.ShortDescription}</div>" +
                    $"<div>Date: {model.Date.ToShortDateString()}</div>" +
                    "</div>");
            }
            return builder.ToString();
        }
        static EventStorage()
        {
            Events = new List<EventModel>
            {
                new EventModel("First lab", "Must go to the first lab", DateTime.Now),
                new EventModel("Second lab", "Must go to the second lab", DateTime.Now.AddDays(1)),
                new EventModel("Third lab", "Must go to the third lab", DateTime.Now.AddDays(2)),
                new EventModel("Fourth lab", "Must go to the fourth lab", DateTime.Now.AddDays(3)),
                new EventModel("Fifth lab", "Must go to the fifth lab", DateTime.Now.AddDays(4))
            };
        }

        public static List<EventModel> Events { get; private set; }
    }
}