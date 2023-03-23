using System;
using System.Collections.Generic;
using System.Threading;

class Listing : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void RunActivity()
    {
        StartingMessage("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        int endTime = Environment.TickCount + duration * 1000;
        Random random = new Random();
        List<string> items = new List<string>();

        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        Console.WriteLine("Press ENTER after each item. Start listing:");

        while (Environment.TickCount < endTime)
        {
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");

        EndingMessage("Listing");
    }
}