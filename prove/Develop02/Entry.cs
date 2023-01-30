using System.Collections.Generic;
using System.Linq;

public class Entry
{
    public string prompt;
    public string date;
    public string text;

    public Entry(string p, string t)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        date = dateText;

        prompt = p;
        text = t;
    }

    public void DisplayEntry()
    {
        System.Console.WriteLine($"Date: {date} - Prompt: {prompt}");
        System.Console.WriteLine(text);
        System.Console.WriteLine();
    }
}