using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
        Prompts promptsList = new Prompts();  
        // Job jobOne = new Job();
        // jobOne._jobTitle = "Software Engineer";
        // jobOne._company = "Microsoft";
        // jobOne._startYear = 2019;
        // jobOne._endYear = 2022;

        // Job jobTwo = new Job();
        // jobTwo._jobTitle = "Manager";
        // jobTwo._company = "Apple";
        // jobTwo._startYear = 2022;
        // jobTwo._endYear = 2023;

        // Resume myResume = new Resume();
        // myResume._name = "Allison Rose";
        // myResume._jobs.Add(jobOne);
        // myResume._jobs.Add(jobTwo);
        // myResume.DisplayResume();

        System.Console.WriteLine("Welcome to the Journal Program!");

        foreach (var prompt in promptsList.prompts)
        {

        }

    }

    public void Prompts()
    {
    }
}