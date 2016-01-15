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
    public partial class Personel_usun : Form
    {
        DB_Access access = new DB_Access();

        public Personel_usun()
        {
            InitializeComponent();
        }


        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            String message = access.usun_pracownika(cBImie.Text, cBNazwisko.Text);
            MessageBox.Show(message);

            if (message == "Pracownik usunięty z bazy danych!")            
            this.Close();
        }

        /**
         * Pobieranie listy nazwisk.
         */
        private void Personel_usun_Load(object sender, EventArgs e)
        {
            DataTable tbl = access.Nazwiska();
            cBNazwisko.ValueMember = "nazwisko";
            cBNazwisko.DisplayMember = "pracownik";
            cBNazwisko.DataSource = tbl;
        }

        /**
         * Po wybraniu nazwiska pojawia się lista imion osób o tym nazwisku.
         */
        private void cBNazwisko_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tbl = access.Imiona(cBNazwisko.Text);
            cBImie.ValueMember = "imie";
            cBImie.DisplayMember = "pracownik";
            cBImie.DataSource = tbl;
        }
    }
}
