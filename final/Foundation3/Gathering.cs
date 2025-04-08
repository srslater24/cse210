public class OutdoorGathering
    {
        private Event _baseEvent;
        private string _weatherForecast;

        public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weatherForecast)
        {
            _baseEvent = new Event(title, description, dateTime, address);
            _weatherForecast = weatherForecast;
        }

        public string GetStandardDetails()
        {
            return _baseEvent.GetStandardDetails();
        }

        public string GetFullDetails()
        {
            return $"{_baseEvent.GetStandardDetails()}\nEvent Type: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
        }

        public string GetShortDescription()
        {
            return _baseEvent.GetShortDescription("Outdoor Gathering");
        }
    }