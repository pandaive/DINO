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
    public partial class Pomieszczenia_dodaj : Form
    {
        DB_Access access = new DB_Access();
        public Pomieszczenia_dodaj()
        {
            InitializeComponent();
        }

        public void close() {
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            String message = access.dodaj_pomieszczenie(tBNr.Text, cBPietro.Text);
            MessageBox.Show(message);

            if (message == "Pokój wprowadzony pomyślnie do bazy!")
            this.Close();
        }

        /**
         * Pobranie listy pięter (piętr?).
         */
        private void Pomieszczenia_dodaj_Load(object sender, EventArgs e)
        {
            DataTable tbl = access.PietroFirmy();
            cBPietro.ValueMember = "numer";
            cBPietro.DisplayMember = "pietro";
            cBPietro.DataSource = tbl;
        }
    }
}
