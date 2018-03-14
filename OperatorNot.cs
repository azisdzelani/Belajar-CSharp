using System;

class DemoOperatorNot
{
    public static void Main()
    {
        string input;
        int x;
        Console.Write("Masukan Nilai x \t:");

        x = Convert.ToInt16(Console.ReadLine());

        bool genap = (x % 2 == 0);

        if (genap)
        {
            Console.WriteLine(x + "\t Adalah Bilangan Genap");
        }
        else
        {
            Console.WriteLine(x + "\t Bilangan ganjil");
        }
        Console.ReadLine();
    }
}