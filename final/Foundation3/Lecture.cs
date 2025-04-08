public class Lecture
    {
        private Event _baseEvent;
        private string _speaker;
        private int _capacity;

        public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity)
        {
            _baseEvent = new Event(title, description, dateTime, address);
            _speaker = speaker;
            _capacity = capacity;
        }

        public string GetStandardDetails()
        {
            return _baseEvent.GetStandardDetails();
        }

        public string GetFullDetails()
        {
            return $"{_baseEvent.GetStandardDetails()}\nEvent Type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
        }

        public string GetShortDescription()
        {
            return _baseEvent.GetShortDescription("Lecture");
        }
    }