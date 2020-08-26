using System;

namespace TUGAS_SLIDE_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            for (int a = 1; a <= 10; a++)
            {
                Console.Write( a + ",");
            }

            Console.WriteLine(); 
            for (int b = 1; b <= 16; b= b * 2)
            {
                Console.Write(b + ",");
            }

            Console.WriteLine();
            for (int d = 1; d < 28; d = d * 3)
            {
                Console.Write(d + "," );
            }

            Console.WriteLine();
            for (int e = 3; e <= 27 ; e = e * 3)
            {
                Console.Write(e + ",");
            }

            Console.WriteLine();
            for (int f = 2; f <= 32; f = f * 4)
            {
                Console.Write(f + ",");
            }

            Console.WriteLine();
            for (int i = 2; i <= 72; i = i * 6)
            {
                Console.Write(i + ",");
            }
            Console.ReadLine();
        }
    }
}
