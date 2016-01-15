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
    public partial class Goście : Form
    {
        DB_Access access = new DB_Access();

        public Goście()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Goscie_dodaj gsc_dod = new Goscie_dodaj();
            gsc_dod.Show();
        }

        private void btnWyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goście_Load(object sender, EventArgs e)
        {
            DataSet ds = access.Tabela("select nazwisko AS 'Nazwisko', imie AS 'Imię', " +
            "data_odwiedzin AS 'Data', godzina_wejscia AS 'Przyjście', godzina_wyjscia AS 'Wyjście',"+
            " odwiedzany AS 'Odwiedzany' from Goscie");
            dgvGoscie.DataSource = ds.Tables["Biurowiec"].DefaultView;
            
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            DataSet ds = access.Tabela("select nazwisko AS 'Nazwisko', imie AS 'Imię', " +
            "data_odwiedzin AS 'Data', godzina_wejscia AS 'Przyjście', godzina_wyjscia AS 'Wyjście'," +
            " odwiedzany AS 'Odwiedzany' from Goscie");
            dgvGoscie.DataSource = ds.Tables["Biurowiec"].DefaultView;
        }

    }
}
