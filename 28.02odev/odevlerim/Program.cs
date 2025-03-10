// See https://aka.ms/new-console-template for more information
using odevlerim.odev28._02;

//Console.WriteLine("Hello, World!");

Bmw bmw = new();
Mercedes mc = new();
Porsche p = new();

Console.WriteLine(bmw.Yakıt() + mc.Yakıt() + p.Yakıt());

{
    int yas = 33;
    if (yas < 0 || yas > 99)
    {
        Console.WriteLine(" Ya hiç doğmadınız ya da çoktan öldünüz... ");
    }
    else if (yas < 18)
    { Console.WriteLine(" Küçüksünüz "); }
    else if (yas < 35)
    { Console.WriteLine(" Gençsiniz "); }
    else if (yas < 55)
    { Console.WriteLine(" Yetişkinsiniz "); }
    else if (yas < 75)
    { Console.WriteLine(" Yaşlısınız "); }
    else
    { Console.WriteLine("Çok yaşlısınız "); }


    int arabaYasi = 28;
    if (yas < 0 || arabaYasi >30)
    {
        Console.WriteLine(" Ya hiç üretilmedi ya da trafikten men edilmiştir ");
    }
    else if (arabaYasi < 10)
    { Console.WriteLine(" Arabanız yeni "); }
    else if (arabaYasi < 20)
    { Console.WriteLine(" Servise götürmeniz gerekebilir "); }
    else if (arabaYasi < 30)
    { Console.WriteLine(" Arabanız hurdaya çıkabilir "); }

    static void Main()
    {
        List<Calisan> calisanlar = new List<Calisan>
        {
            new Calisan("Ahmet", "Yılmaz", "Genel Müdür (GM)", 50000, "Yönetim"),
            new Calisan("Mehmet", "Kaya", "Müdür (MU)", 30000, "Operasyon"),
            new Calisan("Zeynep", "Demir", "Programcı (PR)", 20000, "Yazılım"),
            new Calisan("Ali", "Çelik", "Stajyer (S)", 5000, "Eğitim")
        };

        decimal toplamMaas = 0;

        Console.WriteLine("Çalışan Listesi:");
        Console.WriteLine("--------------------------------");

        foreach (var calisan in calisanlar)
        {
            calisan.BilgileriYazdir();
            toplamMaas += calisan.Maas;
        }

        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Toplam Maaş: {toplamMaas:C}");
      
    }
}

  




















