using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace odevlerim4
{
    public class Araba
    {
        public Marka MarkaBilgisi { get; set; }
        public Kapı KapıBilgisi { get; set; }
        public Pencere PencereBilgisi { get; set; }
        public Kasa KasaBilgisi { get; set; }
        public double Fiyat { get; set; }

        public Araba(Marka marka, Kapı kapı, Pencere pencere, Kasa kasa, double fiyat)
        {
            MarkaBilgisi = marka;
            KapıBilgisi = kapı;
            PencereBilgisi = pencere;
            KasaBilgisi = kasa;
            Fiyat = fiyat;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($" Arabanın markası {MarkaBilgisi.Ad}, modeli {MarkaBilgisi.Model}, " +
                $"kapı sayısı {KapıBilgisi.KapıSayısı}, pencere sayısı {PencereBilgisi.PencereSayısı}, " +
                $"kasası {KasaBilgisi.Tip}, fiyatı {Fiyat} TL’dir.");
        }
    }
}