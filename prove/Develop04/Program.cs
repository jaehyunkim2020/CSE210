using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Breathing breathingActivity = new Breathing();
                    breathingActivity.RunActivity();
                    break;

                case 2:
                    Reflecting reflectionActivity = new Reflecting();
                    reflectionActivity.RunActivity();
                    break;

                case 3:
                    Listing listingActivity = new Listing();
                    listingActivity.RunActivity();
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    Thread.Sleep(1500);
                    break;
            }
        } while (choice != 4);
    }
}