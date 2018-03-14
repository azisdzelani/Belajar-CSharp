using System;

class Operator
{
    public static void Main()
    {
        int x;

        //pre-increment
        x = 9;
        Console.WriteLine("x \t: " + x);
        Console.WriteLine("++x \t: " + ++x);
        Console.WriteLine("x \t: " + x);
        Console.WriteLine();

        //post-increment
        x = 9;
        Console.WriteLine("x \t: " + x);
        Console.WriteLine("x++ \t: " + x++);
        Console.WriteLine("x \t: " + x);
        Console.WriteLine();

        Console.ReadLine();
    }
}