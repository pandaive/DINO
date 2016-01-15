namespace Obsługa_biurowca
{
    partial class Personel
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
            this.btnWyjdz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.btnZmien = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWyjdz
            // 
            this.btnWyjdz.Location = new System.Drawing.Point(290, 332);
            this.btnWyjdz.Name = "btnWyjdz";
            this.btnWyjdz.Size = new System.Drawing.Size(277, 30);
            this.btnWyjdz.TabIndex = 7;
            this.btnWyjdz.Text = "Wyjdź";
            this.btnWyjdz.UseVisualStyleBackColor = true;
            this.btnWyjdz.Click += new System.EventHandler(this.btnWyjdz_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(13, 43);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(554, 29);
            this.btnUsun.TabIndex = 6;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(14, 9);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(553, 28);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.AllowUserToAddRows = false;
            this.dgvPersonel.AllowUserToDeleteRows = false;
            this.dgvPersonel.AllowUserToOrderColumns = true;
            this.dgvPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonel.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Location = new System.Drawing.Point(14, 117);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.ReadOnly = true;
            this.dgvPersonel.Size = new System.Drawing.Size(553, 209);
            this.dgvPersonel.TabIndex = 8;
            // 
            // btnZmien
            // 
            this.btnZmien.Location = new System.Drawing.Point(13, 78);
            this.btnZmien.Name = "btnZmien";
            this.btnZmien.Size = new System.Drawing.Size(554, 29);
            this.btnZmien.TabIndex = 9;
            this.btnZmien.Text = "Zmień dane pracownika";
            this.btnZmien.UseVisualStyleBackColor = true;
            this.btnZmien.Click += new System.EventHandler(this.btnZmien_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Location = new System.Drawing.Point(13, 332);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(271, 30);
            this.btnOdswiez.TabIndex = 10;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 374);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnZmien);
            this.Controls.Add(this.dgvPersonel);
            this.Controls.Add(this.btnWyjdz);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Personel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWyjdz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.Button btnZmien;
        private System.Windows.Forms.Button btnOdswiez;

    }
}