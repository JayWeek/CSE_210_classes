using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction frac = new Fraction(5, 4);
        frac.SetTop(10);
        frac.SetBottom(5);
        double decimalValue = frac.GetDecimalValue();
        string stringValue = frac.GetFractionString();
        Console.WriteLine(decimalValue);
        Console.WriteLine(stringValue);
        
    }
}