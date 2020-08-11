using System;
using System.Collections.Generic;
using System.Text;

namespace Enkapsulasi_XIRPL1_19_MutiaN
{
    class User
    {
        public string Nama;
        public int NomorID;
        private int noHP;
        protected string RiwayatPasien;
        internal string Bangsal;


        //value default
        public User()
        {
            this.noHP = 087654321;
        }

        public int getNumber()
        {
            return noHP;
        }
        public int setNumber(int newNumber)
        {
            this.noHP = newNumber;
            return noHP;

        }

        public int nomorHp
        {
            get { return noHP; }
            set { this.noHP += value; }
        }

    }
}
