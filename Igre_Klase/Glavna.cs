﻿using System;
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
            var igra = new Igra();
            igra.Naziv = "";
        }
    }
}
