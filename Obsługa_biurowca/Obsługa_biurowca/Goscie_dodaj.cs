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
    public partial class Goscie_dodaj : Form
    {

        DB_Access access = new DB_Access();
        public Goscie_dodaj()
        {
            InitializeComponent();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            
            try
            {
                int Wejscie = int.Parse(tBGodzWej.Text + tBMinWej.Text);
                int Wyjscie = int.Parse(tBGodzWyj.Text + tBMinWyj.Text);
                if ((Wyjscie - Wejscie) < 0) {
                    MessageBox.Show("Podana godzina opuszczenia budynku jest wcześniejsza niż godzina wejścia do budynku!");
                    return;
                }
            }
            catch(FormatException f)
            {
                MessageBox.Show("Błąd w formacie godziny!");
                return;
            }

            try
            {
                int Data = int.Parse(cBDzien.Text + cBMiesiac.Text + cBRok.Text);
            }
            catch (FormatException f) {
                MessageBox.Show("Błąd w formacie daty!");
                return;
            }

            String message = access.dodaj_goscia(tBImie.Text, tBNazwisko.Text, cBDzien.Text,
                cBMiesiac.Text, cBRok.Text, tBGodzWej.Text, tBMinWej.Text, tBGodzWyj.Text,
                tBMinWyj.Text, cBImie.Text, cBNazwisko.Text);
            
            MessageBox.Show(message);

            if (message == "Gość dodany pomyślnie!")
            this.Close();
        }

        private void Goscie_dodaj_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++) {
                cBDzien.Items.Add("0" + i);
                cBMiesiac.Items.Add("0" + i);
            }
            for (int d = 10; d < 32; d++)
                cBDzien.Items.Add(d);
            for (int m = 10; m < 13; m++)
                cBMiesiac.Items.Add(m);
            DateTime dt = DateTime.Now;
            cBRok.Items.Add(dt.Year);

            DataTable tbl = access.Nazwiska();
            cBNazwisko.ValueMember = "nazwisko";
            cBNazwisko.DisplayMember = "pracownik";
            cBNazwisko.DataSource = tbl;
        }

        /**
         * Po wybraniu nazwiska pojawia się lista imion osób o podanym nazwisku.
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
