using System;
using System.Data;

class DemoVariabel2
{
    static void Main()
    {
        int panjang = 10, lebar = 20;

        int luas = panjang * lebar;

        Console.WriteLine("Persegi Panjang");
        Console.WriteLine("Panjang = " + panjang);
        Console.WriteLine("Lebar =" + lebar);

        Console.WriteLine("Luas Persegi Panjang =" + luas);
        Console.Read();
    }
}