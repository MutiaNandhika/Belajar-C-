using System;
using System.Collections.Generic;
using System.Text;

namespace BDApps_XIRPL1_19
{
    class Segitiga : Bangun_Datar
    {
        public float alas;
        public float tinggi;
        public float samping;

        public override float luas()
        {
            float luas = alas * tinggi / 2;
            Console.WriteLine("Luas Segitiga :" + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = alas + tinggi + samping;
            Console.WriteLine("Keliling segitiga :" + keliling);
            return keliling;
        }
    }
}
