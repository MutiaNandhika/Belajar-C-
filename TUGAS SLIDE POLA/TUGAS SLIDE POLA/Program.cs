using System;

namespace TUGAS_SLIDE_POLA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan panjang pola: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPola 1\n");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPola 2\n");

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPola 3\n");

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.WriteLine("\npola 4\n");
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = n; j >= i; j--)
                {
                    Console.Write("*");
                }
                for (int j = n; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\npola 5\n");
            for (int i = 1; i <= n; i++)
            {
                if ((i == 1) || (i == n))
                {
                    for (int j = 1; j <= n; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if ((j == 1) || (j == n))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\nPola ke 6\n");

            for (int i = 0; i < (2 * n) + 1; i++)
            {

                for (int j = 0; j < (2 * n) + 1; j++)
                {

                    if (i < n)
                    {
                        if ((j > n - i) && (j < n + i))
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    else
                    {

                        if ((j > i - n) && (j < 3 * n - i))
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }

                    }
                }
                Console.WriteLine();

            }
        }
    }
}
