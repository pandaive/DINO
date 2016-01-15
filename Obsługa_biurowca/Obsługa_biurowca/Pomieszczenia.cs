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
    public partial class Pomieszczenia : Form
    {
        DB_Access access = new DB_Access();
        public Pomieszczenia()
        {
            InitializeComponent();
        }

        private void btnWyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Pomieszczenia_dodaj pom_dod = new Pomieszczenia_dodaj();
            pom_dod.Show();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Pomieszczenia_usun pom_usun = new Pomieszczenia_usun();
            pom_usun.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pietro_dodaj pietro_dod = new Pietro_dodaj();
            pietro_dod.Show();
        }

        private void Pomieszczenia_Load(object sender, EventArgs e)
        {
            DataSet ds = access.Tabela("select pietro as 'Piętro', numer as 'Pokój' from Pokoje order by pietro");
            dgvPomieszczenia.DataSource = ds.Tables["Biurowiec"].DefaultView;
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            DataSet ds = access.Tabela("select pietro as 'Piętro', numer as 'Pokój' from Pokoje order by pietro");
            dgvPomieszczenia.DataSource = ds.Tables["Biurowiec"].DefaultView;
        }

    }
}
