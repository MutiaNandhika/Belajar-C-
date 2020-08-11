using System;
using System.Collections.Generic;
using System.Text;

namespace BDApps_XIRPL1_19
{
    class Trapesium : Bangun_Datar
    {
        public float A;
        public float B;
        public float C;
        public float D;
        public float T;

        public override float luas()
        {
            float luas = (A + B) * T / 2;
            Console.WriteLine("Luas Trapesium :" + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = A + B + C + D;
            Console.WriteLine("Keliling Trapesium :" + keliling);
            return keliling;
        }
    }
}
