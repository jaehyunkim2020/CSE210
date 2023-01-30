using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
        Menu menu = new Menu();
        
        System.Console.WriteLine("Welcome to the journal program");
        while (menu.DisplayMenu());

    }
}