public class Reception
    {
        private Event _baseEvent;
        private string _email;

        public Reception(string title, string description, DateTime dateTime, Address address, string email)
        {
            _baseEvent = new Event(title, description, dateTime, address);
            _email = email;
        }

        public string GetStandardDetails()
        {
            return _baseEvent.GetStandardDetails();
        }

        public string GetFullDetails()
        {
            return $"{_baseEvent.GetStandardDetails()}\nEvent Type: Reception\nRSVP Email: {_email}";
        }

        public string GetShortDescription()
        {
            return _baseEvent.GetShortDescription("Reception");
        }
    }