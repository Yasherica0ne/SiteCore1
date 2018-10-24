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
                builder.AppendLine("<div class=\"col-md-4\">" +
                    $"<div>{model.Name}</div>" +
                    $"<div>{model.ShortDescription}</div>" +
                    $"<div>Date: {model.Date}</div>" +
                    "</div>");
            }
            return builder.ToString();
        }
        static EventStorage()
        {
            Events = new List<EventModel>
            {
                new EventModel("First lab", "Must go to the first lab", DateTime.Now),
                new EventModel("Second lab", "Must go to the second lab", DateTime.Now.AddHours(1.5)),
                new EventModel("Third lab", "Must go to the third lab", DateTime.Now.AddHours(3))
            };
        }

        public static List<EventModel> Events { get; private set; }
    }
}