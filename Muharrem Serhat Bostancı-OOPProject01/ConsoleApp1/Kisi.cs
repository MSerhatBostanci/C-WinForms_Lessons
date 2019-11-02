using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kisi
    {
        private string AdSoyad; //field'dır
        internal int Yas { get; set; } // Property'dir.
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        protected internal int KrediKartNo { get; set; }
        protected int TcKimlik { get; set; }
        public string FulName()
        {
            // return this.Ad + this.Soyad;
            // eklendi
            AdSoyad = this.Ad + this.Soyad;
            return AdSoyad;
        }
    }
}
