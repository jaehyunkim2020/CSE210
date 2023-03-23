using System;
using System.Collections.Generic;
using System.Threading;

abstract class MindfulnessActivity
{
    protected int duration;

    protected void StartingMessage(string activityName, string activityDescription)
    {
        Console.Clear();
        Console.WriteLine($"Activity: {activityName}");
        Console.WriteLine($"Description: {activityDescription}");
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000);
    }

    protected void EndingMessage(string activityName)
    {
        Console.WriteLine("\nGood job!");
        Thread.Sleep(3000);
        Console.WriteLine($"You have completed the {activityName} activity for {duration} seconds.");
        Thread.Sleep(3000);
        Console.Clear();
    }

    protected void SpinnerAnimation()
    {
        Console.Write("\r-");
        Thread.Sleep(100);
        Console.Write("\r\\");
        Thread.Sleep(100);
        Console.Write("\r|");
        Thread.Sleep(100);
        Console.Write("\r/");
        Thread.Sleep(100);
    }

    public abstract void RunActivity();
}
