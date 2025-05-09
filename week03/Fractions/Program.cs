using System;

class Program
{
    static void Main(string[] args)
    {
        var f1 = new Fraction();               // should be 1/1
        var f2 = new Fraction(9);              // should be 9/1
        var f3 = new Fraction(2, 5);           // should be 2/5
        var f4 = new Fraction(10, 3);          // should be 10/3

        PrintDetails(f1);
        PrintDetails(f2);
        PrintDetails(f3);
        PrintDetails(f4);

        // should update the fractions
        f4.UpdateNumerator(7);
        f4.UpdateDenominator(8);
        PrintDetails(f4);                      // Should be 7/8 now
    }

    static void PrintDetails(Fraction frac)
    {
        Console.WriteLine($"Fraction: {frac.Display()}");
        Console.WriteLine($"Decimal: {frac.ToDouble()}\n");
    }
}
