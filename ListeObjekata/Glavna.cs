using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListeObjekata
{
    public partial class Glavna : Form
    {
        List<Igra> igre = new List<Igra>();

        public Glavna()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                var unos = txtCijena.Text;
                var ok = double.TryParse(unos, out double cijena);
                if (!ok)
                {
                    MessageBox.Show("Pogrešan format cijene");
                    return;
                }
                unos = txtDatum.Text;
                ok = DateTime.TryParse(unos, out DateTime datum);
                if (!ok)
                {
                    MessageBox.Show("Pogrešan format datuma");
                    return;
                }
                var igra = new Igra();
                igra.Naziv = txtNaziv.Text;
                igra.Opis = txtOpis.Text;
                igra.Cijena = cijena;
                igra.Izdavac = txtIzdavac.Text;
                igra.DatumIzdavanja = datum;
                igra.Vrsta = txtVrsta.Text;

                igre.Add(igra);
                AzurirajGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void AzurirajGrid()
        {
            dgvIgre.DataSource = null;
            dgvIgre.DataSource = igre;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var datoteka = new StreamWriter("igre.txt");
            foreach (var igra in igre)
            {
                datoteka.WriteLine("{0};{1};{2};{3};{4};{5}", igra.Naziv, igra.Opis, igra.Vrsta, igra.DatumIzdavanja,
                    igra.Cijena, igra.Izdavac);
            }
            datoteka.Close();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            var redci = File.ReadAllLines("igre.txt");
            foreach(var red in redci)
            {
                var stupci = red.Split(';');
                var igra = new Igra();
                igra.Naziv = stupci[0];
                igra.Opis = stupci[1];
                igra.Vrsta = stupci[2];
                var ok = DateTime.TryParse(stupci[3], out DateTime datum);
                if (ok)
                    igra.DatumIzdavanja = datum;
                ok = double.TryParse(stupci[4], out double cijena);
                if (ok)
                    igra.Cijena = cijena;
                igra.Izdavac = stupci[5];
                igre.Add(igra);
            }
            AzurirajGrid();
        }
    }
}
