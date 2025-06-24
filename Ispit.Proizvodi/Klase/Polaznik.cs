using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Proizvodi.Klase
{
    public class Polaznik
    {

        public delegate void PredajIspit(Polaznik polaznik);
        public event PredajIspit? IspitZavrsen;
        public string ImePrezime { get; set; }

        public void OdgovoriNaPitanja(DateTime vrijemePocetka)
        {
            Console.WriteLine($"\n {ImePrezime}             {vrijemePocetka.ToString("dd.MM.yyyy HH:mm:ss")} - Pocnite odgovarati na pitanja");
            Console.WriteLine("******************************************************");
            
        }

        public void PredajOdgovoreNaPitanja()
        {
            IspitZavrsen?.Invoke(this);
        }

    }
}
