using System.Collections.Generic;
using System.Linq;

public class Menu
{
    public void DisplayMenu()
    {
        int userChoice;
        System.Console.WriteLine("Please select one of the following choices: ");
        System.Console.WriteLine("1. Write");
        System.Console.WriteLine("2. Display");
        System.Console.WriteLine("3. Load");
        System.Console.WriteLine("4. Save");
        System.Console.WriteLine("5. Quit");
        System.Console.Write("What would you like to do? ");
        userChoice = int.Parse(Console.ReadLine());
        if (userChoice == 1)
        {
            System.Console.Write("> ");
            Console.ReadLine();
        }

    }
}