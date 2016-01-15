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
    public partial class Personel_dodaj : Form
    {
        DB_Access access = new DB_Access();
        public Personel_dodaj()
        {
            InitializeComponent();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {

            String message = access.dodaj_pracownika(tBNazwisko.Text, tBImie.Text, tBStanowisko.Text, cBFirma.Text,
                cBPokoj.Text, tBTelefon.Text, tBEmail.Text);
            MessageBox.Show(message);
            if (message == "Pracownik dodany pomyślnie!")
            this.Close();
        }

        /**
         * Pobieranie listy firm.
         */
        private void Personel_dodaj_Load(object sender, EventArgs e)
        {
            DataTable tblF = access.ListaFirm();
            cBFirma.ValueMember = "nazwa";
            cBFirma.DisplayMember = "firma";
            cBFirma.DataSource = tblF;

        }

        /**
         * Po wybraniu firmy pokazuje się lista dostępnych pokoi.
         */
        private void cBFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tblP = access.PokojeFirmy(cBFirma.Text);
            cBPokoj.ValueMember = "numer";
            cBPokoj.DisplayMember = "pokoj";
            cBPokoj.DataSource = tblP;
        }
    }
}
