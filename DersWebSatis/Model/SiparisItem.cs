using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersWebSatis.Model
{
    public class SiparisItem
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public double UrunFiyat { get; set; }
        public int Adet { get; set; }
        public double AraToplam { get; set; }

        public int SiparisId { get; set; }
        [ForeignKey("SiparisId")]
        public Siparis Siparis { get; set; }

        public ICollection<Urun> Uruns { get; set; }
    }
}
