
class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _denominator = 1;
        _numerator = numerator;
    }

    public Fraction(int denominator, int numerator)
    {
        _denominator = denominator;
        _numerator = numerator;
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public void DisplayFraction()
    {
        System.Console.WriteLine($"{_numerator} / {_denominator}");
    }
}