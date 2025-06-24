using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ispit.Proizvodi.Klase.Polaznik;

namespace Ispit.Proizvodi.Klase
{
    public class Predavac
    {
        public event PocniPisatiIspit Ispit;

        public void ZvoniZvono()
        {
            Console.WriteLine("Din don din don zvoni zvono te ispit počinje");

            Ispit.Invoke(DateTime.Now);
        }

        public void IspitZaprimljen(Polaznik polaznik)
        {
            Console.WriteLine($"Zaprimljen ispit od polaznika: {polaznik.ImePrezime}");
        }
    }
}
