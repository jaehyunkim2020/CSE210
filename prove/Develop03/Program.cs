using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new scripture object
        var scripture = new Scriptures("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (true)
        {
            Console.Clear();
            System.Console.WriteLine(scripture.GetRenderedText());

            System.Console.WriteLine("\nPress enter to hide words, or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }
    }
}