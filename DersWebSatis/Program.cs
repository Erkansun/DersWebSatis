using DersWebSatis.Model;
using System;

namespace DersWebSatis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbHelper dbHelper = new DbHelper();

            #region Kullanici Listesi Ekle
            //List<Kullanici> kullanicilar = new List<Kullanici>
            //{
            //    new Kullanici { AdSoyad = "Ahmet Yılmaz", Email = "ahmet@gmail.com", Sifre = "1234" },
            //    new Kullanici { AdSoyad = "Ayşe Demir", Email = "ayse@gmail.com", Sifre = "abcd" },
            //    new Kullanici { AdSoyad = "Mehmet Can", Email = "mehmetc@gmail.com", Sifre = "pass123" },
            //    new Kullanici { AdSoyad = "Zeynep Aydın", Email = "zeynep.a@gmail.com", Sifre = "z123" },
            //    new Kullanici { AdSoyad = "Burak Er", Email = "burak@gmail.com", Sifre = "ber123" },
            //    new Kullanici { AdSoyad = "Selin Kurt", Email = "selinkurt@gmail.com", Sifre = "skurt!" },
            //    new Kullanici { AdSoyad = "Emre Şahin", Email = "emre.sh@gmail.com", Sifre = "emre@12" },
            //    new Kullanici { AdSoyad = "Elif Yalçın", Email = "elif.y@gmail.com", Sifre = "elifpass" },
            //    new Kullanici { AdSoyad = "Hasan Koç", Email = "hasan.koc@gmail.com", Sifre = "hkoç321" },
            //    new Kullanici { AdSoyad = "Ceren Bal", Email = "ceren.bal@gmail.com", Sifre = "ceren123" },
            //    new Kullanici { AdSoyad = "Fatma Yıldız", Email = "fatmay@gmail.com", Sifre = "fatma!" },
            //    new Kullanici { AdSoyad = "Mert Öz", Email = "mert.oz@gmail.com", Sifre = "mertpass" },
            //    new Kullanici { AdSoyad = "Nazlı Ak", Email = "nazli.ak@gmail.com", Sifre = "naz123" },
            //    new Kullanici { AdSoyad = "Kemal Ar", Email = "kemalar@gmail.com", Sifre = "kar123" },
            //    new Kullanici { AdSoyad = "Buse Ekin", Email = "buse.ekin@gmail.com", Sifre = "busepass" },
            //    new Kullanici { AdSoyad = "Onur Gül", Email = "onurg@gmail.com", Sifre = "onur!" },
            //    new Kullanici { AdSoyad = "Seda Tunç", Email = "seda.tunc@gmail.com", Sifre = "sedat123" },
            //    new Kullanici { AdSoyad = "Tamer Aksu", Email = "tameraksu@gmail.com", Sifre = "tamer@1" },
            //    new Kullanici { AdSoyad = "Melis Ulu", Email = "melisulu@gmail.com", Sifre = "melis!" },
            //    new Kullanici { AdSoyad = "Baran Yiğit", Email = "baran.yigit@gmail.com", Sifre = "baran123" },
            //};

            //string sonucKullaniciEkle = dbHelper.KullaniciEkleToplu(data: kullanicilar);
            //Console.Write(sonucKullaniciEkle);
            #endregion


            #region Ürün Ketegorisi Ekle Toplu
            //var urunKategoriler = new List<UrunKategori>
            //{
            //    new UrunKategori { Adi = "Elektronik", Aciklama = "Elektronik ürünler", KategoriNo = "ELK001", Sira = 1 },
            //    new UrunKategori { Adi = "Ev Eşyası", Aciklama = "Ev için temel eşyalar", KategoriNo = "EVS002", Sira = 2 },
            //    new UrunKategori { Adi = "Giyim", Aciklama = "Kadın ve erkek giyim", KategoriNo = "GIM003", Sira = 3 },
            //    new UrunKategori { Adi = "Kırtasiye", Aciklama = "Ofis ve okul gereçleri", KategoriNo = "KRT004", Sira = 4 },
            //    new UrunKategori { Adi = "Bilgisayar", Aciklama = "Donanım ve yazılım", KategoriNo = "BLG005", Sira = 5 },
            //    new UrunKategori { Adi = "Telefon", Aciklama = "Cep telefonları", KategoriNo = "TEL006", Sira = 6 },
            //    new UrunKategori { Adi = "Kitap", Aciklama = "Roman, ders kitabı vb.", KategoriNo = "KTP007", Sira = 7 },
            //    new UrunKategori { Adi = "Mutfak", Aciklama = "Mutfak araç gereçleri", KategoriNo = "MTK008", Sira = 8 },
            //    new UrunKategori { Adi = "Kozmetik", Aciklama = "Bakım ve kozmetik ürünleri", KategoriNo = "KOZ009", Sira = 9 },
            //    new UrunKategori { Adi = "Oyuncak", Aciklama = "Çocuk oyuncakları", KategoriNo = "OYN010", Sira = 10 },
            //    new UrunKategori { Adi = "Ayakkabı", Aciklama = "Spor ve klasik ayakkabılar", KategoriNo = "AYK011", Sira = 11 },
            //    new UrunKategori { Adi = "Bahçe", Aciklama = "Bahçe ürünleri", KategoriNo = "BHC012", Sira = 12 },
            //    new UrunKategori { Adi = "Spor", Aciklama = "Spor malzemeleri", KategoriNo = "SPR013", Sira = 13 },
            //    new UrunKategori { Adi = "Oto Aksesuar", Aciklama = "Araç içi-dışı aksesuarlar", KategoriNo = "OTO014", Sira = 14 },
            //    new UrunKategori { Adi = "Sağlık", Aciklama = "Medikal ürünler", KategoriNo = "SGL015", Sira = 15 },
            //    new UrunKategori { Adi = "Dekorasyon", Aciklama = "Ev dekoratif ürünler", KategoriNo = "DKR016", Sira = 16 },
            //    new UrunKategori { Adi = "Beyaz Eşya", Aciklama = "Ev aletleri", KategoriNo = "BYE017", Sira = 17 },
            //    new UrunKategori { Adi = "Hobi", Aciklama = "Hobi ürünleri", KategoriNo = "HOB018", Sira = 18 },
            //    new UrunKategori { Adi = "Anne & Bebek", Aciklama = "Anne ve bebek ürünleri", KategoriNo = "ANB019", Sira = 19 },
            //    new UrunKategori { Adi = "Kamp & Outdoor", Aciklama = "Kamp ekipmanları", KategoriNo = "KMP020", Sira = 20 },
            //};

            //string urunKategorilerTopluEkle = dbHelper.UrunKategorisiEkleToplu(dataKategoriler: urunKategoriler);
            //Console.WriteLine(urunKategorilerTopluEkle);

            #endregion


            #region Ürün Ekle Toplu
            //var urunler = new List<Urun>
            //{
            //    new Urun { Adi = "iPhone 13", BirimFiyat = 39500, Stok = 15, BarkodNo = "869123400001", Sira = 1, KategoriId = 6 },
            //    new Urun { Adi = "Samsung Galaxy S22", BirimFiyat = 32500, Stok = 20, BarkodNo = "869123400002", Sira = 2, KategoriId = 6 },
            //    new Urun { Adi = "Dell XPS 13", BirimFiyat = 45000, Stok = 10, BarkodNo = "869123400003", Sira = 3, KategoriId = 5 },
            //    new Urun { Adi = "HP Yazıcı", BirimFiyat = 2700, Stok = 35, BarkodNo = "869123400004", Sira = 4, KategoriId = 5 },
            //    new Urun { Adi = "Tefal Tava Seti", BirimFiyat = 950, Stok = 50, BarkodNo = "869123400005", Sira = 5, KategoriId = 8 },
            //    new Urun { Adi = "Nike Air Max", BirimFiyat = 1850, Stok = 25, BarkodNo = "869123400006", Sira = 6, KategoriId = 11 },
            //    new Urun { Adi = "Philips Saç Kurutma Makinesi", BirimFiyat = 450, Stok = 40, BarkodNo = "869123400007", Sira = 7, KategoriId = 9 },
            //    new Urun { Adi = "Vestel Buzdolabı", BirimFiyat = 22500, Stok = 8, BarkodNo = "869123400008", Sira = 8, KategoriId = 17 },
            //    new Urun { Adi = "LED TV 55''", BirimFiyat = 16500, Stok = 12, BarkodNo = "869123400009", Sira = 9, KategoriId = 1 },
            //    new Urun { Adi = "Koltuk Takımı", BirimFiyat = 34500, Stok = 4, BarkodNo = "869123400010", Sira = 10, KategoriId = 2 },
            //    new Urun { Adi = "Roman: Kürk Mantolu Madonna", BirimFiyat = 120, Stok = 100, BarkodNo = "869123400011", Sira = 11, KategoriId = 7 },
            //    new Urun { Adi = "Faber-Castell Kalem Seti", BirimFiyat = 60, Stok = 200, BarkodNo = "869123400012", Sira = 12, KategoriId = 4 },
            //    new Urun { Adi = "Sporcu Eldiveni", BirimFiyat = 150, Stok = 30, BarkodNo = "869123400013", Sira = 13, KategoriId = 13 },
            //    new Urun { Adi = "Oto Cam Suyu", BirimFiyat = 45, Stok = 80, BarkodNo = "869123400014", Sira = 14, KategoriId = 14 },
            //    new Urun { Adi = "Bitki Toprağı 10kg", BirimFiyat = 75, Stok = 60, BarkodNo = "869123400015", Sira = 15, KategoriId = 12 },
            //    new Urun { Adi = "Bebek Bezi 60'lı", BirimFiyat = 320, Stok = 90, BarkodNo = "869123400016", Sira = 16, KategoriId = 19 },
            //    new Urun { Adi = "Çadır 3 Kişilik", BirimFiyat = 1650, Stok = 18, BarkodNo = "869123400017", Sira = 17, KategoriId = 20 },
            //    new Urun { Adi = "Koltuk Minderi", BirimFiyat = 110, Stok = 50, BarkodNo = "869123400018", Sira = 18, KategoriId = 16 },
            //    new Urun { Adi = "Dijital Termometre", BirimFiyat = 95, Stok = 55, BarkodNo = "869123400019", Sira = 19, KategoriId = 15 },
            //    new Urun { Adi = "Erkek Gömlek", BirimFiyat = 450, Stok = 70, BarkodNo = "869123400020", Sira = 20, KategoriId = 3 },
            //};

            //var urunEkleTopluSekilde = dbHelper.UrunEkleToplu(urunToplu: urunler);
            //Console.WriteLine(urunEkleTopluSekilde);

            //var urunlerDevam = new List<Urun>
            //{
            //    new Urun { Adi = "Bluetooth Kulaklık", BirimFiyat = 1250, Stok = 60, BarkodNo = "869123400100", Sira = 21, KategoriId = 1 },
            //    new Urun { Adi = "Akıllı Saat", BirimFiyat = 2100, Stok = 40, BarkodNo = "869123400101", Sira = 22, KategoriId = 1 },
            //    new Urun { Adi = "Çamaşır Makinesi", BirimFiyat = 18500, Stok = 10, BarkodNo = "869123400102", Sira = 23, KategoriId = 17 },
            //    new Urun { Adi = "Tost Makinesi", BirimFiyat = 1750, Stok = 18, BarkodNo = "869123400103", Sira = 24, KategoriId = 17 },
            //    new Urun { Adi = "Kadın Tişört", BirimFiyat = 250, Stok = 90, BarkodNo = "869123400104", Sira = 25, KategoriId = 3 },
            //    new Urun { Adi = "Erkek Kot Pantolon", BirimFiyat = 550, Stok = 70, BarkodNo = "869123400105", Sira = 26, KategoriId = 3 },
            //    new Urun { Adi = "Ofis Sandalyesi", BirimFiyat = 1600, Stok = 25, BarkodNo = "869123400106", Sira = 27, KategoriId = 2 },
            //    new Urun { Adi = "Masa Lambası", BirimFiyat = 350, Stok = 55, BarkodNo = "869123400107", Sira = 28, KategoriId = 2 },
            //    new Urun { Adi = "Yazıcı Kartuşu", BirimFiyat = 300, Stok = 150, BarkodNo = "869123400108", Sira = 29, KategoriId = 5 },
            //    new Urun { Adi = "USB Bellek 64GB", BirimFiyat = 180, Stok = 200, BarkodNo = "869123400109", Sira = 30, KategoriId = 5 },
            //    new Urun { Adi = "Boya Kalem Seti", BirimFiyat = 75, Stok = 120, BarkodNo = "869123400110", Sira = 31, KategoriId = 4 },
            //    new Urun { Adi = "Defter Seti", BirimFiyat = 65, Stok = 180, BarkodNo = "869123400111", Sira = 32, KategoriId = 4 },
            //    new Urun { Adi = "Anne Bakım Çantası", BirimFiyat = 450, Stok = 45, BarkodNo = "869123400112", Sira = 33, KategoriId = 19 },
            //    new Urun { Adi = "Bebek Telsizi", BirimFiyat = 850, Stok = 30, BarkodNo = "869123400113", Sira = 34, KategoriId = 19 },
            //    new Urun { Adi = "Bahçe Makası", BirimFiyat = 220, Stok = 35, BarkodNo = "869123400114", Sira = 35, KategoriId = 12 },
            //    new Urun { Adi = "Bahçe Sulama Tabancası", BirimFiyat = 130, Stok = 60, BarkodNo = "869123400115", Sira = 36, KategoriId = 12 },
            //    new Urun { Adi = "Kamp Sandalyesi", BirimFiyat = 350, Stok = 40, BarkodNo = "869123400116", Sira = 37, KategoriId = 20 },
            //    new Urun { Adi = "Kamp Matı", BirimFiyat = 280, Stok = 50, BarkodNo = "869123400117", Sira = 38, KategoriId = 20 },
            //    new Urun { Adi = "Sırt Çantası", BirimFiyat = 420, Stok = 65, BarkodNo = "869123400118", Sira = 39, KategoriId = 20 },
            //    new Urun { Adi = "Aloe Vera Yüz Maskesi", BirimFiyat = 85, Stok = 120, BarkodNo = "869123400119", Sira = 40, KategoriId = 9 },
            //    new Urun { Adi = "Yüz Temizleme Jeli", BirimFiyat = 130, Stok = 100, BarkodNo = "869123400120", Sira = 41, KategoriId = 9 },
            //    new Urun { Adi = "Göz Kalemi", BirimFiyat = 70, Stok = 200, BarkodNo = "869123400121", Sira = 42, KategoriId = 9 },
            //    new Urun { Adi = "Spor Çanta", BirimFiyat = 310, Stok = 45, BarkodNo = "869123400122", Sira = 43, KategoriId = 13 },
            //    new Urun { Adi = "Koşu Bandı", BirimFiyat = 14500, Stok = 5, BarkodNo = "869123400123", Sira = 44, KategoriId = 13 },
            //    new Urun { Adi = "Araba Kokusu", BirimFiyat = 25, Stok = 300, BarkodNo = "869123400124", Sira = 45, KategoriId = 14 },
            //    new Urun { Adi = "Oto Koltuk Kılıfı", BirimFiyat = 340, Stok = 20, BarkodNo = "869123400125", Sira = 46, KategoriId = 14 },
            //    new Urun { Adi = "Vitamin Takviyesi", BirimFiyat = 120, Stok = 75, BarkodNo = "869123400126", Sira = 47, KategoriId = 15 },
            //    new Urun { Adi = "Tansiyon Aleti", BirimFiyat = 650, Stok = 15, BarkodNo = "869123400127", Sira = 48, KategoriId = 15 },
            //    new Urun { Adi = "Duvar Tablosu", BirimFiyat = 280, Stok = 50, BarkodNo = "869123400128", Sira = 49, KategoriId = 16 },
            //    new Urun { Adi = "Mum Seti", BirimFiyat = 160, Stok = 80, BarkodNo = "869123400129", Sira = 50, KategoriId = 16 },
            //    new Urun { Adi = "Tablet 10''", BirimFiyat = 6200, Stok = 22, BarkodNo = "869123400130", Sira = 51, KategoriId = 1 },
            //    new Urun { Adi = "Bluetooth Hoparlör", BirimFiyat = 480, Stok = 60, BarkodNo = "869123400131", Sira = 52, KategoriId = 1 },
            //    new Urun { Adi = "Yemek Takımı 24 Parça", BirimFiyat = 950, Stok = 30, BarkodNo = "869123400132", Sira = 53, KategoriId = 8 },
            //    new Urun { Adi = "Çelik Tencere", BirimFiyat = 1350, Stok = 20, BarkodNo = "869123400133", Sira = 54, KategoriId = 8 },
            //    new Urun { Adi = "Kadın Mont", BirimFiyat = 1650, Stok = 35, BarkodNo = "869123400134", Sira = 55, KategoriId = 3 },
            //    new Urun { Adi = "Kadın Bluz", BirimFiyat = 300, Stok = 70, BarkodNo = "869123400135", Sira = 56, KategoriId = 3 },
            //    new Urun { Adi = "Laptop Soğutucu", BirimFiyat = 250, Stok = 40, BarkodNo = "869123400136", Sira = 57, KategoriId = 5 },
            //    new Urun { Adi = "Mouse Pad", BirimFiyat = 60, Stok = 150, BarkodNo = "869123400137", Sira = 58, KategoriId = 5 },
            //    new Urun { Adi = "Çocuk Hikaye Kitabı", BirimFiyat = 95, Stok = 90, BarkodNo = "869123400138", Sira = 59, KategoriId = 7 },
            //    new Urun { Adi = "Tarih Kitabı", BirimFiyat = 150, Stok = 60, BarkodNo = "869123400139", Sira = 60, KategoriId = 7 },
            //    new Urun { Adi = "Oyuncak Araba", BirimFiyat = 220, Stok = 120, BarkodNo = "869123400140", Sira = 61, KategoriId = 10 },
            //    new Urun { Adi = "Peluş Ayı", BirimFiyat = 300, Stok = 70, BarkodNo = "869123400141", Sira = 62, KategoriId = 10 },
            //    new Urun { Adi = "Kız Çocuk Elbisesi", BirimFiyat = 240, Stok = 65, BarkodNo = "869123400142", Sira = 63, KategoriId = 3 },
            //    new Urun { Adi = "Yazı Tahtası", BirimFiyat = 90, Stok = 110, BarkodNo = "869123400143", Sira = 64, KategoriId = 4 },
            //    new Urun { Adi = "Boya Defteri", BirimFiyat = 55, Stok = 140, BarkodNo = "869123400144", Sira = 65, KategoriId = 4 },
            //    new Urun { Adi = "Yoga Matı", BirimFiyat = 270, Stok = 40, BarkodNo = "869123400145", Sira = 66, KategoriId = 13 },
            //    new Urun { Adi = "Dambıl Seti", BirimFiyat = 650, Stok = 25, BarkodNo = "869123400146", Sira = 67, KategoriId = 13 },
            //    new Urun { Adi = "Oto Lastik Parlatıcı", BirimFiyat = 85, Stok = 90, BarkodNo = "869123400147", Sira = 68, KategoriId = 14 },
            //    new Urun { Adi = "Oto Süpürge", BirimFiyat = 430, Stok = 18, BarkodNo = "869123400148", Sira = 69, KategoriId = 14 },
            //    new Urun { Adi = "Medikal Maske 50'li", BirimFiyat = 110, Stok = 100, BarkodNo = "869123400149", Sira = 70, KategoriId = 15 },
            //    new Urun { Adi = "Dekoratif Yastık", BirimFiyat = 150, Stok = 55, BarkodNo = "869123400150", Sira = 71, KategoriId = 16 },
            //    new Urun { Adi = "Salon Halısı", BirimFiyat = 1750, Stok = 12, BarkodNo = "869123400151", Sira = 72, KategoriId = 16 },
            //    new Urun { Adi = "Saç Düzleştirici", BirimFiyat = 520, Stok = 28, BarkodNo = "869123400152", Sira = 73, KategoriId = 9 },
            //    new Urun { Adi = "Yüz Serumu", BirimFiyat = 380, Stok = 48, BarkodNo = "869123400153", Sira = 74, KategoriId = 9 },
            //    new Urun { Adi = "Elektrikli Süpürge", BirimFiyat = 6900, Stok = 13, BarkodNo = "869123400154", Sira = 75, KategoriId = 17 },
            //    new Urun { Adi = "Ankastre Set", BirimFiyat = 15600, Stok = 9, BarkodNo = "869123400155", Sira = 76, KategoriId = 17 },
            //    new Urun { Adi = "Hobi Boya Seti", BirimFiyat = 190, Stok = 100, BarkodNo = "869123400156", Sira = 77, KategoriId = 18 },
            //    new Urun { Adi = "Ahşap Oyma Kalemi", BirimFiyat = 135, Stok = 60, BarkodNo = "869123400157", Sira = 78, KategoriId = 18 },
            //    new Urun { Adi = "Hamile Yastığı", BirimFiyat = 480, Stok = 30, BarkodNo = "869123400158", Sira = 79, KategoriId = 19 },
            //    new Urun { Adi = "Emzirme Önlüğü", BirimFiyat = 210, Stok = 40, BarkodNo = "869123400159", Sira = 80, KategoriId = 19 },
            //    new Urun { Adi = "Kamp Lamba", BirimFiyat = 190, Stok = 35, BarkodNo = "869123400160", Sira = 81, KategoriId = 20 },
            //    new Urun { Adi = "Kamp Tenceresi", BirimFiyat = 260, Stok = 50, BarkodNo = "869123400161", Sira = 82, KategoriId = 20 },
            //    new Urun { Adi = "Çocuk Puzzle", BirimFiyat = 110, Stok = 90, BarkodNo = "869123400162", Sira = 83, KategoriId = 10 },
            //    new Urun { Adi = "Yapboz Seti", BirimFiyat = 170, Stok = 65, BarkodNo = "869123400163", Sira = 84, KategoriId = 10 },
            //    new Urun { Adi = "Bahçe Hortumu", BirimFiyat = 240, Stok = 30, BarkodNo = "869123400164", Sira = 85, KategoriId = 12 },
            //    new Urun { Adi = "Bahçe Çapası", BirimFiyat = 310, Stok = 20, BarkodNo = "869123400165", Sira = 86, KategoriId = 12 },
            //    new Urun { Adi = "Kadın Çanta", BirimFiyat = 780, Stok = 50, BarkodNo = "869123400166", Sira = 87, KategoriId = 3 },
            //    new Urun { Adi = "Kız Çocuk Ayakkabı", BirimFiyat = 320, Stok = 65, BarkodNo = "869123400167", Sira = 88, KategoriId = 11 },
            //    new Urun { Adi = "Spor T-Shirt", BirimFiyat = 210, Stok = 70, BarkodNo = "869123400168", Sira = 89, KategoriId = 13 },
            //    new Urun { Adi = "Kamp Çakısı", BirimFiyat = 145, Stok = 30, BarkodNo = "869123400169", Sira = 90, KategoriId = 20 },
            //    new Urun { Adi = "Anne Sütü Saklama Kabı", BirimFiyat = 75, Stok = 110, BarkodNo = "869123400170", Sira = 91, KategoriId = 19 },
            //    new Urun { Adi = "Dekoratif Aynalı Tablo", BirimFiyat = 340, Stok = 40, BarkodNo = "869123400171", Sira = 92, KategoriId = 16 },
            //    new Urun { Adi = "Temel Sağlık Çantası", BirimFiyat = 430, Stok = 25, BarkodNo = "869123400172", Sira = 93, KategoriId = 15 },
            //    new Urun { Adi = "Bebek Termometresi", BirimFiyat = 260, Stok = 40, BarkodNo = "869123400173", Sira = 94, KategoriId = 15 },
            //    new Urun { Adi = "Deri Cüzdan", BirimFiyat = 390, Stok = 55, BarkodNo = "869123400174", Sira = 95, KategoriId = 3 },
            //    new Urun { Adi = "LED Ampul", BirimFiyat = 45, Stok = 300, BarkodNo = "869123400175", Sira = 96, KategoriId = 1 },
            //    new Urun { Adi = "USB Şarj Adaptörü", BirimFiyat = 70, Stok = 140, BarkodNo = "869123400176", Sira = 97, KategoriId = 1 },
            //    new Urun { Adi = "Pişirme Fırını", BirimFiyat = 4350, Stok = 12, BarkodNo = "869123400177", Sira = 98, KategoriId = 8 },
            //    new Urun { Adi = "Mini Mikser", BirimFiyat = 390, Stok = 25, BarkodNo = "869123400178", Sira = 99, KategoriId = 8 },
            //    new Urun { Adi = "USB Webcam", BirimFiyat = 950, Stok = 20, BarkodNo = "869123400179", Sira = 100, KategoriId = 5 },
            //};

            //var urunEkleTopluSekildeEk = dbHelper.UrunEkleToplu(urunToplu: urunlerDevam);
            //Console.WriteLine(urunEkleTopluSekildeEk);

            #endregion


            #region Kategorileri Sıraya Göre Listele
            //Console.WriteLine("Ürün Kategorileri");
            //Console.WriteLine("-----------------");

            //var listeleUrunKategorileri = dbHelper.UrunKategoriListele();

            //foreach (var item in listeleUrunKategorileri)
            //{
            //    Console.WriteLine($"{item.Sira} - {item.Adi} - {item.KategoriNo}");
            //}

            #endregion


            #region Kategoriye Göre Ürünler
            //Console.WriteLine("Kategoriye Göre Ürünler");
            //Console.WriteLine("-----------------------");

            //var urunlerByKategori = dbHelper.GetUrunByCategory(kategoriId: 1);
            //foreach (var item in urunlerByKategori)
            //{
            //    Console.WriteLine(item.Adi);
            //}
            #endregion


            #region Sipariş Listesi Ekle

            //var siparisler = new List<Siparis>
            //{
            //    new Siparis { SiparisNo = "SP20250619001", KullaniciId = 1, Toplam = 58800 },
            //    new Siparis { SiparisNo = "SP20250619002", KullaniciId = 3, Toplam = 44220 },
            //    new Siparis { SiparisNo = "SP20250619003", KullaniciId = 5, Toplam = 27305 },
            //    new Siparis { SiparisNo = "SP20250619004", KullaniciId = 2, Toplam = 45780 },
            //    new Siparis { SiparisNo = "SP20250619005", KullaniciId = 7, Toplam = 22255 },
            //    new Siparis { SiparisNo = "SP20250619006", KullaniciId = 8, Toplam = 21990 },
            //    new Siparis { SiparisNo = "SP20250619007", KullaniciId = 4, Toplam = 26100 },
            //    new Siparis { SiparisNo = "SP20250619008", KullaniciId = 6, Toplam = 75490 },
            //    new Siparis { SiparisNo = "SP20250619009", KullaniciId = 9, Toplam = 52100 },
            //    new Siparis { SiparisNo = "SP20250619010", KullaniciId = 10, Toplam = 4110 },
            //    new Siparis { SiparisNo = "SP20250619011", KullaniciId = 11, Toplam = 41430 },
            //    new Siparis { SiparisNo = "SP20250619012", KullaniciId = 12, Toplam = 36650 },
            //    new Siparis { SiparisNo = "SP20250619013", KullaniciId = 13, Toplam = 5030 },
            //    new Siparis { SiparisNo = "SP20250619014", KullaniciId = 14, Toplam = 19050 },
            //    new Siparis { SiparisNo = "SP20250619015", KullaniciId = 15, Toplam = 50985 },
            //    new Siparis { SiparisNo = "SP20250619016", KullaniciId = 16, Toplam = 38160 },
            //    new Siparis { SiparisNo = "SP20250619017", KullaniciId = 17, Toplam = 39570 },
            //    new Siparis { SiparisNo = "SP20250619018", KullaniciId = 18, Toplam = 59220 },
            //    new Siparis { SiparisNo = "SP20250619019", KullaniciId = 19, Toplam = 5700 },
            //    new Siparis { SiparisNo = "SP20250619020", KullaniciId = 20, Toplam = 27950 },
            //};

            //var siparisEkleToplu = dbHelper.SiparisEkleToplu(siparisToplu: siparisler);
            //Console.WriteLine(siparisEkleToplu);
            #endregion


            #region Sipariş Detay Ekleme (SiparisItem)

            //var siparisItems = new List<SiparisItem>
            //{
            //    // SiparisId = 41 (6 satır)
            //    new SiparisItem { SiparisId = 41, UrunId = 1, UrunFiyat = 39500, Adet = 1, AraToplam = 39500 },
            //    new SiparisItem { SiparisId = 41, UrunId = 12, UrunFiyat = 60, Adet = 2, AraToplam = 120 },
            //    new SiparisItem { SiparisId = 41, UrunId = 5, UrunFiyat = 950, Adet = 1, AraToplam = 950 },
            //    new SiparisItem { SiparisId = 41, UrunId = 13, UrunFiyat = 150, Adet = 3, AraToplam = 450 },
            //    new SiparisItem { SiparisId = 41, UrunId = 9, UrunFiyat = 16500, Adet = 1, AraToplam = 16500 },
            //    new SiparisItem { SiparisId = 41, UrunId = 16, UrunFiyat = 320, Adet = 4, AraToplam = 1280 },

            //    // SiparisId = 42 (5 satır)
            //    new SiparisItem { SiparisId = 42, UrunId = 6, UrunFiyat = 1850, Adet = 2, AraToplam = 3700 },
            //    new SiparisItem { SiparisId = 42, UrunId = 12, UrunFiyat = 60, Adet = 5, AraToplam = 300 },
            //    new SiparisItem { SiparisId = 42, UrunId = 7, UrunFiyat = 450, Adet = 1, AraToplam = 450 },
            //    new SiparisItem { SiparisId = 42, UrunId = 14, UrunFiyat = 45, Adet = 6, AraToplam = 270 },
            //    new SiparisItem { SiparisId = 42, UrunId = 1, UrunFiyat = 39500, Adet = 1, AraToplam = 39500 },

            //    // SiparisId = 43 (7 satır)
            //    new SiparisItem { SiparisId = 43, UrunId = 7, UrunFiyat = 450, Adet = 4, AraToplam = 1800 },
            //    new SiparisItem { SiparisId = 43, UrunId = 14, UrunFiyat = 45, Adet = 3, AraToplam = 135 },
            //    new SiparisItem { SiparisId = 43, UrunId = 8, UrunFiyat = 22500, Adet = 1, AraToplam = 22500 },
            //    new SiparisItem { SiparisId = 43, UrunId = 20, UrunFiyat = 450, Adet = 2, AraToplam = 900 },
            //    new SiparisItem { SiparisId = 43, UrunId = 5, UrunFiyat = 950, Adet = 1, AraToplam = 950 },
            //    new SiparisItem { SiparisId = 43, UrunId = 13, UrunFiyat = 150, Adet = 2, AraToplam = 300 },
            //    new SiparisItem { SiparisId = 43, UrunId = 11, UrunFiyat = 120, Adet = 6, AraToplam = 720 },

            //    // SiparisId = 44 (4 satır)
            //    new SiparisItem { SiparisId = 44, UrunId = 3, UrunFiyat = 45000, Adet = 1, AraToplam = 45000 },
            //    new SiparisItem { SiparisId = 44, UrunId = 15, UrunFiyat = 75, Adet = 8, AraToplam = 600 },
            //    new SiparisItem { SiparisId = 44, UrunId = 10, UrunFiyat = 34500, Adet = 0, AraToplam = 0 },
            //    new SiparisItem { SiparisId = 44, UrunId = 12, UrunFiyat = 60, Adet = 3, AraToplam = 180 },

            //    // SiparisId = 45 (6 satır)
            //    new SiparisItem { SiparisId = 45, UrunId = 20, UrunFiyat = 450, Adet = 5, AraToplam = 2250 },
            //    new SiparisItem { SiparisId = 45, UrunId = 9, UrunFiyat = 16500, Adet = 1, AraToplam = 16500 },
            //    new SiparisItem { SiparisId = 45, UrunId = 18, UrunFiyat = 110, Adet = 7, AraToplam = 770 },
            //    new SiparisItem { SiparisId = 45, UrunId = 6, UrunFiyat = 1850, Adet = 1, AraToplam = 1850 },
            //    new SiparisItem { SiparisId = 45, UrunId = 13, UrunFiyat = 150, Adet = 4, AraToplam = 600 },
            //    new SiparisItem { SiparisId = 45, UrunId = 19, UrunFiyat = 95, Adet = 3, AraToplam = 285 },

            //    // SiparisId = 46 (5 satır)
            //    new SiparisItem { SiparisId = 46, UrunId = 9, UrunFiyat = 16500, Adet = 1, AraToplam = 16500 },
            //    new SiparisItem { SiparisId = 46, UrunId = 16, UrunFiyat = 320, Adet = 6, AraToplam = 1920 },
            //    new SiparisItem { SiparisId = 46, UrunId = 4, UrunFiyat = 2700, Adet = 1, AraToplam = 2700 },
            //    new SiparisItem { SiparisId = 46, UrunId = 12, UrunFiyat = 60, Adet = 7, AraToplam = 420 },
            //    new SiparisItem { SiparisId = 46, UrunId = 7, UrunFiyat = 450, Adet = 1, AraToplam = 450 },

            //    // SiparisId = 47 (3 satır)
            //    new SiparisItem { SiparisId = 47, UrunId = 11, UrunFiyat = 120, Adet = 15, AraToplam = 1800 },
            //    new SiparisItem { SiparisId = 47, UrunId = 8, UrunFiyat = 22500, Adet = 1, AraToplam = 22500 },
            //    new SiparisItem { SiparisId = 47, UrunId = 20, UrunFiyat = 450, Adet = 4, AraToplam = 1800 },

            //    // SiparisId = 48 (7 satır)
            //    new SiparisItem { SiparisId = 48, UrunId = 1, UrunFiyat = 39500, Adet = 1, AraToplam = 39500 },
            //    new SiparisItem { SiparisId = 48, UrunId = 2, UrunFiyat = 32500, Adet = 1, AraToplam = 32500 },
            //    new SiparisItem { SiparisId = 48, UrunId = 5, UrunFiyat = 950, Adet = 2, AraToplam = 1900 },
            //    new SiparisItem { SiparisId = 48, UrunId = 10, UrunFiyat = 34500, Adet = 0, AraToplam = 0 },
            //    new SiparisItem { SiparisId = 48, UrunId = 13, UrunFiyat = 150, Adet = 3, AraToplam = 450 },
            //    new SiparisItem { SiparisId = 48, UrunId = 12, UrunFiyat = 60, Adet = 8, AraToplam = 480 },
            //    new SiparisItem { SiparisId = 48, UrunId = 19, UrunFiyat = 95, Adet = 7, AraToplam = 665 },

            //    // SiparisId = 49 (4 satır)
            //    new SiparisItem { SiparisId = 49, UrunId = 3, UrunFiyat = 45000, Adet = 1, AraToplam = 45000 },
            //    new SiparisItem { SiparisId = 49, UrunId = 6, UrunFiyat = 1850, Adet = 3, AraToplam = 5550 },
            //    new SiparisItem { SiparisId = 49, UrunId = 18, UrunFiyat = 110, Adet = 10, AraToplam = 1100 },
            //    new SiparisItem { SiparisId = 49, UrunId = 20, UrunFiyat = 450, Adet = 1, AraToplam = 450 },

            //    // SiparisId = 50 (5 satır)
            //    new SiparisItem { SiparisId = 50, UrunId = 14, UrunFiyat = 45, Adet = 12, AraToplam = 540 },
            //    new SiparisItem { SiparisId = 50, UrunId = 7, UrunFiyat = 450, Adet = 5, AraToplam = 2250 },
            //    new SiparisItem { SiparisId = 50, UrunId = 1, UrunFiyat = 39500, Adet = 0, AraToplam = 0 },
            //    new SiparisItem { SiparisId = 50, UrunId = 11, UrunFiyat = 120, Adet = 7, AraToplam = 840 },
            //    new SiparisItem { SiparisId = 50, UrunId = 12, UrunFiyat = 60, Adet = 8, AraToplam = 480 },

            //    // SiparisId = 51 (6 satır)
            //    new SiparisItem { SiparisId = 51, UrunId = 5, UrunFiyat = 950, Adet = 3, AraToplam = 2850 },
            //    new SiparisItem { SiparisId = 51, UrunId = 10, UrunFiyat = 34500, Adet = 1, AraToplam = 34500 },
            //    new SiparisItem { SiparisId = 51, UrunId = 18, UrunFiyat = 110, Adet = 10, AraToplam = 1100 },
            //    new SiparisItem { SiparisId = 51, UrunId = 16, UrunFiyat = 320, Adet = 5, AraToplam = 1600 },
            //    new SiparisItem { SiparisId = 51, UrunId = 13, UrunFiyat = 150, Adet = 6, AraToplam = 900 },
            //    new SiparisItem { SiparisId = 51, UrunId = 12, UrunFiyat = 60, Adet = 8, AraToplam = 480 },

            //    // SiparisId = 52 (3 satır)
            //    new SiparisItem { SiparisId = 52, UrunId = 2, UrunFiyat = 32500, Adet = 1, AraToplam = 32500 },
            //    new SiparisItem { SiparisId = 52, UrunId = 6, UrunFiyat = 1850, Adet = 2, AraToplam = 3700 },
            //    new SiparisItem { SiparisId = 52, UrunId = 14, UrunFiyat = 45, Adet = 10, AraToplam = 450 },

            //    // SiparisId = 53 (4 satır)
            //    new SiparisItem { SiparisId = 53, UrunId = 16, UrunFiyat = 320, Adet = 2, AraToplam = 640 },
            //    new SiparisItem { SiparisId = 53, UrunId = 11, UrunFiyat = 120, Adet = 7, AraToplam = 840 },
            //    new SiparisItem { SiparisId = 53, UrunId = 17, UrunFiyat = 1650, Adet = 1, AraToplam = 1650 },
            //    new SiparisItem { SiparisId = 53, UrunId = 5, UrunFiyat = 950, Adet = 2, AraToplam = 1900 },

            //    // SiparisId = 54 (5 satır)
            //    new SiparisItem { SiparisId = 54, UrunId = 7, UrunFiyat = 450, Adet = 3, AraToplam = 1350 },
            //    new SiparisItem { SiparisId = 54, UrunId = 13, UrunFiyat = 150, Adet = 5, AraToplam = 750 },
            //    new SiparisItem { SiparisId = 54, UrunId = 9, UrunFiyat = 16500, Adet = 1, AraToplam = 16500 },
            //    new SiparisItem { SiparisId = 54, UrunId = 1, UrunFiyat = 39500, Adet = 0, AraToplam = 0 },
            //    new SiparisItem { SiparisId = 54, UrunId = 15, UrunFiyat = 75, Adet = 6, AraToplam = 450 },

            //    // SiparisId = 55 (6 satır)
            //    new SiparisItem { SiparisId = 55, UrunId = 3, UrunFiyat = 45000, Adet = 1, AraToplam = 45000 },
            //    new SiparisItem { SiparisId = 55, UrunId = 5, UrunFiyat = 950, Adet = 4, AraToplam = 3800 },
            //    new SiparisItem { SiparisId = 55, UrunId = 18, UrunFiyat = 110, Adet = 5, AraToplam = 550 },
            //    new SiparisItem { SiparisId = 55, UrunId = 16, UrunFiyat = 320, Adet = 3, AraToplam = 960 },
            //    new SiparisItem { SiparisId = 55, UrunId = 12, UrunFiyat = 60, Adet = 6, AraToplam = 360 },
            //    new SiparisItem { SiparisId = 55, UrunId = 14, UrunFiyat = 45, Adet = 7, AraToplam = 315 },

            //    // SiparisId = 56 (3 satır)
            //    new SiparisItem { SiparisId = 56, UrunId = 10, UrunFiyat = 34500, Adet = 1, AraToplam = 34500 },
            //    new SiparisItem { SiparisId = 56, UrunId = 20, UrunFiyat = 450, Adet = 6, AraToplam = 2700 },
            //    new SiparisItem { SiparisId = 56, UrunId = 11, UrunFiyat = 120, Adet = 8, AraToplam = 960 },

            //    // SiparisId = 57 (4 satır)
            //    new SiparisItem { SiparisId = 57, UrunId = 2, UrunFiyat = 32500, Adet = 1, AraToplam = 32500 },
            //    new SiparisItem { SiparisId = 57, UrunId = 6, UrunFiyat = 1850, Adet = 3, AraToplam = 5550 },
            //    new SiparisItem { SiparisId = 57, UrunId = 13, UrunFiyat = 150, Adet = 5, AraToplam = 750 },
            //    new SiparisItem { SiparisId = 57, UrunId = 18, UrunFiyat = 110, Adet = 7, AraToplam = 770 },

            //    // SiparisId = 58 (5 satır)
            //    new SiparisItem { SiparisId = 58, UrunId = 1, UrunFiyat = 39500, Adet = 1, AraToplam = 39500 },
            //    new SiparisItem { SiparisId = 58, UrunId = 5, UrunFiyat = 950, Adet = 2, AraToplam = 1900 },
            //    new SiparisItem { SiparisId = 58, UrunId = 9, UrunFiyat = 16500, Adet = 1, AraToplam = 16500 },
            //    new SiparisItem { SiparisId = 58, UrunId = 16, UrunFiyat = 320, Adet = 3, AraToplam = 960 },
            //    new SiparisItem { SiparisId = 58, UrunId = 14, UrunFiyat = 45, Adet = 8, AraToplam = 360 },

            //    // SiparisId = 59 (3 satır)
            //    new SiparisItem { SiparisId = 59, UrunId = 17, UrunFiyat = 1650, Adet = 2, AraToplam = 3300 },
            //    new SiparisItem { SiparisId = 59, UrunId = 20, UrunFiyat = 450, Adet = 4, AraToplam = 1800 },
            //    new SiparisItem { SiparisId = 59, UrunId = 12, UrunFiyat = 60, Adet = 10, AraToplam = 600 },

            //    // SiparisId = 60 (6 satır)
            //    new SiparisItem { SiparisId = 60, UrunId = 8, UrunFiyat = 22500, Adet = 1, AraToplam = 22500 },
            //    new SiparisItem { SiparisId = 60, UrunId = 6, UrunFiyat = 1850, Adet = 2, AraToplam = 3700 },
            //    new SiparisItem { SiparisId = 60, UrunId = 14, UrunFiyat = 45, Adet = 7, AraToplam = 315 },
            //    new SiparisItem { SiparisId = 60, UrunId = 19, UrunFiyat = 95, Adet = 5, AraToplam = 475 },
            //    new SiparisItem { SiparisId = 60, UrunId = 10, UrunFiyat = 34500, Adet = 0, AraToplam = 0 },
            //    new SiparisItem { SiparisId = 60, UrunId = 12, UrunFiyat = 60, Adet = 6, AraToplam = 360 },
            //    new SiparisItem { SiparisId = 60, UrunId = 15, UrunFiyat = 75, Adet = 8, AraToplam = 600 },
            //};

            //var siparisDetay = dbHelper.SiparisItemEkleToplu(itemSiparisToplu: siparisItems);
            //Console.WriteLine(siparisDetay);

            #endregion


            #region Sipariş Detay Tablosundaki Siparişlerin ID Bazında Toplam Tutarı

            //var siparisDetayListesi = dbHelper.SiparisItemListele();

            //dbHelper.SiparisItemGrupBazliToplam(siparisDetayListesi);
            #endregion


            #region Kategori Bazlı Ürün Listesi

            //Console.WriteLine("KATEGORİ BAZLI ÜRÜN LİSTESİ");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine();

            //dbHelper.KategoriBazliUrunListesi();

            #endregion


            #region  Şifre Güncelle

            //Console.WriteLine(dbHelper.SifreGuncelle(kullaniciID: 3, mevcutSifre: "pass123", yeniSifre: "passw0rd123@"));

            #endregion


            #region Tek Kullanıcının Şifresini Şifrele

            //Console.Write("Şifresini şifrelemek istediğiniz kullanıcı Id: ");
            //int kulId = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Şifre giriniz: ");
            //string kulSifre = Console.ReadLine();

            //string kulIslem = dbHelper.SifreSifreleTekKullanici(KullaniciId: kulId, Sifre: kulSifre);

            //Console.WriteLine(kulIslem);

            #endregion


            #region Kullanıcı Bazlı Siparişler

            //var kullBazSip = dbHelper.KullaniciBazliSiparisler();

            //int sira = 1;

            //Console.WriteLine("Kullanıcı Bazlı Siparişler");
            //Console.WriteLine("--------------------------");

            //foreach (var item in kullBazSip)
            //{
            //    Console.WriteLine($"{sira} - {item.Kullanici.AdSoyad} - Sipariş No: {item.SiparisNo} - Sipariş Toplam: {item.Toplam.ToString("N0")} TL");
            //    sira++;
            //}

            #endregion


            #region En Çok Harcama Yapan 3 Müşteri

            var enCokHarcamaYapan = dbHelper.EnCokHarcamaYapanMusteri();

            Console.WriteLine("En Çok Harcama Yapan 3 Müşteri");
            Console.WriteLine("------------------------------");

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"{i} - {enCokHarcamaYapan[i].Kullanici.AdSoyad.ToString()} - {enCokHarcamaYapan[i].Toplam.ToString("N0")} TL");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
