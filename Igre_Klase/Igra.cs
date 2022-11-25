using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igre_Klase
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

    }
}
