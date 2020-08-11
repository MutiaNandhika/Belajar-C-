using System;
using System.Collections.Generic;
using System.Text;

namespace BDApps_XIRPL1_19
{
    class Jajar_Genjang : Bangun_Datar
    {
        public float a;
        public float b;
        public float t;

        public override float luas()
        {
            float luas = a * t;
            Console.WriteLine("Luas Jajar Genjang :" + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = 2 * (a + b);
            Console.WriteLine("Keliling Jajar Genjang :" + keliling);
            return keliling;
        }
    }
}
