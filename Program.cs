﻿internal class Program
{
    private static void Main(string[] args)
    {
        int sayi1, sayi2,çevre,sayi3;
        Console.WriteLine("1.Sayıyı giriniz");
        sayi1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2.Sayıyı giriniz");
        sayi2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("3.Sayıyı giriniz");
        sayi3 = Convert.ToInt32(Console.ReadLine());

        çevre = sayi1 + sayi2+sayi3;
        Console.WriteLine(çevre+" üçgenin çevresi  ");

        int uzunluk, yükseklik,alan;
        Console.WriteLine("Uzunluk giriniz");
        uzunluk = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Yükseklik giriniz");
        yükseklik = Convert.ToInt32(Console.ReadLine());

        alan = uzunluk * yükseklik;
        Console.WriteLine("Karenin alanı = "+alan);
        Console.ReadKey();
    }
}