using System;
using System.Collections.Generic;

public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public TimeSpan Time
    {
        get { return _time; }
        set { _time = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public string GetStandardDetails()
    {
        return $"{_title}\n{_description}\n{_date.ToShortDateString()} {_time.ToString(@"hh\:mm")}\n{_address.GetFullAddress()}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        string eventType = GetType().Name;
        return $"{eventType}: {_title} on {_date.ToShortDateString()}";
    }

}