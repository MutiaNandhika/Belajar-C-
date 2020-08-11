using System;

namespace XIRPL1_19_MutiaN_classBangunDatar
{
    class Program
    {
        static void Main(string[] args)
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
            int bangunDatar = Convert.ToInt32(Console.ReadLine());
            switch (bangunDatar)
            {
                case 1:
                    Console.WriteLine(" Anda memilih menu Persegi");
                    Console.WriteLine("Masukkan sisi: ");
                    int sisi = Convert.ToInt32(Console.ReadLine());
                    Persegi persegi1 = new Persegi();
                    persegi1.luas(sisi);
                    persegi1.keliling(sisi);

                    break;
                case 2:
                    
                    Console.WriteLine("Anda memilih menu Persegi Panjang");
                    Console.WriteLine("Masukkan panjang: ");
                    int p = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan lebar: ");
                    int l = Convert.ToInt32(Console.ReadLine());
                    Persegi_Panjang persegipanjang1 = new Persegi_Panjang();
                    persegipanjang1.luas(p, l);
                    persegipanjang1.keliling(p, l);

                    break;
                case 3:
                    

                    Console.WriteLine("Anda memilih menu Segitiga");
                    Console.WriteLine("Masukkan alas: ");
                    int Alas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan tinggi: ");
                    int Tinggi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan samping: ");
                    int Samping = Convert.ToInt32(Console.ReadLine());
                    Segitiga segitiga1 = new Segitiga();
                    segitiga1.luas(Alas, Tinggi, Samping);
                    segitiga1.keliling(Alas, Tinggi, Samping);

                    break;

                case 4:
                    Console.WriteLine("Anda memilih menu Jajar Genjang");
                    Console.WriteLine("Masukkan a: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan b: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan t: ");
                    int t = Convert.ToInt32(Console.ReadLine());
                    Jajar_Genjang jajar_Genjang1 = new Jajar_Genjang();
                    jajar_Genjang1.luas(a, b, t);
                    jajar_Genjang1.keliling(a, b, t);

                    break;

                case 5:
                    Console.WriteLine("Anda memilih menu Trapesium");
                    Console.WriteLine("Masukkan A: ");
                    int A = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan B: ");
                    int B = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan C: ");
                    int C = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan D: ");
                    int D = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan T: ");
                    int T = Convert.ToInt32(Console.ReadLine());
                    Trapesium Trapesium1 = new Trapesium();
                    Trapesium1.luas(A, B, C, D, T);
                    Trapesium1.keliling(A, B, C, D, T);

                    break;
                case 6:
                    Console.WriteLine("Anda memilih menu Layang-Layang");
                    Console.WriteLine("Masukkan D1: ");
                    int D1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan D2: ");
                    int D2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan m: ");
                    int e = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan n: ");
                    int f = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan o: ");
                    int g = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan p: ");
                    int h = Convert.ToInt32(Console.ReadLine());
                    Layang_Layang layang_Layang1 = new Layang_Layang();
                    layang_Layang1.luas(D1, D2, e, f, g, h);
                    layang_Layang1.keliling(D1, D2, e, f, g, h);

                    break;
                case 7:
                    Console.WriteLine("Anda memilih menu Belah Ketupat");
                    Console.WriteLine("Masukkan d1: ");
                    int d1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan d2: ");
                    int d2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan j: ");
                    int j = Convert.ToInt32(Console.ReadLine());
                    Belah_Ketupat belah_Ketupat1 = new Belah_Ketupat();
                    belah_Ketupat1.luas(d1, d2, j);
                    belah_Ketupat1.keliling(d1, d2, j);

                    break;

                    Console.ReadLine();

            }
        }
    }
}
