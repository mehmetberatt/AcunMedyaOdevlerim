using System;

namespace Odev
{
    class User
    {
        // Private değişkenler (dışarıdan erişilemez)
        private string adSoyad;
        private int yas;

        // Public özellik (dışarıdan erişilebilir)
        public string Email { get; set; }

        // Getter ve Setter Metotları
        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string yeniAdSoyad)
        {
            adSoyad = yeniAdSoyad;
        }

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int yeniYas)
        {
            if (yeniYas >= 0) // Negatif yaş girilmesini önlemek için kontrol
            {
                yas = yeniYas;
            }
            else
            {
                Console.WriteLine("Yaş negatif olamaz!");
            }
        }

        // Kullanıcı bilgilerini ekrana yazdıran metot
        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad Soyad: {adSoyad}");
            Console.WriteLine($"Yaş: {yas}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Yeni bir kullanıcı oluştur
            User kullanici = new User();

            // Setter metotlarını kullanarak değer atama
            kullanici.SetAdSoyad("Mehmet Berat Turan");
            kullanici.SetYas(20);
            kullanici.Email = "mehmetberattrn@gmail.com";

            // Kullanıcı bilgilerini ekrana yazdır
            Console.WriteLine("\n Kullanıcı Bilgileri:");
            kullanici.BilgileriGoster();
        }
    }
}