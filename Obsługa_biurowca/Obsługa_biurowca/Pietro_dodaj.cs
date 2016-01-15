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
    public partial class Pietro_dodaj : Form
    {
        DB_Access access = new DB_Access();
        public Pietro_dodaj()
        {
            InitializeComponent();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            String message = access.dodaj_pietro(tBPietro.Text);
            MessageBox.Show(message);

            if (message == "Piętro wprowadzone pomyślnie do bazy!")
            this.Close();
        }
    }
}
