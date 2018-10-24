using System;

namespace SiteCore1.Models
{
    public class EventModel
    {
        public string MakeCodeString(string name, Guid id)
        {
            string[] newName = name.Split(' ');
            string code = string.Join("-", newName) + "-" + id.ToString();
            return code;
        }

        public EventModel(string name, string shortDescription, DateTime date)
        {
            ID = Guid.NewGuid();
            Name = name;
            ShortDescription = shortDescription;
            Date = date;
            Code = MakeCodeString(Name, ID);
        }

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public DateTime Date { get; set; }
        public string Code { get; set; }
    }
}