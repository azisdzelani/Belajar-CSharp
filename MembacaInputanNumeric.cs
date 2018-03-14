//Membaca Data Bertipe Numerik

using System;

class InputNumber
{
    static void Main()
    {
        //MetodeTryParse();
        //MetodeParse();
        //InputString();
        //InputChar();
        KonversiParse2();
    }

    static void MetodeTryParse()
    {
        string input;
        int i;

        Console.Write("Masukan Bilangan Bulat");
        input = Console.ReadLine();

        if (int.TryParse(input, out i))
        {
            Console.WriteLine("Anda memasukan bilangan =" + i);
        }
        else
        {
            Console.WriteLine("Bilangan gagal Dikonversi");
        }

        Console.Read();
    }

    static void MetodeParse()
    {
        string input;
        double b;

        Console.WriteLine("Masukan Bilangan Bulat = ");
        input = Console.ReadLine();

        b = double.Parse(input);

        Console.WriteLine("Anda Memasukan Bilangan " + b);

        Console.ReadLine();
    }

    static void InputString()
    {
        Console.WriteLine("Masukan Nama Anda =");

        string nama = Console.ReadLine();

        Console.WriteLine("Nama Anda Adalah " + nama);

        Console.ReadLine();
    }

    static void InputChar()
    {
        string input;
        char c;

        Console.WriteLine("Masukan Karakter : ");
        input = Console.ReadLine();

        if (char.TryParse(input, out c))
        {
            Console.WriteLine("karakter yang anda masukan adalah =" + c);
        }
        else
        {
            Console.WriteLine("Karakter gagal di konversi");
        }
        Console.ReadLine();
    }

    static void KonversiParse()
    {
        string input;
        double d;

        Console.Write("Masukan Bilangan Pecahan =");

        input = Console.ReadLine();
        d = double.Parse(input);

        Console.WriteLine("Bilangan yang anda masukan adalah = " + d);
        Console.ReadLine();
    }

    static void KonversiParse2()
    {
        string nilai;
        int hasil;

        Console.WriteLine("Masukan Nilai :");
        nilai = Console.ReadLine();

        if (int.TryParse(nilai, out hasil))
        {
            Console.WriteLine("Nilai yang anda masukan adalah :" + hasil);
        }
        Console.ReadLine();
    }

}