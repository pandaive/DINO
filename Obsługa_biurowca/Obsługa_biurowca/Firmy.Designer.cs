namespace Obsługa_biurowca
{
    partial class Firmy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnWyjdz = new System.Windows.Forms.Button();
            this.dgvFirmy = new System.Windows.Forms.DataGridView();
            this.btnOdswiez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirmy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(40, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(257, 28);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(39, 46);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(258, 29);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnWyjdz
            // 
            this.btnWyjdz.Location = new System.Drawing.Point(168, 254);
            this.btnWyjdz.Name = "btnWyjdz";
            this.btnWyjdz.Size = new System.Drawing.Size(129, 30);
            this.btnWyjdz.TabIndex = 4;
            this.btnWyjdz.Text = "Wyjdź";
            this.btnWyjdz.UseVisualStyleBackColor = true;
            this.btnWyjdz.Click += new System.EventHandler(this.btnWyjdz_Click);
            // 
            // dgvFirmy
            // 
            this.dgvFirmy.AllowUserToAddRows = false;
            this.dgvFirmy.AllowUserToDeleteRows = false;
            this.dgvFirmy.AllowUserToOrderColumns = true;
            this.dgvFirmy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFirmy.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFirmy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirmy.Location = new System.Drawing.Point(40, 81);
            this.dgvFirmy.Name = "dgvFirmy";
            this.dgvFirmy.ReadOnly = true;
            this.dgvFirmy.Size = new System.Drawing.Size(257, 167);
            this.dgvFirmy.TabIndex = 5;
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Location = new System.Drawing.Point(39, 254);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(129, 30);
            this.btnOdswiez.TabIndex = 6;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // Firmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 296);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.dgvFirmy);
            this.Controls.Add(this.btnWyjdz);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Firmy";
            this.Text = "Firmy";
            this.Load += new System.EventHandler(this.Firmy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirmy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnWyjdz;
        private System.Windows.Forms.DataGridView dgvFirmy;
        private System.Windows.Forms.Button btnOdswiez;
    }
}