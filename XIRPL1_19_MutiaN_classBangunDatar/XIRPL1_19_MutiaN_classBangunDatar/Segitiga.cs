using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL1_19_MutiaN_classBangunDatar
{
    class Segitiga
    {
        //atribut
        int Alas, Tinggi, Samping;

        //method
        public void luas(int Alas, int Tinggi, int Samping)
        {
            int Luas_s = Alas * Tinggi / 2;
            Console.WriteLine("Luas segitiga = " + Luas_s);

        }
        public void keliling(int Alas, int Tinggi, int Samping)
        {
            int Keliling_s = Alas + Tinggi + Samping;
            Console.WriteLine("Keliling segitiga = " + Keliling_s);
        }
    }
}
