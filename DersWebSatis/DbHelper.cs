using DersWebSatis.Data;
using DersWebSatis.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersWebSatis
{
    public class DbHelper
    {
        private AppDbContext _db = new AppDbContext();

        #region KULLANICI İŞLEMLERİ
        // Kullanıcı Açma (tek)
        public string KullaniciEkle(Kullanici data)
        {
            _db.Kullanicis.Add(data);
            _db.SaveChanges();

            return $"Kullanici eklendi...";
        }

        // Kullanıcı Ekle (toplu)
        public string KullaniciEkleToplu(List<Kullanici> data)
        {
            _db.Kullanicis.AddRange(data);
            _db.SaveChanges();

            return $"Kullanıcılar eklendi";
        }

        // ŞifreGüncelle
        public string SifreGuncelle(int kullaniciID, string mevcutSifre, string yeniSifre)
        {
            Kullanici kullaniciData = _db.Kullanicis.Find(kullaniciID);

            if (kullaniciData.Sifre != Auth.Hash(mevcutSifre))
                return "Mevcut şifreniz girdiğiniz şifre ile uyuşmuyor";
            else
            {
                kullaniciData.Sifre = Auth.Hash(yeniSifre);
                _db.SaveChanges();

                return "Şifreniz başarı ile güncellendi";
            }
        }

        // Tüm Kullanıcıların Şifresini Şifrele
        public string SifreGuncelleTumKullanicilar()
        {
            List<Kullanici> kullaniciTumu = _db.Kullanicis.ToList();

            foreach (var kullanici in kullaniciTumu)
            {
                kullanici.Sifre = Auth.Hash(kullanici.Sifre);
                _db.SaveChanges();
            }

            return "Kullanıcıların şifreleri 256 bit ile şifrelendi";

        }

        // Tek Kullanıcının Şifresini Şifrele
        public string SifreSifreleTekKullanici(int KullaniciId, string Sifre)
        {
            var kullanici = _db.Kullanicis.Where(p => p.Id == KullaniciId).FirstOrDefault();

            kullanici.Sifre = Auth.Hash(Sifre);
            _db.SaveChanges();

            return $"{kullanici.AdSoyad} 'ın şifresi güncellendi";
        }

        // Kullanıcı Bazlı Siparişler
        public List<Siparis> KullaniciBazliSiparisler()
        {
            var kullBazSip = _db.Sipsaris
                                .Include(p => p.Kullanici)
                                .ToList();

            return kullBazSip;
        }

        // En Çok Harcama Yapan 3 Müşteri
        public List<Siparis> EnCokHarcamaYapanMusteri()
        {
            var kul = _db.Sipsaris
                        .OrderByDescending(p => p.Toplam)
                        .Include(p => p.Kullanici)
                        .ToList();

            return kul;
        }

        // Kullanıcı Listeleme
        public List<Kullanici> TumKullanicilariListele()
        {
            var tumKullanicilar = _db.Kullanicis.OrderBy(p => p.AdSoyad).ToList();

            return tumKullanicilar;
        }

        // Girilen Müşteri Sayısına Göre Kullanıcı Bazlı Sipariş ve Detay Listeleme
        public List<Siparis> MusteriBazliDetayliSiparisListele(int musteriSayisi)
        {
            var musteriBazli = _db.Sipsaris
                                    .Include(p => p.Kullanici)
                                    .Include(p => p.SiparisItems)
                                        .ThenInclude(p => p.Uruns)
                                    .OrderBy(p => p.Kullanici.AdSoyad)
                                    .Take(musteriSayisi)
                                    .ToList();

            return musteriBazli;
        }

        // Kullanıcıların Toplam Harcama Tutarı ve Sipariş Sayısı
        public void KullaniciToplamHarcamaYazdir()
        {
            var sipKullanici = _db.Sipsaris
                                    .Include(p => p.Kullanici)
                                    .ToList()
                                    .GroupBy(g => new
                                    {
                                        g.Kullanici.Id,
                                        g.Kullanici.AdSoyad
                                    })
                                    .Select(s => new
                                    {
                                        kullaniciAd = s.Key.AdSoyad,
                                        sipSayisi = s.Count(),
                                        toplamHarcama = s.Sum(t=> t.Toplam)
                                    })
                                    .ToList();

            foreach (var item in sipKullanici)
            {
                Console.WriteLine($"{item.kullaniciAd} - Sipariş Tutarı: {item.toplamHarcama.ToString("N0")} TL - Sipariş Sayısı : {item.sipSayisi}");
            }
        }

        #endregion

        #region ÜRÜN KATEGORİ İŞLEMLERİ
        // Ürün Kategorisi Ekle (tek)
        public string UrunKategoriEkle(UrunKategori dataKategori)
        {
            _db.Kategoris.Add(dataKategori);
            _db.SaveChanges();

            return $"Kategori eklendi";
        }

        // Ürün Kategorisi Ekle (çoklu)
        public string UrunKategorisiEkleToplu(List<UrunKategori> dataKategoriler)
        {
            _db.Kategoris.AddRange(dataKategoriler);
            _db.SaveChanges();

            return $"Kategori ürün listesi eklendi";
        }

        // Kategorileri Sıraya Göre Listele
        public List<UrunKategori> UrunKategoriListele()
        {
            return _db.Kategoris.OrderBy(p => p.Sira).ToList();
        }

        // Kategori Id sine göre o kategoriye ait ürünleri listeleme
        public List<Urun> GetUrunByCategory(int kategoriId)
        {
            return _db.Uruns
                .Where(p => p.Id == kategoriId)
                .ToList();
        }

        // Kategori Bazlı Ürün Satış Gelirleri


        #endregion

        #region ÜRÜN EKLEME İŞLEMLERİ
        // Ürün Ekle (tekli)
        public string UrunEkle(Urun urunTek)
        {
            _db.Uruns.Add(urunTek);
            _db.SaveChanges();

            return $"Ürün eklendi";
        }


        // Ürün Ekle (toplu)
        public string UrunEkleToplu(List<Urun> urunToplu)
        {
            _db.Uruns.AddRange(urunToplu);
            _db.SaveChanges();

            return $"Urunler eklendi";
        }
        #endregion

        #region SİPARİŞ İŞLEMLERİ

        // Sipariş Ekleme (tek)
        public string SiparisEkle(Siparis siparis)
        {
            _db.Sipsaris.Add(siparis);
            _db.SaveChanges();

            return $"Sipariş eklendi";
        }


        // Sipariş Ekleme (toplu)
        public string SiparisEkleToplu(List<Siparis> siparisToplu)
        {
            _db.Sipsaris.AddRange(siparisToplu);
            _db.SaveChanges();

            return $"Siparişler eklendi";
        }
        #endregion

        #region KATEGORİ BAZLI ÜRÜN LİSTESİ
        public void KategoriBazliUrunListesi()
        {
            List<UrunKategori> kategoriler = _db.Kategoris.OrderBy(p => p.Adi).ToList();

            foreach (var kategori in kategoriler)
            {
                Console.WriteLine($"Kategori: {kategori.Adi} [{kategori.KategoriNo}] - {kategori.Aciklama}");
                Console.WriteLine("--------------------------------------------");

                var urunler = _db.Uruns
                    .Where(u => u.KategoriId == kategori.Id)
                    .Select(s => new
                    {
                        s.BarkodNo,
                        s.Adi,
                        s.BirimFiyat,
                        s.Stok
                    })
                    .OrderBy(u => u.Adi)
                    .ToList();

                foreach (var urun in urunler)
                {
                    Console.WriteLine($"   {urun.BarkodNo} - {urun.Adi} - {urun.BirimFiyat} TL - {urun.Stok} ad.");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        #endregion

        #region SİPARİŞ DETAY İŞLEMLERİ (SiparisItem)

        // SiparisItem Ekle (tek)
        public string SiparisItemEkle(SiparisItem itemSiparis)
        {
            _db.SiparisItems.Add(itemSiparis);
            _db.SaveChanges();

            return $"Sipariş Ürünü eklendi";
        }


        // SiparisItem Ekle (toplu)
        public string SiparisItemEkleToplu(List<SiparisItem> itemSiparisToplu)
        {
            _db.SiparisItems.AddRange(itemSiparisToplu);
            _db.SaveChanges();

            return "Sipariş detayları eklendi";
        }


        // SiparisItem Listele
        public List<SiparisItem> SiparisItemListele()
        {
            return _db.SiparisItems.ToList();
        }


        // Sipariş bazlı SiparişItem Toplamı
        public void SiparisItemGrupBazliToplam(List<SiparisItem> siparisItems)
        {
            var liste = _db.SiparisItems
                          .GroupBy(p => p.SiparisId)
                          .Select(x => new
                          {
                              SiparisId = x.Key,
                              toplamAra = x.Sum(p => p.AraToplam)
                          });

            foreach (var item in liste)
            {
                Console.WriteLine($"Sipariş Id: {item.SiparisId} - Sipariş toplamı: {item.toplamAra}");
            }
        }
        #endregion

    }
}
