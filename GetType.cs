using System;

class DemoVariabel3
{
    static void Main()
    {
        var a = -1;
        var b = 1.11;

        Console.WriteLine("Nilai Awal");
        Console.WriteLine("Nilai a =" + a);
        Console.WriteLine("Nilai b =" + b);

        Console.WriteLine();

        Console.WriteLine("Type Data:");
        Console.WriteLine("Type Data a =" + a.GetType());
        Console.WriteLine("Nilai b =" + b.GetType());

        Console.ReadKey();
    }
}