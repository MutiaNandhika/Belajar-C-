using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL1_19_MutiaN_classBangunDatar
{
    class Jajar_Genjang
    {
        //atribut
        int a, b, t;

        //method
        public void luas(int a, int b, int t)
        {
            int Luas_jg = a * t;
            Console.WriteLine("Luas jajar genjang = " + Luas_jg);

        }
        public void keliling(int a, int b, int t)
        {
            int Keliling_jg = 2 * (a + b);
            Console.WriteLine("Keliling jajar genjang = " + Keliling_jg);
        }
    }
}
