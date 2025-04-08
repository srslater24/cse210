using System;

public class Event // base class
{
    private string _title;
    private string _desc;
    private DateTime _dateTime;
    private Address _address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        _title = title;
        _desc = description;
        _dateTime = dateTime;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return ($"Title: {_title}\nDescription: {_desc}\nDate: {_dateTime:MMMM dd, yyyy}\nTime: {_dateTime:hh:mm tt}\nAddress: {_address.FullAddress()}");
    }

    public string GetShortDescription(string eventType)
    {
        return ($"Event Type: {eventType}\nTitle: {_title}\nDate: {_dateTime:MMMM dd, yyyy}");
    }
}