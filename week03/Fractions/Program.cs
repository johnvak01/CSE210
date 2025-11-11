using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        
        Fraction tester1 = new Fraction();
        Fraction tester2 = new Fraction(5);
        Fraction tester3 = new Fraction(2,3);

        Console.WriteLine(tester1.GetFractionString());
        Console.WriteLine(tester2.GetFractionString());
        Console.WriteLine(tester3.GetFractionString());
        
        Console.WriteLine(tester1.GetDecimalValue());
        Console.WriteLine(tester2.GetDecimalValue());
        Console.WriteLine(tester3.GetDecimalValue());
    }
}