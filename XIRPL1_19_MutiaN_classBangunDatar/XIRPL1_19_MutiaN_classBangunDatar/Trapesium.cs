using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL1_19_MutiaN_classBangunDatar
{
    class Trapesium
    {
        //atribut
        int A, B, C, D, T;

        //method
        public void luas(int A, int B, int C, int D, int T)
        {
            int Luas_tp = (A + B) * T / 2;
            Console.WriteLine("Luas trapesium = " + Luas_tp);

        }
        public void keliling(int A, int B, int C, int D, int T)
        {
            int Keliling_tp = A + B + C + D;
            Console.WriteLine("Keliling trapesium = " + Keliling_tp);
        }
    }
}
