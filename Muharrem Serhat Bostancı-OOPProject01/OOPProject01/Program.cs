using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject01
{
    public abstract class Kahve
    {
        public abstract string Uzerine();
        private string KahveCekirdek()
        {
            return "Arabic";
        }
        public string KahveCekirdegi()
        {
            return KahveCekirdek();
        }
        public virtual string EspressoShot()
        {
            return "1 Shot Espresso";
        }
        protected virtual string Surup()
        {
            return "Fındık Şurubu";
        }
    }

    public class Americano : Kahve
    {
        public override string Uzerine()
        {
            return "Sıcak Su";
        }
        public override string EspressoShot()
        {
            return "2 Shot Espresso";
        }
    }

    public class Latte : Kahve
    {
        public override string Uzerine()
        {
            return "Buharda Isıtılmış Süt";
        }
        public string EkstraMazleme()
        {
            return Surup();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kahve khv = new Americano();
            Console.WriteLine(" Americano Tarifi : ");
            Console.WriteLine();
            Console.WriteLine(" Kahve Çekirdeği = " + khv.KahveCekirdegi());
            Console.WriteLine(" Espresso Miktarı = " + khv.EspressoShot());
            Console.WriteLine(" Üzerine eklenen malzeme = " + khv.Uzerine());
            Console.WriteLine();

            Kahve khvl = new Latte();
            Console.WriteLine(" Latte Tarifi : ");
            Console.WriteLine();
            Console.WriteLine(" Kahve Çekirdeği = " + khvl.KahveCekirdegi());
            Console.WriteLine(" Espresso Miktarı = " + khvl.EspressoShot());
            Console.WriteLine(" Üzerine eklenen malzeme = " + khvl.Uzerine());
            Console.WriteLine();

            Latte khvlf = new Latte();
            Console.WriteLine(" Fındık Latte Tarifi : ");
            Console.WriteLine();
            Console.WriteLine(" Kahve Çekirdeği = " + khvl.KahveCekirdegi());
            Console.WriteLine(" Espresso Miktarı = " + khvl.EspressoShot());
            Console.WriteLine(" Üzerine eklenen malzeme = " + khvl.Uzerine());
            Console.WriteLine(" Ekstra Ürün = " + khvlf.EkstraMazleme());

            Console.ReadLine();
        }
    }
}
