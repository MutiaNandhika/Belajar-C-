using System;
using System.Collections.Generic;
using System.Text;

namespace Enkapsulasi_XIRPL1_19_MutiaN
{
    class Dokter : User
    {
        private double nomorHP;
        public string biodataDokter()
        {
            base.RiwayatPasien = "Magh";
            return RiwayatPasien;
        }
        public double noHP
        {
            get { return this.nomorHP; }
            set { this.nomorHP += value; }
        }
    }
}
