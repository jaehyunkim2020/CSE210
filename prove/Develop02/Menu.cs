using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Menu
{
    List<Entry> entries = new List<Entry>();

    public bool DisplayMenu()
    {
        // get the current date and save it to the dateText variable
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        int userChoice;
        System.Console.WriteLine("Please select one of the following choices: ");
        System.Console.WriteLine("1. Write");
        System.Console.WriteLine("2. Display");
        System.Console.WriteLine("3. Load");
        System.Console.WriteLine("4. Save");
        System.Console.WriteLine("5. Quit");
        System.Console.Write("What would you like to do? ");
        userChoice = int.Parse(Console.ReadLine());

        Prompts promptsList = new Prompts();

        if (userChoice == 1)
        {
            // create an object of the prompts list from the Prompts class

            // create random number generator and assign it to a variable called randNum that goes up to the count of the prompts list 
            Random rnd = new Random();
            int randNum = rnd.Next(promptsList.prompts.Count());

            // prints one of the propmt questions randomly
            System.Console.WriteLine(promptsList.prompts[randNum]);
            System.Console.Write("> ");
            string textEntry = Console.ReadLine();

            Entry entry = new Entry(promptsList.prompts[randNum], textEntry);
            entries.Add(entry);
        }

        else if (userChoice == 2)
        {
            foreach (var line in entries)
            {
                line.DisplayEntry();
            }
        }

        else if (userChoice == 3)
        {
            System.Console.WriteLine("What is the filename?");
            var filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);
            
            foreach (var line in lines)
            {
                string[] format = line.Split("@");
                string date = format[0];
                string prompt = format[1];
                string text = format[2];

                System.Console.WriteLine($"Date: {date} - Prompt: {prompt}");
                System.Console.WriteLine(text);
                System.Console.WriteLine();
            }
        }


        else if (userChoice == 4)
        {
            System.Console.WriteLine("What is the filename? (ex. 'journal.txt')");
            var filename = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // loop through the entries list and write them to the file
                foreach (var entry in entries)
                {
                    var format = $"{entry.date}@{entry.prompt}@{entry.text}";
                    outputFile.WriteLine(format);
                }
            }
        }

        return userChoice != 5;

    }
}