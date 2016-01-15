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


    public partial class Main : Form
    {
        public static string ActualWindow;
        public Main()
        {
            InitializeComponent();
        }

        private void btnFirmy_Click(object sender, EventArgs e)
        {
            Firmy firm = new Firmy();
            firm.Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel();
            pers.Show();
        }

        private void btnGoscie_Click(object sender, EventArgs e)
        {
            Goście gosc = new Goście();
            gosc.Show();
        }

        private void btnPomieszczenia_Click(object sender, EventArgs e)
        {
            Pomieszczenia pom = new Pomieszczenia();
            pom.Show();
        }

        private void btnZakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
