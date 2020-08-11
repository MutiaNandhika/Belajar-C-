using System;

namespace BDApps_XIRPL1_19
{
    class Program
    {
        static void quit()
        {
            System.Environment.Exit(0);
        }
        static int menu()
        {
            Console.WriteLine("=====BANGUN DATAR=====");
            Console.WriteLine("Menu Pilihan : ");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine("4. Jajar Genjang");
            Console.WriteLine("5. Trapesium");
            Console.WriteLine("6. Layang-Layang");
            Console.WriteLine("7. Belah Ketupat");
            Console.Write("Pilihan anda:");
            int pill = Convert.ToInt32(Console.ReadLine());
            return pill;
        }
        static void Main()
        {
            Bangun_Datar bangundatar = new Bangun_Datar();
            bangundatar.luas();
            bangundatar.keliling();

            int pill = menu();
            
            if (pill == 1)
            {
                Console.WriteLine("Anda memilih menu Persegi");
                Persegi persegi = new Persegi();
                Console.Write("Masukkan sisi:");
                float input = float.Parse(Console.ReadLine());
                persegi.sisi = input;

                persegi.luas();
                persegi.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }

            }
            else if  (pill == 2)
            {
                Console.WriteLine("Anda memilih menu Persegi Panjang");
                Console.WriteLine("Masukkan panjang: ");
                float panjang = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan lebar: ");
                float lebar = float.Parse(Console.ReadLine());
                Persegi_Panjang persegi_Panjang = new Persegi_Panjang();
                persegi_Panjang.panjang = panjang;
                persegi_Panjang.lebar = lebar;

                persegi_Panjang.luas();
                persegi_Panjang.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 3)
            {
                Console.WriteLine("Anda memilih menu Segitiga");
                Console.WriteLine("Masukkan alas: ");
                float alas = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan tinggi: ");
                float tinggi = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan samping: ");
                float samping = float.Parse(Console.ReadLine());
                Segitiga segitiga1 = new Segitiga();
                segitiga1.alas = alas;
                segitiga1.tinggi = tinggi;
                segitiga1.samping = samping;

                segitiga1.luas();
                segitiga1.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 4)
            {
                Console.WriteLine("Anda memilih menu Jajar Genjang");
                Console.WriteLine("Masukkan a: ");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan b: ");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan t: ");
                float t = float.Parse(Console.ReadLine());
                Jajar_Genjang jajar_Genjang1 = new Jajar_Genjang();
                jajar_Genjang1.a = a;
                jajar_Genjang1.b = b;
                jajar_Genjang1.t = t;

                jajar_Genjang1.luas();
                jajar_Genjang1.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 5)
            {
                Console.WriteLine("Anda memilih menu Trapesium");
                Console.WriteLine("Masukkan A: ");
                float A = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan B: ");
                float B = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan C: ");
                float C = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan D: ");
                float D = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan T: ");
                float T = float.Parse(Console.ReadLine());
                Trapesium Trapesium1 = new Trapesium();
                Trapesium1.A = A;
                Trapesium1.B = B;
                Trapesium1.C = C;
                Trapesium1.D = D;
                Trapesium1.T = T;

                Trapesium1.luas();
                Trapesium1.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 6)
            {
                Console.WriteLine("Anda memilih menu Layang-Layang");
                Console.WriteLine("Masukkan D1: ");
                float D1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan D2: ");
                float D2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan m: ");
                float e = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan n: ");
                float f = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan o: ");
                float g = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan p: ");
                float h = float.Parse(Console.ReadLine());
                Layang_Layang layang_Layang1 = new Layang_Layang();
                layang_Layang1.D1 = D1;
                layang_Layang1.D2 = D2;
                layang_Layang1.e = e;
                layang_Layang1.f = f;
                layang_Layang1.g = g;
                layang_Layang1.h = h;

                layang_Layang1.luas();
                layang_Layang1.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 7)
            {
                Console.WriteLine("Anda memilih menu Belah Ketupat");
                Console.WriteLine("Masukkan d1: ");
                float d1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan d2: ");
                float d2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan j: ");
                float j = float.Parse(Console.ReadLine());
                Belah_Ketupat belah_Ketupat1 = new Belah_Ketupat();
                belah_Ketupat1.d1 = d1;
                belah_Ketupat1.d2 = d2;
                belah_Ketupat1.j = j;

                belah_Ketupat1.luas();
                belah_Ketupat1.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else
            {
                System.Console.Clear();
                Console.WriteLine("Menu Tidak tersedia");
                Main();
            }
        }
    }
}
