def ogrencinumarasiistatistik(ogrenci_no):
    # Rakamları listeye dönüştürdü
    if ogrenci_no.isdigit(): #Girilen değerin tamamen rakamlardan oluştuğunu kontrol eder.
        rakamlistesi = [int(rakam) for rakam in ogrenci_no] #Her rakam listeye çevrildi.

        # İstatistik hesaplamaları
        toplam = sum(rakamlistesi)
        ortalama = toplam / len(rakamlistesi)
        enbuyuk = max(rakamlistesi)
        enkucuk = min(rakamlistesi)

        print("Rakam Listesi:", rakamlistesi)
        print("Toplam:", toplam)
        print("Ortalama:", ortalama)
        print("En Büyük Değer:", enbuyuk)
        print("En Küçük Değer:", enkucuk)
    else:
        print("Geçersiz giriş! Lütfen sadece rakamlardan oluşan bir sayı giriniz.")

ogrencinumarasiistatistik("221120241026")

