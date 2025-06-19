using DersWebSatis.Data;
using DersWebSatis.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        #endregion

    }
}
