using Ispit.Proizvodi.Klase;
using System.Runtime.CompilerServices;

namespace Ispit.Proizvodi
{

    //Globalni delegat
    public delegate void PocniPisatiIspit(DateTime vrijemePisanja);
    internal class Program
    {
        //globalna varijabla datuma da znamo kada je počeo ispit te ju koristimo pojedinačno na polaznicima.
        static DateTime _vrijemeIspita;


        static void Main(string[] args)
        {
            //PARCIJALNI ZADATAK Nr3

         
            //instanciramo objekte predavac
            var predavac = new Predavac();
            //pretplata
            predavac.Ispit += VrijemePocetkaIspita;

           
            //polaznici
            var listaPolaznika = new List<Polaznik>()
            {
                new Polaznik() {ImePrezime = "Grga Čvarak" },
                new Polaznik() {ImePrezime = "Petrica Kerempuh" },
                new Polaznik() {ImePrezime = "Pero Kvržica" },
                new Polaznik() {ImePrezime = "Filip Latinović" }
            };

            //počinje ispit
            predavac.ZvoniZvono();


            // izmjesali smo ih sortiranjem 

            listaPolaznika.Sort((a, b) => a.ImePrezime.CompareTo(b.ImePrezime));

            foreach (var polaznik in listaPolaznika)
            {
                polaznik.OdgovoriNaPitanja(_vrijemeIspita);
            }

            //odabiramo jednog da preda ispit.

            var trazeniPolaznik = listaPolaznika.FirstOrDefault(p => p.ImePrezime.StartsWith("Pero"));

            trazeniPolaznik.IspitZavrsen += IspitZavrsen;

            trazeniPolaznik?.PredajOdgovoreNaPitanja();

            predavac.IspitZaprimljen(trazeniPolaznik);

        }

        private static void IspitZavrsen(Polaznik polaznik)
        {
            Console.WriteLine($"\nPolaznik {polaznik.ImePrezime} je predao odgovore!");
        }

        public static void VrijemePocetkaIspita(DateTime vrijeme)
        {
            _vrijemeIspita = vrijeme;
        }
    }
}
