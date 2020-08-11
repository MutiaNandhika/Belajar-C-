using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL1_19_MutiaN_classBangunDatar
{
    class Persegi_Panjang
    {
        //atribut
        int p, l;

        //method
        public void luas(int p, int l)
        {
            int Luas_pp = p * l;
            Console.WriteLine("Luas persegi panjang = " + Luas_pp);

        }
        public void keliling(int p, int l)
        {
            int Keliling_pp = 2 * (p + l);
            Console.WriteLine("Keliling persegi panjang = " + Keliling_pp);
        }
    }
}
