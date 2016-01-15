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
    public partial class Firmy_usun : Form
    {
        DB_Access access = new DB_Access();

        public Firmy_usun()
        {
            InitializeComponent();
        }

        
        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            String message = access.usun_firme(cBFirma.Text);
            MessageBox.Show(message);

            this.Close();
        }

        /**
         * Wyświetla listę firm.
         */
        private void Firmy_usun_Load(object sender, EventArgs e)
        {
            DataTable tbl = access.ListaFirm();
            cBFirma.ValueMember = "nazwa";
            cBFirma.DisplayMember = "firma";
            cBFirma.DataSource = tbl;
        }




    }
}
