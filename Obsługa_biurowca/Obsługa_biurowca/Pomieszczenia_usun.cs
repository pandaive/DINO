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
    public partial class Pomieszczenia_usun : Form
    {
        DB_Access access = new DB_Access();
        public Pomieszczenia_usun()
        {
            InitializeComponent();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            String message = access.usun_pomieszczenie(cBPokoj.Text, cBPietro.Text);
            MessageBox.Show(message);

            if (message == "Pomieszczenie pomyślnie usunięte z bazy!")
            this.Close();
        }

        /**
         * Pobranie listy pięter (piętr?).
         */
        private void Pomieszczenia_usun_Load(object sender, EventArgs e)
        {
            DataTable tbl = access.PietroFirmy();
            cBPietro.ValueMember = "numer";
            cBPietro.DisplayMember = "pietro";
            cBPietro.DataSource = tbl;
        }

        /**
         * Pobranie listy pokoi na piętrach.
         */
        private void cBPietro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable tbl = access.PokojePietra(cBPietro.Text);
            cBPokoj.ValueMember = "numer";
            cBPokoj.DisplayMember = "pietro";
            cBPokoj.DataSource = tbl;
        }
    }
}
