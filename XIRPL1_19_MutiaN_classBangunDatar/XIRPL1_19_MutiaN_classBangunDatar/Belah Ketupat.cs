using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL1_19_MutiaN_classBangunDatar
{
    class Belah_Ketupat
    {
        //atribut
        int d1, d2, j;

        //method
        public void luas(int d1, int d2, int j)
        {
            int Luas_bk = d1 * d2 / 2;
            Console.WriteLine("Luas belah ketupat = " + Luas_bk);

        }
        public void keliling(int d1, int d2, int j)
        {
            int Keliling_bk = 4 * j;
            Console.WriteLine("Keliling belah ketupat = " + Keliling_bk);
        }
    }
}
