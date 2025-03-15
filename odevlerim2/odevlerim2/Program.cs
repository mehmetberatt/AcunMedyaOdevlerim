using System;
using MathOperations; // Namespace'i içe aktardık

namespace MainProgram
{
    class Program
    {
        static void Main()
        {
            Hesaplama hesap = new Hesaplama();

            int toplam = hesap.Topla(10, 5);
            int carpim = hesap.Carp(10, 5);

            Console.WriteLine($"Toplama Sonucu: {toplam}");
            Console.WriteLine($"Çarpma Sonucu: {carpim}");
        }
    }
}