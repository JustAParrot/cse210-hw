using System;

namespace EventPlanning
{
    public class Event
    {
        protected string title;
        protected string description;
        protected DateTime date;
        protected TimeSpan time;
        protected Address address;

        public Event(string title, string description, DateTime date, TimeSpan time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        public virtual string GetStandardDetails()
        {
            return $"Event: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address}";
        }

        public virtual string GetFullDetails()
        {
            return GetStandardDetails();
        }

        public virtual string GetShortDescription()
        {
            return $"Type: General Event\nTitle: {title}\nDate: {date.ToShortDateString()}";
        }
    }
}
