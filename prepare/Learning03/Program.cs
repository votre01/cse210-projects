using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6,7);

        f1.SetTop(3);
        f1.SetBottom(5);
        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f1.GetBottom());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine($"{f1.GetDecimalValue()}");
    }
}