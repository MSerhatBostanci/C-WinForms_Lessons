using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject03
{
    public class BAU
    {
        //BAU CLass'ı veri üretmek için hazırlanmıştır
        string[] Adlar = { "Şamil", "Cemal", "Ali", "Murat", "Kemal", "Şahin", "Hüseyin" };
        string[] Soyadlar = { "Yıldız", "Erkmen", "Kahraman", "Erdemir" };
        string[] Sehirler = { "Ankara", "İstanbul", "İzmir", "Eskişehir", "Adana","Kastamonu", "Denizli" };

        //static eklenecek
        static Random rnd = new Random();

        public string[] SehirlerArray
        {
            get
            {
                return Sehirler;
            }
        }

        public string GetName()
        {
            int sayi = rnd.Next(0, Adlar.Length);
            return Adlar[sayi];
        }
        public string GetSurName()
        {
            int sayi = rnd.Next(0, Soyadlar.Length);
            return Soyadlar[sayi];
        }
        public string GetCity()
        {
            int sayi = rnd.Next(0, Sehirler.Length);
            return Sehirler[sayi];
        }
        public DateTime GetBackDate(int sayi)
        {
            int yılDegiskeni = rnd.Next(0, sayi);

            //sayi = -1 * rnd.Next(0, sayi);
            //return DateTime.Now.AddYears(-sayi);

            //DateTime bulunanYıl = DateTime.Now;
            //DateTime gonderilecekYıl = bulunanYıl.AddYears(-yılDegiskeni);

            DateTime gonderilecekYıl = DateTime.Now.AddYears(-yılDegiskeni);
            return gonderilecekYıl;
        }
        public DateTime GetForwardDate(int sayi)
        {
            int yılDegiskeni = rnd.Next(0, sayi);
            DateTime gonderilecekYıl = DateTime.Now.AddYears(yılDegiskeni);
            return gonderilecekYıl;
        }
        public LifeDurationInfo GetLifeDurations(DateTime birthDate)
        {
            LifeDurationInfo lfd = new LifeDurationInfo();

            int ty = DateTime.Now.Year - birthDate.Year;
            lfd.calculatedAge = ty;

            TimeSpan ts = DateTime.Now.Subtract(birthDate);

            double td = ts.TotalDays;
            lfd.calculatedDays = td;

            double th = ts.TotalHours;
            lfd.calculatedHours = th;

            double tm = ts.TotalMinutes;
            lfd.calculatedMinutes = tm;

            double tsc = ts.TotalSeconds;
            lfd.calculatedSeconds = tsc;

            double tmsc = ts.TotalMilliseconds;
            lfd.calculatedMilliseconds = tmsc;

            return lfd;
            
            //return Convert.ToInt32(DateTime.Now.Subtract(birthDate));
        }
    }
}
