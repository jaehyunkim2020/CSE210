using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        fraction1.DisplayFraction();

        Fraction fraction2 = new Fraction(6);
        fraction2.DisplayFraction();

        Fraction fraction3 = new Fraction(7, 6);
        fraction3.DisplayFraction();

        fraction1.SetDenominator(13);
        fraction1.GetDenominator();
        fraction1.SetNumerator(12);
        fraction1.GetNumerator();
        fraction1.DisplayFraction();

        fraction1.SetDenominator(5);
        fraction1.DisplayFraction();
        
    }
}