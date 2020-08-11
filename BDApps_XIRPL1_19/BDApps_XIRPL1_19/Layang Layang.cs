using System;
using System.Collections.Generic;
using System.Text;

namespace BDApps_XIRPL1_19
{
    class Layang_Layang : Bangun_Datar
    {
        public float D1;
        public float D2;
        public float e;
        public float f;
        public float g;
        public float h;

        public override float luas()
        {
            float luas = D1 * D2 / 2;
            Console.WriteLine("Luas layang layang :" + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = e + f + g + h;
            Console.WriteLine("Keliling layang layang :" + keliling);
            return keliling;
        }
    }
}
