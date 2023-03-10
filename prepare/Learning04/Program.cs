using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment ma1 = new MathAssignment("Samuel Bennett", "Multiplication", "Chapter 2", "Exercises 2.1-2.5");
        System.Console.WriteLine(ma1.GetSummary());
        System.Console.WriteLine(ma1.GetHomeworkList());

        WritingAssignment wa1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        System.Console.WriteLine(wa1.GetSummary());
        System.Console.WriteLine(wa1.GetWritingInformation());
    }
}