using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeObjekata
{
    internal class Igra
    {
        private string naziv;
        private string opis;
        private string vrsta;
        private DateTime datumIzdavanja;
        private double cijena;
        private string izdavac;

        //public properties
        public string Naziv
        {
            get => naziv;
            /* stariji način
             get {
                return naziv;
            }
             */
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Naziv ne smije biti prazan");
                naziv = value;
            }
        }

        public string Opis { get => opis; set => opis = value; }
        public string Vrsta
        {
            get => vrsta;
            set
            {
                var dozvoljeneVrste = new[] { "Akcijska", "RPG", "Avantura", "Simulacija", "Sport", "Strategija" };
                if (!dozvoljeneVrste.Contains(value))
                    throw new ArgumentException("Vrsta nije jedna od dozvoljenih vrijednosti");
                vrsta = value;
            }
        }
        public DateTime DatumIzdavanja
        {
            get => datumIzdavanja;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Datum ne smije biti u budućnosti");
                datumIzdavanja = value;
            }
        }
        public double Cijena
        {
            get => cijena;
            set
            {
                if (value < 0 || value > 1000)
                    throw new ArgumentException("Cijena mora biti između 0-1000");
                cijena = value;
            }
        }
        public string Izdavac { get => izdavac; set => izdavac = value; }
    }
}
