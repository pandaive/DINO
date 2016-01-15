using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Obsługa_biurowca
{
    public partial class Firmy_dodaj : Form
    {
        DB_Access access = new DB_Access();
        public Firmy_dodaj()
        {
            InitializeComponent();
        }


        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            String message = access.dodaj_firme(tBNazwa.Text, cBPietro.Text);
            MessageBox.Show(message);
            if (message == "Firma dodana pomyślnie!")
            this.Close();

        }

        /**
         * Wypełnia listę dostępnych piętr.
         */
        private void Firmy_dodaj_Load(object sender, EventArgs e)
        {
            DataTable tbl = access.PietroFirmy();
            cBPietro.ValueMember = "numer";
            cBPietro.DisplayMember = "pietro";
            cBPietro.DataSource = tbl;
        }
    }
}
