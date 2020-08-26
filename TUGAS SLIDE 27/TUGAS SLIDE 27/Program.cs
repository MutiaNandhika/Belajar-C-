using System;

namespace TUGAS_SLIDE_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu Pilihan : ");
            Console.WriteLine("1. Segitiga");
            Console.WriteLine("2. Persegi");
            Console.WriteLine("3. Persegi Panjang");
            Console.WriteLine("4. Jajar Genjang");
            Console.WriteLine("5. Trapesium");
            Console.WriteLine("6. Layang-Layang");
            Console.WriteLine("7. Belah Ketupat");
            Console.WriteLine("8. Kubus");
            Console.WriteLine("9. Balok");
            Console.WriteLine("10. Limas");
            Console.WriteLine("11. Tabung");
            Console.WriteLine("12. Prisma");
            Console.WriteLine("13. Bola");
            Console.WriteLine("14. Kerucut");
            Console.Write("Pilihan anda:");
            int bangun_datar_ruang = Convert.ToInt32(Console.ReadLine());
            switch (bangun_datar_ruang)
            {
                case 1:
                    Console.WriteLine("Anda memilih menu Segitiga");
                    break;
                case 2:
                    Console.WriteLine(" Anda memilih menu Persegi");
                    break;
                case 3:
                    Console.WriteLine("Anda memilih menu Persegi Panjang");
                    break;
                case 4:
                    Console.WriteLine("Anda memilih menu Jajar Genjang");
                    break;
                case 5:
                    Console.WriteLine("Anda memilih menu Trapesium");
                    break;
                case 6:
                    Console.WriteLine("Anda memilih menu Layang-Layang");
                    break;
                case 7:
                    Console.WriteLine("Anda memilih menu Belah Ketupat");
                    break;
                case 8:
                    Console.WriteLine("Anda memilih menu Kubus");
                    break;
                case 9:
                    Console.WriteLine("Anda memilih menu Balok");
                    break;
                case 10:
                    Console.WriteLine("Anda memilih menu Limas");
                    break;
                case 11:
                    Console.WriteLine("Anda memilih menu Tabung");
                    break;
                case 12:
                    Console.WriteLine("Anda memilih menu Prisma");
                    break;
                case 13:
                    Console.WriteLine("Anda memilih menu Bola");
                    break;
                case 14:
                    Console.WriteLine("Anda memilih menu Kerucut");
                    break;

            }
        }
    }
}
