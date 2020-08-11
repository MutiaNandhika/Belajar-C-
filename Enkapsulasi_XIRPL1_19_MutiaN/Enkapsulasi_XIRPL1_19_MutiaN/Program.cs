using System;

namespace Enkapsulasi_XIRPL1_19_MutiaN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Ini Biodata Dokter=====");

            Dokter dokter1 = new Dokter();
            dokter1.Nama = "Angkasa";
            Console.WriteLine("Nama Dokter:" + dokter1.Nama);
            dokter1.NomorID = 123;
            Console.WriteLine("Nomor ID :" + dokter1.NomorID);
            Console.WriteLine("Riwayat Penyakit :" + dokter1.biodataDokter());
            dokter1.noHP = 089123456;
            Console.WriteLine("Nomor HP :" + dokter1.noHP);

            User user1 = new User();
            user1.Bangsal = "Anggrek U2";
            Console.WriteLine("Dokter berada di Bangsal :" + user1.Bangsal);


            Console.WriteLine("=====Ini Biodata Pasien=====");

            Pasien pasien = new Pasien();
            pasien.Nama = "Jagad";
            Console.WriteLine("Nama Pasien:" + pasien.Nama);
            pasien.NomorID = 456;
            Console.WriteLine("Nomor ID :" + pasien.NomorID);
            Console.WriteLine("Riwayat Penyakit :" + pasien.biodataPasien());
            pasien.noHP = 085432167;
            Console.WriteLine("Nomor HP :" + pasien.noHP);

            User user3 = new User();
            user3.Bangsal = "Melati A6";
            Console.WriteLine( "Pasien berada di Bangsal : " + user3.Bangsal);

            Console.ReadLine();

        }
    }
}
