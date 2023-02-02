using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        fraction1.DisplayFraction();

        Fraction fraction2 = new Fraction(6);
        fraction2.DisplayFraction();
        
        Fraction fraction3 = new Fraction(6, 7);
        fraction3.DisplayFraction();

        Fraction f1 = new Fraction();
        f1.SetBottomNumber(5);
        f1.SetTopNumber(4);
        f1.DisplayFraction();
    }
}