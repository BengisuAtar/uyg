using System;
using System.Collections.Generic;

class Program
{
    // Personel sınıfı, bir personelin bilgilerini tutar
    public class Personel
    {
        // Personel özellikleri
        public string Ad { get; set; } // Personelin adı
        public string Soyad { get; set; } // Personelin soyadı
        public string Pozisyon { get; set; } // Personelin pozisyonu
        public decimal Ucret { get; set; } // Personelin ücreti
        public int Kidem { get; set; } // Personelin kıdemi (yıl olarak)
        public string Subesi { get; set; } // Personelin çalıştığı şube
        public bool Izinli { get; set; } // Personelin izin durumu

        // Personel sınıfının metodu
        public Personel(string ad, string soyad, string pozisyon, decimal ucret, int kidem, string subesi)
        {
            Ad = ad;
            Soyad = soyad;
            Pozisyon = pozisyon;
            Ucret = ucret;
            Kidem = kidem;
            Subesi = subesi;
            Izinli = false; // Başlangıçta izinli değil
        }

        // İzin verme metodu
        public void IzinVer()
        {
            Izinli = true; // İzinli durumu true olarak ayarlanır
            Console.WriteLine(Ad + Soyad + " izne ayrıldı."); // İzin verildi mesajı
        }

        // İzni kaldırma metodu
        public void IzinKaldir()
        {
            Izinli = false; // İzinli durumu false olarak ayarlanır
            Console.WriteLine(Ad + Soyad + " izni kaldırıldı."); // İzin kaldırıldı mesajı
        }
    }

    // Personel yönetim sınıfı, personel işlemlerini yönetir
    public class PersonelYonetimi
    {
        // Personel listesini tutan bir liste
        private List<Personel> personelListesi = new List<Personel>();

        // Yeni personel ekleme metodu
        public void PersonelEkle(Personel personel)
        {
            personelListesi.Add(personel); // Personel listeye eklenir
            Console.WriteLine(personel.Ad + personel.Soyad + " başarıyla eklendi."); // Başarı mesajı
        }

        // Personel çıkarma metodu
        public void PersonelCikar(string ad, string soyad)
        {
            // Belirtilen adı ve soyadı taşıyan personeli bul
            var personel = personelListesi.Find(b => b.Ad == ad && b.Soyad == soyad);
            if (personel != null)
            {
                personelListesi.Remove(personel); // Personel listeden çıkarılır
                Console.WriteLine(ad + soyad + " başarıyla çıkarıldı."); // Başarı mesajı
            }
            else
            {
                Console.WriteLine(ad + soyad + " bulunamadı."); // Personel bulunamazsa mesaj
            }
        }

        // İzin verme metodu
        public void IzinVer(string ad, string soyad)
        {
            // Belirtilen adı ve soyadı taşıyan personeli bul
            var personel = personelListesi.Find(b => b.Ad == ad && b.Soyad == soyad);
            if (personel != null)
            {
                personel.IzinVer(); // İzin verilir
            }
            else
            {
                Console.WriteLine(ad + soyad + " bulunamadı."); // Personel bulunamazsa mesaj
            }
        }

        // İzni kaldırma metodu
        public void IzinKaldir(string ad, string soyad)
        {
            // Belirtilen adı ve soyadı taşıyan personeli bul
            var personel = personelListesi.Find(p => p.Ad == ad && p.Soyad == soyad);
            if (personel != null)
            {
                personel.IzinKaldir(); // İzin kaldırılır
            }
            else
            {
                Console.WriteLine(ad + soyad + " bulunamadı."); // Personel bulunamazsa mesaj
            }
        }

        // Tüm personeli listeleme metodu
        public void PersonelListele()
        {
            Console.WriteLine("Personel Listesi:"); // Liste başlığı
            foreach (var personel in personelListesi)
            {
                // Her bir personelin bilgilerini yazdır
                Console.WriteLine(personel.Ad + personel.Soyad + " Pozisyon: " + personel.Pozisyon + " Ücret: " + personel.Ucret + " Kıdem: " + personel.Kidem + " Şube: " + personel.Subesi + " İzinli: " + personel.Izinli);
            }
        }
    }

    // Programın başlangıç noktası
    static void Main(string[] args)
    {
        PersonelYonetimi yonetim = new PersonelYonetimi(); // Personel yönetimi nesnesi oluştur
        string secim; // Kullanıcının seçimlerini tutacak değişken

        // Kullanıcıdan işlem seçeneği almak için döngü
        do
        {
            Console.WriteLine("\nYapmak istediğiniz işlemi seçin:"); // İşlem seçenekleri
            Console.WriteLine("1. Personel Ekle");
            Console.WriteLine("2. Personel Çıkar");
            Console.WriteLine("3. İzin Ver");
            Console.WriteLine("4. İzin Kaldır");
            Console.WriteLine("5. Personel Listele");
            Console.WriteLine("6. Çıkış");
            Console.Write("Seçiminiz: ");
            secim = Console.ReadLine(); // Kullanıcının seçimini al

            // Kullanıcının seçimine göre işlem yap
            switch (secim)
            {
                case "1":
                    // Yeni personel eklemek için gerekli bilgileri al
                    Console.Write("Ad: ");
                    string ad = Console.ReadLine();
                    Console.Write("Soyad: ");
                    string soyad = Console.ReadLine();
                    Console.Write("Pozisyon: ");
                    string pozisyon = Console.ReadLine();
                    Console.Write("Ücret: ");
                    decimal ucret = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Kıdem: ");
                    int kidem = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Şube: ");
                    string subesi = Console.ReadLine();
                    // Yeni personeli ekle
                    yonetim.PersonelEkle(new Personel(ad, soyad, pozisyon, ucret, kidem, subesi));
                    break;

                case "2":
                    // Çıkarılacak personelin bilgilerini al
                    Console.Write("Çıkarılacak personelin Adı: ");
                    string cAd = Console.ReadLine();
                    Console.Write("Çıkarılacak personelin Soyadı: ");
                    string cSoyad = Console.ReadLine();
                    // Personeli çıkar
                    yonetim.PersonelCikar(cAd, cSoyad);
                    break;

                case "3":
                    // İzin verilecek personelin bilgilerini al
                    Console.Write("İzin verilecek personelin Adı: ");
                    string izinAd = Console.ReadLine();
                    Console.Write("İzin verilecek personelin Soyadı: ");
                    string izinSoyad = Console.ReadLine();
                    // İzin ver
                    yonetim.IzinVer(izinAd, izinSoyad);
                    break;

                case "4":
                    // İzni kaldırılacak personelin bilgilerini al
                    Console.Write("İzni kaldırılacak personelin Adı: ");
                    string izinKaldirAd = Console.ReadLine();
                    Console.Write("İzni kaldırılacak personelin Soyadı: ");
                    string izinKaldirSoyad = Console.ReadLine();
                    // İzni kaldır
                    yonetim.IzinKaldir(izinKaldirAd, izinKaldirSoyad);
                    break;

                case "5":
                    // Tüm personeli listele
                    yonetim.PersonelListele();
                    break;

                case "6":
                    // Çıkış mesajı
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;

                default:
                    // Geçersiz seçim durumunda mesaj
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                    break;
            }
        } while (secim != "6"); // Kullanıcı çıkış yapana kadar döngü devam eder
        Console.ReadKey(); // Programın sonlanmasını bekle
    }
}