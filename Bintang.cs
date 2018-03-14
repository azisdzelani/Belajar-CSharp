using System;

class DemoBintang
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < i; i++)
            {
                Console.WriteLine(*);
            }
        }
        Console.ReadLine();
    }
}