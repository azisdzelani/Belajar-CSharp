//MEMBACA INPUTAN BERTYPE CHAR

using System;

class DemoInputChar
{
    static void Main()
    {
        char c;
        string s;

        Console.Write("Masukan karakter :");
        s = Console.ReadLine();

        //konversi dari string ke char menggunakan "TryParse"
        if (char.TryParse(s, out c))
        {
            Console.WriteLine("Karakter yang dimasukan adalah : '" + c + "'");
        }
        else
        {
            Console.WriteLine("Data yang dimasukan tidak dapat dikonversi ke char ");
        }

        Console.ReadLine();
    }
}