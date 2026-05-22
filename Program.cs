using System;
using System.Collections.Generic;

namespace YogunlukTabanliAlisveris
{
    // 1. MAĞAZA SINIFI (Nesne Yönelimli Programlama için)
    class Magaza
    {
        public string Ad { get; set; }
        public string Sektor { get; set; }
        public int DolulukOrani { get; set; } // %0 - %100 arası

        // Constructor (Yapıcı Metot)
        public Magaza(string ad, string sektor, int dolulukOrani)
        {
            Ad = ad;
            Sektor = sektor;
            DolulukOrani = dolulukOrani;
        }

        // Yoğunluk durumunu renk kodları yerine metinsel simüle ediyoruz
        public string YogunlukDurumuGetir()
        {
            if (DolulukOrani < 35)
                return "🟢 Boş (Bekleme Süresi: Az)";
            else if (DolulukOrani >= 35 && DolulukOrani < 75)
                return "🟡 Normal (Bekleme Süresi: Orta)";
            else
                return "🔴 Yoğun (Bekleme Süresi: Fazla)";
        }
    }

    // 2. ANA UYGULAMA SINIFI
    class Program
    {
        // Mağazaları hafızada tutmak için bir List oluşturuyoruz
        static List<Magaza> magazalar = new List<Magaza>();

        static void Main(string[] args)
        {
            // Konsol ekranında Türkçe karakter sorunu yaşanmaması için:
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Örnek Verilerin Yüklenmesi (Simülasyon Verileri)
            VerileriYukle();

            bool devamEtsinMi = true;

            while (devamEtsinMi)
            {
                Console.Clear();
                Console.WriteLine("=============================================");
                Console.WriteLine("   YOĞUNLUK TABANLI ALIŞVERİŞ UYGULAMASI   ");
                Console.WriteLine("=============================================");
                Console.WriteLine("[1] Tüm Mağazaları ve Yoğunluk Durumlarını Gör");
                Console.WriteLine("[2] Sektöre Göre Mağaza Filtrele (Market, Eczane vb.)");
                Console.WriteLine("[3] En Sakin Mağazayı Öner");
                Console.WriteLine("[4] Çıkış");
                Console.WriteLine("---------------------------------------------");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçin: ");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        TumMagazalariListele();
                        break;
                    case "2":
                        SektoreGoreFiltrele();
                        break;
                    case "3":
                        EnSakinMagazayiOner();
                        break;
                    case "4":
                        devamEtsinMi = false;
                        Console.WriteLine("\nUygulamadan çıkılıyor. İyi günler!");
                        break;
                    default:
                        Console.WriteLine("\nGeçersiz bir seçim yaptınız! Devam etmek için Enter'a basın.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // Simülasyon veritabanı (Uygulama açıldığında hazır gelecek mağazalar)
        static void VerileriYukle()
        {
            magazalar.Add(new Magaza("A-101 Merkez", "Market", 85));
            magazalar.Add(new Magaza("Migros Avm", "Market", 20));
            magazalar.Add(new Magaza("Şifa Eczanesi", "Eczane", 40));
            magazalar.Add(new Magaza("Lc Waikiki Merkez", "Giyim", 90));
            magazalar.Add(new Magaza("Zümrüt Restoran", "Restoran", 60));
            magazalar.Add(new Magaza("Merkez Bankası Şubesi", "Banka", 15));
        }

        // Özellik 1: Tüm Mağazaları Listeleme
        static void TumMagazalariListele()
        {
            Console.Clear();
            Console.WriteLine("--- TÜM MAĞAZALARIN ANLIK DURUMU --- \n");

            foreach (var magaza in magazalar)
            {
                Console.WriteLine($"Mağaza: {magaza.Ad}");
                Console.WriteLine($"Sektör: {magaza.Sektor}");
                Console.WriteLine($"Doluluk: %{magaza.DolulukOrani}");
                Console.WriteLine($"Durum: {magaza.YogunlukDurumuGetir()}");
                Console.WriteLine("-----------------------------------");
            }

            Console.WriteLine("\nAna menüye dönmek için Enter'a basın...");
            Console.ReadLine();
        }

        // Özellik 2: Sektöre Göre Filtreleme (Ekosistemin genişletilmesi fikri için)
        static void SektoreGoreFiltrele()
        {
            Console.Clear();
            Console.WriteLine("--- SEKTÖRE GÖRE FİLTRELEME ---");
            Console.Write("Aradığınız sektörü yazın (Market, Giyim, Eczane, Restoran, Banka): ");
            string arananSektor = Console.ReadLine();

            Console.WriteLine($"\n--- {arananSektor.ToUpper()} Sektöründeki Mağazalar --- \n");
            bool bulunduMu = false;

            foreach (var magaza in magazalar)
            {
                // Kullanıcı küçük/büyük harf yazsa da eşleşsin diye Equals kullanıyoruz
                if (magaza.Sektor.Equals(arananSektor, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Mağaza: {magaza.Ad} -> Durum: {magaza.YogunlukDurumuGetir()} (Doluluk: %{magaza.DolulukOrani})");
                    bulunduMu = true;
                }
            }

            if (!bulunduMu)
            {
                Console.WriteLine("Bu sektörde kayıtlı bir işletme bulunamadı.");
            }

            Console.WriteLine("\nAna menüye dönmek için Enter'a basın...");
            Console.ReadLine();
        }

        // Özellik 3: Konum Tabanlı/Akıllı Öneri Algoritması Simülasyonu
        static void EnSakinMagazayiOner()
        {
            Console.Clear();
            Console.WriteLine("--- AKILLI SAKİNLİK ÖNERİSİ --- \n");

            if (magazalar.Count == 0)
            {
                Console.WriteLine("Sistemde mağaza bulunamadı.");
                return;
            }

            // En düşük doluluk oranına sahip mağazayı bulan basit bir algoritma
            Magaza enSakinMagaza = magazalar[0];

            foreach (var magaza in magazalar)
            {
                if (magaza.DolulukOrani < enSakinMagaza.DolulukOrani)
                {
                    enSakinMagaza = magaza;
                }
            }

            Console.WriteLine("💡 Uygulama Önerisi 💡");
            Console.WriteLine("Şu an gitmeniz için en konforlu ve bekleme süresi en az olan yer:");
            Console.WriteLine($"👉 {enSakinMagaza.Ad} ({enSakinMagaza.Sektor} sektörü)");
            Console.WriteLine($"Anlık Doluluk Oranı: %{enSakinMagaza.DolulukOrani}");
            Console.WriteLine($"Durumu: {enSakinMagaza.YogunlukDurumuGetir()}");

            Console.WriteLine("\nAna menüye dönmek için Enter'a basın...");
            Console.ReadLine();
        }
    }
}
