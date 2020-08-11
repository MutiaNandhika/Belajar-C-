using System;
using System.Collections.Generic;
using System.Text;

namespace BDApps_XIRPL1_19
{
    class Belah_Ketupat : Bangun_Datar
    {
        public float d1;
        public float d2;
        public float j;

        public override float luas()
        {
            float luas = d1 * d2 / 2;
            Console.WriteLine("Luas Belah ketupat :" + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = 4 * j;
            Console.WriteLine("Keliling Belah ketupat :" + keliling);
            return keliling;
        }
    }
}
