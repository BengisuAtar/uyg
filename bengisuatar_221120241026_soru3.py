import random

def rastgelesayilar(ogrenci_no):
    if len(ogrenci_no) < 3 or not ogrenci_no.isdigit():
        print("Geçerli bir öğrenci numarası giriniz (en az 3 basamak, sadece rakam).")
        return

    # Son 3 basamağı al ve tam sayıya çevir
    seed_degeri = int(ogrenci_no[-3:])

    # Seed'i ayarla
    random.seed(seed_degeri)

    # 10 adet rastgele sayı üret (0-100 arası)
    sayilar = [random.randint(0, 100) for _ in range(10)]

    print("Seed Değeri (Son 3 basamak):", seed_degeri)
    print("Rastgele Sayılar:", sayilar)

ogrenci_numarasi = "221120241026"
rastgelesayilar(ogrenci_numarasi)
