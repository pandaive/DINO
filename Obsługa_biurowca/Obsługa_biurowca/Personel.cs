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
    public partial class Personel : Form
    {
        DB_Access access = new DB_Access();
        public Personel()
        {
            InitializeComponent();
        }

        private void btnWyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Personel_dodaj pers_dod = new Personel_dodaj();
            pers_dod.Show();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Personel_usun pers_usun = new Personel_usun();
            pers_usun.Show();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            DataSet ds = access.Tabela("select nazwisko as 'Nazwisko', imie as 'Imię', " +
            "stanowisko as 'Stanowisko', (select nazwa from Firmy where id=firma) as 'Firma', pokoj as 'Pokój', " +
            "telefon as 'Telefon', email as 'E-mail' from Pracownicy_firm order by nazwisko");
            dgvPersonel.DataSource = ds.Tables["Biurowiec"].DefaultView;
        }

        private void btnZmien_Click(object sender, EventArgs e)
        {
            Personel_zmien pers_zmien = new Personel_zmien();
            pers_zmien.Show();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            DataSet ds = access.Tabela("select nazwisko as 'Nazwisko', imie as 'Imię', " +
            "stanowisko as 'Stanowisko', (select nazwa from Firmy where id=firma) as 'Firma', pokoj as 'Pokój', " +
            "telefon as 'Telefon', email as 'E-mail' from Pracownicy_firm order by nazwisko");
            dgvPersonel.DataSource = ds.Tables["Biurowiec"].DefaultView;
        }
    }
}
