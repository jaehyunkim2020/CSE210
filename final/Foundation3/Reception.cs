using System;
using System.Collections.Generic;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
     : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string RsvpEmail
    {
        get { return _rsvpEmail; }
        set { _rsvpEmail = value; }
    }

    public override string GetFullDetails()
    {
        string baseDetails = GetStandardDetails();
        return $"{baseDetails}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}