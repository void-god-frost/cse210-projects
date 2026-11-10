using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int numerator)
    {
        _top = numerator;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int denominator)
    {
        _top = denominator;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top/_bottom;
    }
}