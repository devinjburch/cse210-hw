using System;



public class Fraction
{


    private int _numerator;
    private int _denominator;




    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }




    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }




    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }





    public int GetNumerator()
    {
        return _numerator;
    }





    public int GetDenominator()
    {
        return _denominator;
    }





    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }




    public void SetDenominator(int denominator)
    {
        if (denominator != 0)
        {
            _denominator = denominator;
        }
    }




    public string DisplayFraction()
    {
        return _numerator + "/" + _denominator;
    }




    public double ConvertToDecimal()
    {
        return (double)_numerator / _denominator;
    }
}