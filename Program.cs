﻿internal class Program
{

    static public string ogrenci(string ad,string soyad)
    {
        Console.WriteLine("ad");
      ad=Console.ReadLine();
        soyad=Console.ReadLine();
        return ad;
      return soyad;
    }
    static public int Hesapla(int not1,int not2)
    {
        not1= Convert.ToInt16(Console.ReadLine());
        not2 = Convert.ToInt16(Console.ReadLine());
      int ort = (not1 + not2) / 2;
        return ort;
    }
    
    private static void Main(string[] args)
    {
        Console.WriteLine(ogrenci); 
        Console.WriteLine(Hesapla); 
        Console.ReadKey();
    }
}