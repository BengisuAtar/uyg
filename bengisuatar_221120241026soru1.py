def sifreleogrencinumarasi(ogrenci_no):
    rakamveharf = {
        '0': 'A',
        '1': 'B',
        '2': 'C',
        '3': 'D',
        '4': 'E',
        '5': 'F',
        '6': 'G',
        '7': 'H',
        '8': 'I',
        '9': 'J'
    }
#yukarıda sifreleogrencinumarasi adlı fonksiyon yazıldı.
    sifreli = ""
    for rakam in ogrenci_no:
        if rakam in rakamveharf:
            sifreli += rakamveharf[rakam]
        else:
            print(f"Hatalı karakter bulundu: {rakam}")
            return None
    
    return sifreli

ogrenci_no = "221120241026"
sifreli_sonuc2 = sifreleogrencinumarasi(ogrenci_no)
print("Şifreli sonuç(kendi numaram):", sifreli_sonuc2)

# Kullanıcıdan öğrenci numarası alınır
ogrenci_no = input("Öğrenci numaranızı giriniz: ")

# Yalnızca rakamlardan oluşup oluşmadığı kontrol edilir
if ogrenci_no.isdigit():
    sifreli_sonuc = sifreleogrencinumarasi(ogrenci_no)
    print("Şifreli sonuç:", sifreli_sonuc)
else:
    print("Lütfen sadece rakamlardan oluşan geçerli bir öğrenci numarası giriniz.")
