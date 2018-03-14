using System;

class BabDua
{
    static void Main()
    {
        //DemoIF();
        //DemoSwitch();
        //DemoWhile();
        //DemoDoWhile();
        //DemoDoWhile2();
        //DemoFor();
        //DemoFor2();
        //DemoForeach1();
        PengulanganBersarang();
    }

    static void DemoIF()
    {
        int angka;

        Console.Write("Masukan bilangan bulat: ");

        angka = Convert.ToInt32(Console.ReadLine());

        if (angka < 0)
        {
            Console.WriteLine(angka + "adalah bilangan negatif");
        }
        else if (angka == 0)
        {
            Console.WriteLine("anda memasukan bilangan POSITIF");
        }
        else
        {
            Console.WriteLine(angka + "adalah bilangan positif");
        }

        Console.ReadLine();
    }

    static void DemoSwitch()
    {
        char tab = '\t';
        int nohari = 0;
        string namahari;

        Console.Write("Masukan Nama Hari : ");
        //nohari = Convert.ToInt32(Console.ReadLine());
        namahari = Console.ReadLine();

        switch (namahari.ToLower())
        {
            case "senin": nohari = 1; break;
            case "selasa": nohari = 2; break;
            case "rabu": nohari = 3; break;
            case "kamis": nohari = 4; break;
            case "jumaat": nohari = 5; break;
            case "sabtu": nohari = 6; break;
            case "minggu": nohari = 7; break;
            default:
                {
                    Console.WriteLine(namahari + "bukan nama hari");
                    Environment.Exit(1);

                    break;
                }
        }

        Console.WriteLine(namahari + tab + "adalah " + "hari ke-" + nohari);
        Console.ReadLine();
    }

    static void DemoWhile()
    {
        int n, i, faktorial = 1;

        Console.Write("Masukan bilangan bulat : ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write(n + "! =");
        if (n > 1)
        {
            i = n;
            while (i >= 1)
            {
                if (i != 1)
                {
                    Console.Write(i + " x");
                }
                else
                {
                    Console.Write(i + " = ");
                }

                faktorial = faktorial * i;
                i--;
            }
        }
        Console.Write(faktorial);
        Console.ReadLine();
    }

    static void DemoDoWhile()
    {
        int i, hasil = 0;

        Console.WriteLine("Menggunakan While");

        i = 3;
        while (i > 0)
        {
            Console.Write(i + "+ ");
            hasil = i + hasil;
            i--;
        }

        Console.WriteLine(" = " + hasil);

        Console.WriteLine("Menggunakan Do While");

        i = -10;
        do
        {
            Console.WriteLine(i);
            i--;
        }
        while (i > 0);

        Console.ReadLine();
    }

    static void DemoDoWhile2()
    {
        const string USERNAME = "csharp";
        const string PASSWORD = "microsoft";

        string username, password;

        do
        {
            Console.WriteLine("Masukan Username dan Password :");

            Console.Write("Masukan Username : ");

            username = Console.ReadLine();

            Console.Write("Masukan Password : ");

            password = Console.ReadLine();

            Console.WriteLine();
        }
        while (username != USERNAME || password != PASSWORD);

        Console.WriteLine("SELAMAT DATANG");
        Console.ReadLine();
    }

    static void DemoFor()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + "adalah bilangan genap");
            }
            else
            {
                Console.WriteLine(i + "adalah bilangan ganjil");
            }
        }

        Console.ReadLine();
    }

    static void DemoFor2()
    {
        int n, x, jumlah = 0;
        double ratarata;

        Console.Write("Masukan Banyaknya Data: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Data ke-" + i + ": ");

            x = Convert.ToInt32(Console.ReadLine());
            jumlah = jumlah + x;
        }

        ratarata = Convert.ToDouble(jumlah) / n;
        Console.WriteLine("Rata-rata =" + ratarata);

        Console.ReadLine();
    }

    static void DemoForeach1()
    {
        int[] data = { 3, 4, 5, 6 };
        int jumlah;
        double ratarata;

        jumlah = 0;

        // var digunakan jika type data tidak diketahui, dan var akan menyesuaikan dengan type data didalam array
        foreach (var element in data)
        {
            jumlah = jumlah + element;
        }

        ratarata = Convert.ToDouble(jumlah) / data.Length;

        Console.Write("Rata-rata:" + ratarata);

        Console.ReadLine();
    }

    static void PengulanganBersarang()
    {
        //pengulangan bagian luar
        for (int i = 1; i < 10; i++)
        {
            //pengulangan bagian dalam
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i * j + " ");
            }
            Console.WriteLine(); //baris baru
        }
        Console.ReadLine();
    }

}