using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL1_19_MutiaN_classBangunDatar
{
    class Persegi
    {

        //atribut
        int sisi;

        //method
        public void luas(int sisi)
        {
            int Luas_p = sisi * sisi;
            Console.WriteLine("Luas persegi = " + Luas_p);
        }
        public void keliling(int sisi)
        {
            int Keliling_p = 4 * sisi;
            Console.WriteLine("Keliling persegi = " + Keliling_p);
        }
    }
}
