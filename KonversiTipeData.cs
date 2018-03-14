using System;

/*
	konversi implisit
	konversi ekplisit
*/

class KonversiTipeData
{
    static void Main()
    {
        //KonversiImplisit();
        KonversiEkplisit();
    }

    static void KonversiImplisit()
    {
        int i = 100;
        double d;

        //akan terjadi konversi otomatis
        // dari tipe int ke double
        d = i;

        Console.WriteLine(i);
        Console.WriteLine(d);

        Console.ReadLine();
    }

    static void KonversiEkplisit()
    {
        double d = 123.865655;
        int s;

        //konversi data double ke int
        int i = (int)d;

        Console.WriteLine(i);
        Console.WriteLine(d);

        Console.ReadLine();
    }

    static void ClassConvert()
    {
        object s;
        object i;
        object b;
        object l;
        object d;

        s = Convert.ToString(100);
        i = Convert.ToInt16(3.14);
        b = Convert.ToByte(1);
        l = Convert.ToInt64(123456789);
        d = Convert.ToDateTime("2017-01-01");
    }
}