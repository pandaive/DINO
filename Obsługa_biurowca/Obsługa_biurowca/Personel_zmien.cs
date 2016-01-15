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
    public partial class Personel_zmien : Form
    {
        DB_Access access = new DB_Access();
        public Personel_zmien()
        {
            InitializeComponent();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAnuluj_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Personel_zmien_Load(object sender, EventArgs e)
        {
            DataTable tbl = access.Nazwiska();
            cBNazwisko.ValueMember = "nazwisko";
            cBNazwisko.DisplayMember = "pracownik";
            cBNazwisko.DataSource = tbl;

            DataTable tblF = access.ListaFirm();
            cBFirmaDod.ValueMember = "nazwa";
            cBFirmaDod.DisplayMember = "firma";
            cBFirmaDod.DataSource = tblF;
        }

        private void cBNazwisko_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tbl = access.Imiona(cBNazwisko.Text);
            cBImie.ValueMember = "imie";
            cBImie.DisplayMember = "pracownik";
            cBImie.DataSource = tbl;
        }

        /**
         * Po wybraniu nazwiska aktualizuje się lista imion ludzi o tym nazwisku.
         */
        private void cBImie_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tbl = access.FirmaPracownika(cBImie.Text, cBNazwisko.Text);
            cBFirma.ValueMember = "nazwa";
            cBFirma.DisplayMember = "firmy";
            cBFirma.DataSource = tbl;
        }

        /**
         * Po wybraniu nazwiska i imienia pojawia się lista firm, w których taki pracownik istnieje.
         */
        private void cBFirmaDod_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tblP = access.PokojeFirmy(cBFirmaDod.Text);
            cBPokoj.ValueMember = "numer";
            cBPokoj.DisplayMember = "pokoj";
            cBPokoj.DataSource = tblP;
        }

        private void btnAkceptuj_Click_1(object sender, EventArgs e)
        {
            String message = access.edytuj_pracownika(cBNazwisko.Text, cBImie.Text, cBFirma.Text, tBNazwisko.Text, tBImie.Text, 
                cBFirmaDod.Text,tBStanowisko.Text, cBPokoj.Text, tBTelefon.Text, tBEmail.Text);
            MessageBox.Show(message);
            this.Close();
        }




    }
}
