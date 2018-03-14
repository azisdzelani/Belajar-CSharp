using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabArray
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoArray1();
            Console.WriteLine(" ============ ");

            DemoArray2();
            Console.WriteLine(" ============ ");
            DemoArray3();
            Console.WriteLine(" ============");
            DemoArray4();
            Console.WriteLine(" ============");
            DemoArray5();

            Console.ReadKey();
        }

        static void DemoArray1()
        {
            //inisiasi array
            int[] A = new int[5];

            // mengisi nilai kedalam elemen array
            for (int i = 0; i < 5; i++)
            {
                A[i] = (i + 1) * 1000;
            }

            Console.WriteLine("Nilai Element Array A: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("A[" + i + "] = ");
                Console.WriteLine(A[i]);
            }
        }

        static void DemoArray2()
        {
            //membuat array
            char[] vokal = new char[5];

            vokal[0] = 'a';
            vokal[1] = 'i';
            vokal[2] = 'u';
            vokal[3] = 'e';
            vokal[4] = '0';

            Console.WriteLine("Huruf Vokal");
            for(int i=0; i< 5; i++)
            {
                Console.WriteLine(vokal[i]);
            }
        }

        static void DemoArray3()
        {
            int[] A = new int[] { 1000, 2000, 3000, 4000, 5000 };
            char[] vokal = new char[] { 'a', 'i', 'u', 'e', 'o' };

            Console.WriteLine("Element dalam Array A :");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Element dalam Array vokal: ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(vokal[i] + " ");
            }

            Console.WriteLine();
        }

        //Array Multidimensi
        static void DemoArray4()
        {
            //cara membuat array dua dimensi (4 x 3)
            int[,] tabel = new int[4, 3];

            //mengisi nilai kedalam elemen array
            //baris pertama
            tabel[0, 0] = 1;
            tabel[0, 1] = 5;
            tabel[0, 2] = 3;
            
            //baris kedua
            tabel[1, 0] = 2;
            tabel[1, 1] = 4;
            tabel[1, 2] = 1;

            //baris ketiga
            tabel[2, 0] = 3;
            tabel[2, 1] = 2;
            tabel[2, 2] = 4;

            //baris keempat
            tabel[3, 0] = 4;
            tabel[3, 1] = 3;
            tabel[3, 2] = 2;

            //menampilkan 
            Console.WriteLine("Array Dua Dimensi");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tabel[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }

        static void DemoArray5()
        {
            int[] array1D = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Jumlah Dimensi : " + array1D.Rank);
       
            Console.WriteLine("Jumlah Element : " + array1D.Length);

            Console.Write("\n isi array: ");
            for (int i = 0; i < array1D.Length; i++)
            {
                Console.Write(array1D[i] + " ");
            }

        }

        static void DemoArray6()
        {
            int[] array1D = new int[5];
            int nilai;
            for (int i = 0; i < array1D.Length; i++)
            {
                Console.Write("Masukan Array ke - " + array1D[i]);
                nilai = int.Parse(Console.ReadLine());
                array1D[i] = nilai;

            }

            

        }
    }
}
