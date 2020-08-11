using System;
using System.Collections.Generic;
using System.Text;

namespace Enkapsulasi_XIRPL1_19_MutiaN
{
    class Pasien : User
    {
        private double nomorHP;
        public string biodataPasien()
        {
            base.RiwayatPasien = "Asma";
            return RiwayatPasien;
        }
        public double noHP
        {
            get { return this.nomorHP; }
            set { this.nomorHP += value; }
        }
    }
}
