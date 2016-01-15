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
    public partial class Firmy : Form
    {
        DB_Access access = new DB_Access();
        public Firmy()
        {
            InitializeComponent();
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Firmy_dodaj frm_dod = new Firmy_dodaj();
            frm_dod.Show();

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Firmy_usun frm_usun = new Firmy_usun();
            frm_usun.Show();

        }

        private void btnWyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Wyświetla tabelę.
         */
        private void Firmy_Load(object sender, EventArgs e)
        {
            DataSet ds = access.Tabela("select nazwa, pietro from Firmy order by pietro");
            dgvFirmy.DataSource = ds.Tables["Biurowiec"].DefaultView;
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            DataSet ds = access.Tabela("select nazwa, pietro from Firmy order by pietro");
            dgvFirmy.DataSource = ds.Tables["Biurowiec"].DefaultView;
        }
    }
}
