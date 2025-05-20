using System;

class Fraction
{
    // Member variables / attributes
    private int _top;
    private int _bottom;

    //Creating the constructors to initialize numbers to 1/1
    public Fraction() // No parameter needed. No values need to be passed in.
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator) // Only one parameter needed - the numerator. Denominator will default to 1 e.g. 5/1 or 2/1
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator) // both parameters need to be included when initializing an instance of the class.
    {
        _top = numerator;
        _bottom = denominator;
    }

    //Setting up the getters and setters for member variables

    //Setters
    public void SetTop(int num)
    {
        _top = num;
    }

    public void SetBottom(int num)
    {
        _bottom = num;
    }

    //Getters

    public void GetTop()
    {
        Console.WriteLine(_top);
    }

    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }

    // Setting up methods to return results in fraction 3/4 format and decimal 0.75 format
    public string GetFractionString()
    {
        string text = $"{_top} / {_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {

        return (double)_top / (double)_bottom;
    } 


}