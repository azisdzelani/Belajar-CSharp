using System;

class DemoVariabel
{
    static void Main()
    {
        int panjang;
        int lebar;
        int luas;

        // assign nilai kedalam variable
        panjang = 10;
        lebar = 20;

        luas = panjang * lebar;

        Console.WriteLine("Persegi Panjang");

        Console.WriteLine("Panjang =" + panjang);

        Console.WriteLine("Lebar =" + lebar);

        Console.WriteLine("Luas Persegi Panjang = " + luas);

        Console.ReadLine();
    }
}