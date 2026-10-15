
using System;
class Program
{
    static void Main(string[] args)
    {
        Fraction n1 = new Fraction();
        Console.WriteLine(n1.GetFractionString());
        Console.WriteLine(n1.GetDecimalValue());

        Fraction n2 = new Fraction(5);
        Console.WriteLine(n2.GetFractionString());
        Console.WriteLine(n2.GetDecimalValue());

        Fraction n3 = new Fraction(3, 4);
        Console.WriteLine(n3.GetFractionString());
        Console.WriteLine(n3.GetDecimalValue());

        Fraction n4 = new Fraction(1, 3);
        Console.WriteLine(n4.GetFractionString());
        Console.WriteLine(n4.GetDecimalValue());


        Fraction testFraction = new Fraction();

        testFraction.SetTop(7);
        testFraction.SetBottom(8);

        Console.WriteLine($"Top: {testFraction.GetTop()}");
        Console.WriteLine($"Bottom: {testFraction.GetBottom()}");
        Console.WriteLine(testFraction.GetFractionString());
        Console.WriteLine(testFraction.GetDecimalValue());


        Random random = new Random();
        Fraction n5 = new Fraction();

        for (int i = 0; i < 20; i++)
        {
            int topValue = random.Next(1, 11);
            int bottomValue = random.Next(1, 11);

            n5.SetTop(topValue);
            n5.SetBottom(bottomValue);

            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {n5.GetFractionString()}");
            Console.WriteLine($" Number: {n5.GetDecimalValue()}");
}
    }

    
}