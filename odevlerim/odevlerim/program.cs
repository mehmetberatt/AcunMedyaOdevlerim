using System;
//Merhaba Dunya
/*class Program
{
    static void Main()
    {
        Console.WriteLine("Merhaba, Dünya!");
    }
}*/

using System;
//Hesap Makinesi
/*class Program
{
    static void Main()
    {
        Console.WriteLine("Basit Hesap Makinesi 🧮");

        // Kullanıcıdan iki sayı alma
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        // İşlem seçimi
        Console.Write("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
        char islem = Convert.ToChar(Console.ReadLine());

        // İşlem sonucunu hesaplama ve ekrana yazdırma
        switch (islem)
        {
            case '+':
                Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sayi1 + sayi2}");
                break;
            case '-':
                Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sayi1 - sayi2}");
                break;
            case '*':
                Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {sayi1 * sayi2}");
                break;
            case '/':
                if (sayi2 != 0)
                    Console.WriteLine($"Sonuç: {sayi1} / {sayi2} = {(double)sayi1 / sayi2}");
                else
                    Console.WriteLine("Hata: Bir sayı sıfıra bölünemez!");
                break;
            default:
                Console.WriteLine("Hata: Geçersiz işlem!");
                break;
        }
    }
}*/

using System;
//Sayi tahmin oyunu
/*class Program
{
    static void Main()
    {
        Random rastgele = new Random();
        int tutulansayi = rastgele.Next(1, 101); // 1 ile 100 arasında rastgele sayı üret
        int tahmin;
        int tahminSayisi = 0;

        Console.WriteLine("Sayı Tahmin Oyununa Hoş Geldiniz! 🎲");
        Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Hadi tahmin et!");

        do
        {
            Console.Write("Tahmininiz: ");
            tahmin = Convert.ToInt32(Console.ReadLine());
            tahminSayisi++;

            if (tahmin < tutulansayi)
                Console.WriteLine("Daha büyük bir sayı girin!");
            else if (tahmin > tutulansayi)
                Console.WriteLine("Daha küçük bir sayı girin!");
            else
                Console.WriteLine($"Tebrikler! {tahminSayisi} denemede doğru tahmin ettiniz! 🎉");

        } while (tahmin != tutulansayi);
    }
}*/

using System;
//diziler ve donguler

/*class Program
{
    static void Main()
    {
        int[] sayilar = new int[5]; // 5 elemanlı dizi oluştur
        int toplam = 0;

        Console.WriteLine("Lütfen 5 adet sayı giriniz:");

        // Kullanıcıdan sayıları alma
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
            toplam += sayilar[i]; // Sayıyı toplama ekle
        }

        // Ortalama hesaplama
        double ortalama = (double)toplam / sayilar.Length;
        Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");
    }
}*/


