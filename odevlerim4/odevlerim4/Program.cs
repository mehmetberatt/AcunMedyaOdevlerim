using System;
using odevlerim4;

namespace MainProgram
{
    class Program
    {
        static void Main()
        {
            // 🚗 BMW X5 oluştur
            Marka marka = new Marka("BMW", "X5");
            Kapı kapı = new Kapı(4);
            Pencere pencere = new Pencere(4);
            Kasa kasa = new Kasa("Sedan");
            double fiyat = 2000000;

            // 🏗️ Araba nesnesini oluştur ve bilgileri yazdır
            Araba bmwX5 = new Araba(marka, kapı, pencere, kasa, fiyat);
            bmwX5.BilgileriYazdir();
        }
    }
}