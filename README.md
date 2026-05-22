# Yoğunluk Tabanlı Alışveriş Uygulaması (Konsol Simülasyonu) 🛒📊

Bu proje, kullanıcıların ve işletmelerin alışveriş deneyimini optimize etmek, zaman tasarrufu sağlamak ve yoğunluk yönetimini kolaylaştırmak amacıyla tasarlanmış bir mobil uygulama fikrinin **C# Konsol (Console) simülasyonudur**. 

Bir **Yönetim Bilişim Sistemleri (YBS)** öğrencisi olarak, iş analizi ve nesne yönelimli programlama (OOP) prensiplerini bir araya getirmek amacıyla geliştirilmiştir.

## 🌟 Proje Özellikleri (İş Mantığı)

* **Anlık Yoğunluk Haritası (Simüle):** Mağazaların doluluk oranlarına (%) göre dinamik olarak yoğunluk durumlarını hesaplar (Boş 🟢, Normal 🟡, Yoğun 🔴).
* **Sektörel Filtreleme:** Projenin genişletilebilir ekosistem vizyonuna uygun olarak; Market, Eczane, Giyim, Restoran ve Banka gibi farklı sektörlerdeki işletmeleri filtreleyebilir.
* **Akıllı Sakinlik Önerisi:** Karar destek sistemlerinin temel mantığına dayanarak, sistemdeki en düşük doluluk oranına sahip mağazayı bularak kullanıcıya "en konforlu alışveriş noktasını" önerir.

## 🛠️ Teknik Gereksinimler & Yapı

Uygulama tamamen **C#** diliyle ve Nesne Yönelimli Programlama (OOP) mimarisine uygun olarak geliştirilmiştir:
* **`Magaza` Sınıfı (Class):** İşletme verilerini (Ad, Sektör, Doluluk Oranı) ve yoğunluk durumu hesaplama metotlarını kapsüller (Encapsulation).
* **Dinamik Listeler:** Mağaza verileri `List<Magaza>` yapısı kullanılarak çalışma zamanında (Runtime) yönetilir.
* **Kontrol Blokları & Döngüler:** Kullanıcı menüsü `switch-case` ve `while` döngüleriyle, veri listeleme ve filtreleme işlemleri ise `foreach` döngüleriyle sağlanmıştır.

## 🚀 Nasıl Çalıştırılır?

1. Bu depoyu bilgisayarınıza indirin (Clone veya ZIP olarak).
2. **Visual Studio** veya **VS Code** ile projeyi açın.
3. Projeyi derleyin ve çalıştırın (F5 veya `dotnet run`).

## 🔮 Gelecek Geliştirmeler (Vizyon)
Gerçek hayatta bu projenin; IoT sensörleri, kamera sistemleri, Google Maps API entegrasyonu ve makine öğrenmesi tabanlı yoğunluk tahmin algoritmalarıyla donatılmış bir mobil uygulama (Flutter/React Native) ve bir veri analitiği web paneli (ASP.NET Core / Python) olarak geliştirilmesi hedeflenmektedir.

---
👨‍💻 **Geliştirici:** Kübra Şen - Yönetim Bilişim Sistemleri (YBS) 2. Sınıf Öğrencisi
