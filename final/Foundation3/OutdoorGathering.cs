using System;

namespace EventPlanning
{
    public class OutdoorGathering : Event
    {
        private string weatherForecast;

        public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            this.weatherForecast = weatherForecast;
        }

        public override string GetFullDetails()
        {
            return base.GetFullDetails() + $"\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
        }

        public override string GetShortDescription()
        {
            return $"Type: Outdoor Gathering\nTitle: {title}\nDate: {date.ToShortDateString()}";
        }
    }
}
