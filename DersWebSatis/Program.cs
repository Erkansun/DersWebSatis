using DersWebSatis.Model;

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
            //    new Siparis { SiparisNo = "SP20250619001", KullaniciId = 1, Toplam = 41500 },
            //    new Siparis { SiparisNo = "SP20250619002", KullaniciId = 3, Toplam = 1200 },
            //    new Siparis { SiparisNo = "SP20250619003", KullaniciId = 5, Toplam = 2300 },
            //    new Siparis { SiparisNo = "SP20250619004", KullaniciId = 2, Toplam = 9800 },
            //    new Siparis { SiparisNo = "SP20250619005", KullaniciId = 7, Toplam = 2400 },
            //    new Siparis { SiparisNo = "SP20250619006", KullaniciId = 8, Toplam = 15750 },
            //    new Siparis { SiparisNo = "SP20250619007", KullaniciId = 4, Toplam = 3500 },
            //    new Siparis { SiparisNo = "SP20250619008", KullaniciId = 6, Toplam = 5800 },
            //    new Siparis { SiparisNo = "SP20250619009", KullaniciId = 9, Toplam = 8900 },
            //    new Siparis { SiparisNo = "SP20250619010", KullaniciId = 10, Toplam = 2100 },
            //    new Siparis { SiparisNo = "SP20250619011", KullaniciId = 11, Toplam = 4300 },
            //    new Siparis { SiparisNo = "SP20250619012", KullaniciId = 12, Toplam = 9000 },
            //    new Siparis { SiparisNo = "SP20250619013", KullaniciId = 13, Toplam = 1250 },
            //    new Siparis { SiparisNo = "SP20250619014", KullaniciId = 14, Toplam = 5400 },
            //    new Siparis { SiparisNo = "SP20250619015", KullaniciId = 15, Toplam = 7200 },
            //    new Siparis { SiparisNo = "SP20250619016", KullaniciId = 16, Toplam = 3600 },
            //    new Siparis { SiparisNo = "SP20250619017", KullaniciId = 17, Toplam = 4100 },
            //    new Siparis { SiparisNo = "SP20250619018", KullaniciId = 18, Toplam = 5500 },
            //    new Siparis { SiparisNo = "SP20250619019", KullaniciId = 19, Toplam = 2850 },
            //    new Siparis { SiparisNo = "SP20250619020", KullaniciId = 20, Toplam = 9950 },
            //};

            //var siparisEkleToplu = dbHelper.SiparisEkleToplu(siparisToplu: siparisler);
            //Console.WriteLine(siparisEkleToplu);
            #endregion


            #region Sipariş Detay Ekleme (SiparisItem)

            //var siparisItems = new List<SiparisItem>
            //{
            //    // SiparisId = 1 (6 satır)
            //    new SiparisItem { SiparisId = 1, UrunId = 1, UrunFiyat = 39500, Adet = 1, AraToplam = 39500 },
            //    new SiparisItem { SiparisId = 1, UrunId = 12, UrunFiyat = 60, Adet = 2, AraToplam = 120 },
            //    new SiparisItem { SiparisId = 1, UrunId = 5, UrunFiyat = 950, Adet = 1, AraToplam = 950 },
            //    new SiparisItem { SiparisId = 1, UrunId = 13, UrunFiyat = 150, Adet = 3, AraToplam = 450 },
            //    new SiparisItem { SiparisId = 1, UrunId = 9, UrunFiyat = 16500, Adet = 1, AraToplam = 16500 },
            //    new SiparisItem { SiparisId = 1, UrunId = 16, UrunFiyat = 320, Adet = 4, AraToplam = 1280 },

            //    // SiparisId = 2 (5 satır)
            //    new SiparisItem { SiparisId = 2, UrunId = 6, UrunFiyat = 1850, Adet = 2, AraToplam = 3700 },
            //    new SiparisItem { SiparisId = 2, UrunId = 12, UrunFiyat = 60, Adet = 5, AraToplam = 300 },
            //    new SiparisItem { SiparisId = 2, UrunId = 7, UrunFiyat = 450, Adet = 1, AraToplam = 450 },
            //    new SiparisItem { SiparisId = 2, UrunId = 14, UrunFiyat = 45, Adet = 6, AraToplam = 270 },
            //    new SiparisItem { SiparisId = 2, UrunId = 1, UrunFiyat = 39500, Adet = 1, AraToplam = 39500 },

            //    // SiparisId = 3 (7 satır)
            //    new SiparisItem { SiparisId = 3, UrunId = 7, UrunFiyat = 450, Adet = 4, AraToplam = 1800 },
            //    new SiparisItem { SiparisId = 3, UrunId = 14, UrunFiyat = 45, Adet = 3, AraToplam = 135 },
            //    new SiparisItem { SiparisId = 3, UrunId = 8, UrunFiyat = 22500, Adet = 1, AraToplam = 22500 },
            //    new SiparisItem { SiparisId = 3, UrunId = 20, UrunFiyat = 450, Adet = 2, AraToplam = 900 },
            //    new SiparisItem { SiparisId = 3, UrunId = 5, UrunFiyat = 950, Adet = 1, AraToplam = 950 },
            //    new SiparisItem { SiparisId = 3, UrunId = 13, UrunFiyat = 150, Adet = 2, AraToplam = 300 },
            //    new SiparisItem { SiparisId = 3, UrunId = 11, UrunFiyat = 120, Adet = 6, AraToplam = 720 },

            //    // SiparisId = 4 (4 satır)
            //    new SiparisItem { SiparisId = 4, UrunId = 3, UrunFiyat = 45000, Adet = 1, AraToplam = 45000 },
            //    new SiparisItem { SiparisId = 4, UrunId = 15, UrunFiyat = 75, Adet = 8, AraToplam = 600 },
            //    new SiparisItem { SiparisId = 4, UrunId = 10, UrunFiyat = 34500, Adet = 0, AraToplam = 0 },
            //    new SiparisItem { SiparisId = 4, UrunId = 12, UrunFiyat = 60, Adet = 3, AraToplam = 180 },

            //    // SiparisId = 5 (6 satır)
            //    new SiparisItem { SiparisId = 5, UrunId = 20, UrunFiyat = 450, Adet = 5, AraToplam = 2250 },
            //    new SiparisItem { SiparisId = 5, UrunId = 9, UrunFiyat = 16500, Adet = 1, AraToplam = 16500 },
            //    new SiparisItem { SiparisId = 5, UrunId = 18, UrunFiyat = 110, Adet = 7, AraToplam = 770 },
            //    new SiparisItem { SiparisId = 5, UrunId = 6, UrunFiyat = 1850, Adet = 1, AraToplam = 1850 },
            //    new SiparisItem { SiparisId = 5, UrunId = 13, UrunFiyat = 150, Adet = 4, AraToplam = 600 },
            //    new SiparisItem { SiparisId = 5, UrunId = 19, UrunFiyat = 95, Adet = 3, AraToplam = 285 },

            //    // SiparisId = 6 (5 satır)
            //    new SiparisItem { SiparisId = 6, UrunId = 9, UrunFiyat = 16500, Adet = 1, AraToplam = 16500 },
            //    new SiparisItem { SiparisId = 6, UrunId = 16, UrunFiyat = 320, Adet = 6, AraToplam = 1920 },
            //    new SiparisItem { SiparisId = 6, UrunId = 4, UrunFiyat = 2700, Adet = 1, AraToplam = 2700 },
            //    new SiparisItem { SiparisId = 6, UrunId = 12, UrunFiyat = 60, Adet = 7, AraToplam = 420 },
            //    new SiparisItem { SiparisId = 6, UrunId = 7, UrunFiyat = 450, Adet = 1, AraToplam = 450 },

            //    // SiparisId = 7 (3 satır)
            //    new SiparisItem { SiparisId = 7, UrunId = 11, UrunFiyat = 120, Adet = 15, AraToplam = 1800 },
            //    new SiparisItem { SiparisId = 7, UrunId = 8, UrunFiyat = 22500, Adet = 1, AraToplam = 22500 },
            //    new SiparisItem { SiparisId = 7, UrunId = 20, UrunFiyat = 450, Adet = 4, AraToplam = 1800 },

            //    // SiparisId = 8 (7 satır)
            //    new SiparisItem { SiparisId = 8, UrunId = 1, UrunFiyat = 39500, Adet = 1, AraToplam = 39500 },
            //    new SiparisItem { SiparisId = 8, UrunId = 2, UrunFiyat = 32500, Adet = 1, AraToplam = 32500 },
            //    new SiparisItem { SiparisId = 8, UrunId = 5, UrunFiyat = 950, Adet = 2, AraToplam = 1900 },
            //    new SiparisItem { SiparisId = 8, UrunId = 10, UrunFiyat = 34500, Adet = 0, AraToplam = 0 },
            //    new SiparisItem { SiparisId = 8, UrunId = 13, UrunFiyat = 150, Adet = 3, AraToplam = 450 },
            //    new SiparisItem { SiparisId = 8, UrunId = 12, UrunFiyat = 60, Adet = 8, AraToplam = 480 },
            //    new SiparisItem { SiparisId = 8, UrunId = 19, UrunFiyat = 95, Adet = 7, AraToplam = 665 },

            //    // SiparisId = 9 (4 satır)
            //    new SiparisItem { SiparisId = 9, UrunId = 3, UrunFiyat = 45000, Adet = 1, AraToplam = 45000 },
            //    new SiparisItem { SiparisId = 9, UrunId = 6, UrunFiyat = 1850, Adet = 3, AraToplam = 5550 },
            //    new SiparisItem { SiparisId = 9, UrunId = 18, UrunFiyat = 110, Adet = 10, AraToplam = 1100 },
            //    new SiparisItem { SiparisId = 9, UrunId = 20, UrunFiyat = 450, Adet = 1, AraToplam = 450 },

            //    // SiparisId = 10 (5 satır)
            //    new SiparisItem { SiparisId = 10, UrunId = 14, UrunFiyat = 45, Adet = 12, AraToplam = 540 },
            //    new SiparisItem { SiparisId = 10, UrunId = 7, UrunFiyat = 450, Adet = 5, AraToplam = 2250 },
            //    new SiparisItem { SiparisId = 10, UrunId = 1, UrunFiyat = 39500, Adet = 0, AraToplam = 0 },
            //    new SiparisItem { SiparisId = 10, UrunId = 11, UrunFiyat = 120, Adet = 7, AraToplam = 840 },
            //    new SiparisItem { SiparisId = 10, UrunId = 12, UrunFiyat = 60, Adet = 8, AraToplam = 480 },

            //    // SiparisId = 11 (6 satır)
            //    new SiparisItem { SiparisId = 11, UrunId = 5, UrunFiyat = 950, Adet = 3, AraToplam = 2850 },
            //    new SiparisItem { SiparisId = 11, UrunId = 10, UrunFiyat = 34500, Adet = 1, AraToplam = 34500 },
            //    new SiparisItem { SiparisId = 11, UrunId = 18, UrunFiyat = 110, Adet = 10, AraToplam = 1100 },
            //    new SiparisItem { SiparisId = 11, UrunId = 16, UrunFiyat = 320, Adet = 5, AraToplam = 1600 },
            //    new SiparisItem { SiparisId = 11, UrunId = 13, UrunFiyat = 150, Adet = 6, AraToplam = 900 },
            //    new SiparisItem { SiparisId = 11, UrunId = 12, UrunFiyat = 60, Adet = 8, AraToplam = 480 },

            //    // SiparisId = 12 (3 satır)
            //    new SiparisItem { SiparisId = 12, UrunId = 2, UrunFiyat = 32500, Adet = 1, AraToplam = 32500 },
            //    new SiparisItem { SiparisId = 12, UrunId = 6, UrunFiyat = 1850, Adet = 2, AraToplam = 3700 },
            //    new SiparisItem { SiparisId = 12, UrunId = 14, UrunFiyat = 45, Adet = 10, AraToplam = 450 },

            //    // SiparisId = 13 (4 satır)
            //    new SiparisItem { SiparisId = 13, UrunId = 16, UrunFiyat = 320, Adet = 2, AraToplam = 640 },
            //    new SiparisItem { SiparisId = 13, UrunId = 11, UrunFiyat = 120, Adet = 7, AraToplam = 840 },
            //    new SiparisItem { SiparisId = 13, UrunId = 17, UrunFiyat = 1650, Adet = 1, AraToplam = 1650 },
            //    new SiparisItem { SiparisId = 13, UrunId = 5, UrunFiyat = 950, Adet = 2, AraToplam = 1900 },

            //    // SiparisId = 14 (5 satır)
            //    new SiparisItem { SiparisId = 14, UrunId = 7, UrunFiyat = 450, Adet = 3, AraToplam = 1350 },
            //    new SiparisItem { SiparisId = 14, UrunId = 13, UrunFiyat = 150, Adet = 5, AraToplam = 750 },
            //    new SiparisItem { SiparisId = 14, UrunId = 9, UrunFiyat = 16500, Adet = 1, AraToplam = 16500 },
            //    new SiparisItem { SiparisId = 14, UrunId = 1, UrunFiyat = 39500, Adet = 0, AraToplam = 0 },
            //    new SiparisItem { SiparisId = 14, UrunId = 15, UrunFiyat = 75, Adet = 6, AraToplam = 450 },

            //    // SiparisId = 15 (6 satır)
            //    new SiparisItem { SiparisId = 15, UrunId = 3, UrunFiyat = 45000, Adet = 1, AraToplam = 45000 },
            //    new SiparisItem { SiparisId = 15, UrunId = 5, UrunFiyat = 950, Adet = 4, AraToplam = 3800 },
            //    new SiparisItem { SiparisId = 15, UrunId = 18, UrunFiyat = 110, Adet = 5, AraToplam = 550 },
            //    new SiparisItem { SiparisId = 15, UrunId = 16, UrunFiyat = 320, Adet = 3, AraToplam = 960 },
            //    new SiparisItem { SiparisId = 15, UrunId = 12, UrunFiyat = 60, Adet = 6, AraToplam = 360 },
            //    new SiparisItem { SiparisId = 15, UrunId = 14, UrunFiyat = 45, Adet = 7, AraToplam = 315 },

            //    // SiparisId = 16 (3 satır)
            //    new SiparisItem { SiparisId = 16, UrunId = 10, UrunFiyat = 34500, Adet = 1, AraToplam = 34500 },
            //    new SiparisItem { SiparisId = 16, UrunId = 20, UrunFiyat = 450, Adet = 6, AraToplam = 2700 },
            //    new SiparisItem { SiparisId = 16, UrunId = 11, UrunFiyat = 120, Adet = 8, AraToplam = 960 },

            //    // SiparisId = 17 (4 satır)
            //    new SiparisItem { SiparisId = 17, UrunId = 2, UrunFiyat = 32500, Adet = 1, AraToplam = 32500 },
            //    new SiparisItem { SiparisId = 17, UrunId = 6, UrunFiyat = 1850, Adet = 3, AraToplam = 5550 },
            //    new SiparisItem { SiparisId = 17, UrunId = 13, UrunFiyat = 150, Adet = 5, AraToplam = 750 },
            //    new SiparisItem { SiparisId = 17, UrunId = 18, UrunFiyat = 110, Adet = 7, AraToplam = 770 },

            //    // SiparisId = 18 (5 satır)
            //    new SiparisItem { SiparisId = 18, UrunId = 1, UrunFiyat = 39500, Adet = 1, AraToplam = 39500 },
            //    new SiparisItem { SiparisId = 18, UrunId = 5, UrunFiyat = 950, Adet = 2, AraToplam = 1900 },
            //    new SiparisItem { SiparisId = 18, UrunId = 9, UrunFiyat = 16500, Adet = 1, AraToplam = 16500 },
            //    new SiparisItem { SiparisId = 18, UrunId = 16, UrunFiyat = 320, Adet = 3, AraToplam = 960 },
            //    new SiparisItem { SiparisId = 18, UrunId = 14, UrunFiyat = 45, Adet = 8, AraToplam = 360 },

            //    // SiparisId = 19 (3 satır)
            //    new SiparisItem { SiparisId = 19, UrunId = 17, UrunFiyat = 1650, Adet = 2, AraToplam = 3300 },
            //    new SiparisItem { SiparisId = 19, UrunId = 20, UrunFiyat = 450, Adet = 4, AraToplam = 1800 },
            //    new SiparisItem { SiparisId = 19, UrunId = 12, UrunFiyat = 60, Adet = 10, AraToplam = 600 },

            //    // SiparisId = 20 (6 satır)
            //    new SiparisItem { SiparisId = 20, UrunId = 8, UrunFiyat = 22500, Adet = 1, AraToplam = 22500 },
            //    new SiparisItem { SiparisId = 20, UrunId = 6, UrunFiyat = 1850, Adet = 2, AraToplam = 3700 },
            //    new SiparisItem { SiparisId = 20, UrunId = 14, UrunFiyat = 45, Adet = 7, AraToplam = 315 },
            //    new SiparisItem { SiparisId = 20, UrunId = 19, UrunFiyat = 95, Adet = 5, AraToplam = 475 },
            //    new SiparisItem { SiparisId = 20, UrunId = 10, UrunFiyat = 34500, Adet = 0, AraToplam = 0 },
            //    new SiparisItem { SiparisId = 20, UrunId = 12, UrunFiyat = 60, Adet = 6, AraToplam = 360 },
            //    new SiparisItem { SiparisId = 20, UrunId = 15, UrunFiyat = 75, Adet = 8, AraToplam = 600 },
            //};

            //var siparisDetay = dbHelper.SiparisItemEkleToplu(itemSiparisToplu: siparisItems);
            //Console.WriteLine(siparisDetay);

            #endregion



            Console.ReadKey();
        }
    }
}
