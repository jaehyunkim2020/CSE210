using System;
using System.Collections.Generic;
using System.Threading;

class Breathing : MindfulnessActivity
{
    public override void RunActivity()
    {
        StartingMessage("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        int endTime = Environment.TickCount + duration * 1000;

        while (Environment.TickCount < endTime)
        {
            Console.Write("Breathe in... ");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }

            Console.WriteLine();

            if (Environment.TickCount >= endTime) break;

            Console.Write("Breathe out... ");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }

            Console.WriteLine();
        }

        EndingMessage("Breathing");
    }
}