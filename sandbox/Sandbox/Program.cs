using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        int arg = 7;
        int result = F(ref arg);
        Console.WriteLine($" arg contains {arg}");
        Console.WriteLine($" result contains {result}");
    }

    static int F(ref int argument_holder)
    {
        argument_holder += 2;
        return argument_holder +1;
    }
}