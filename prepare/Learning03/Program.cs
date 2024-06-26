using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction F1 = new Fraction(1);
        Console.WriteLine(F1.GetFraction());
        Console.WriteLine(F1.GetDecimal());

        Fraction F2 = new Fraction(5);
        Console.WriteLine(F2.GetFraction());
        Console.WriteLine(F2.GetDecimal());

        Fraction F3 = new Fraction(3, 4);
        Console.WriteLine(F3.GetFraction());
        Console.WriteLine(F3.GetDecimal());

        Fraction F4 = new Fraction(1, 3);
        Console.WriteLine(F4.GetFraction());
        Console.WriteLine(F4.GetDecimal());
    }
}