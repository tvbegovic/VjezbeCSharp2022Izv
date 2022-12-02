using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igre_Klase
{
    public partial class Glavna : Form
    {
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

                MessageBox.Show("Podaci su uspješno uneseni");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
