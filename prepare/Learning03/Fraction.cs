
public class Fraction
{

    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public void DisplayFraction()
    {
        System.Console.WriteLine($"{_numerator}/{_denominator}");
    }

    public void SetBottomNumber(int denominator)
    {
        _denominator = denominator;
    }

    public void SetTopNumber(int numerator)
    {
        _numerator = numerator;
    }

    public int GetBottomNumber()
    {
        return _denominator;
    }

    public int GetTopNumber()
    {
        return _numerator;
    }

    public string GetFractionString()
    {
        string display = $"{_numerator}/{_denominator}";
        return display;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}