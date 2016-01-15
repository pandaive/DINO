namespace Obsługa_biurowca
{
    partial class Goście
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
            this.btnWyjdz = new System.Windows.Forms.Button();
            this.dgvGoscie = new System.Windows.Forms.DataGridView();
            this.btnOdswiez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoscie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(511, 30);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnWyjdz
            // 
            this.btnWyjdz.Location = new System.Drawing.Point(279, 220);
            this.btnWyjdz.Name = "btnWyjdz";
            this.btnWyjdz.Size = new System.Drawing.Size(244, 30);
            this.btnWyjdz.TabIndex = 4;
            this.btnWyjdz.Text = "Wyjdź";
            this.btnWyjdz.UseVisualStyleBackColor = true;
            this.btnWyjdz.Click += new System.EventHandler(this.btnWyjdz_Click);
            // 
            // dgvGoscie
            // 
            this.dgvGoscie.AllowUserToAddRows = false;
            this.dgvGoscie.AllowUserToDeleteRows = false;
            this.dgvGoscie.AllowUserToOrderColumns = true;
            this.dgvGoscie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoscie.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGoscie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoscie.Location = new System.Drawing.Point(12, 48);
            this.dgvGoscie.Name = "dgvGoscie";
            this.dgvGoscie.ReadOnly = true;
            this.dgvGoscie.Size = new System.Drawing.Size(511, 167);
            this.dgvGoscie.TabIndex = 6;
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Location = new System.Drawing.Point(12, 220);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(261, 30);
            this.btnOdswiez.TabIndex = 7;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // Goście
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 262);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.dgvGoscie);
            this.Controls.Add(this.btnWyjdz);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Goście";
            this.Text = "Goście";
            this.Load += new System.EventHandler(this.Goście_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoscie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnWyjdz;
        private System.Windows.Forms.DataGridView dgvGoscie;
        private System.Windows.Forms.Button btnOdswiez;
    }
}