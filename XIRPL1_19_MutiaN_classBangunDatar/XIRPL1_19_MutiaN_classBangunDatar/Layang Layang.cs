using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL1_19_MutiaN_classBangunDatar
{
    class Layang_Layang
    {
        //atribut
        int D1, D2, e, f, g, h;

        //method
        public void luas(int D1, int D2, int e, int f, int g, int h)
        {
            int Luas_ll = D1 * D2 / 2;
            Console.WriteLine("Luas layang-layang = " + Luas_ll);

        }
        public void keliling(int D1, int D2, int e, int f, int g, int h)
        {
            int Keliling_ll = e + f + g + h;
            Console.WriteLine("Keliling layang-layang = " + Keliling_ll);
        }
    }
}
