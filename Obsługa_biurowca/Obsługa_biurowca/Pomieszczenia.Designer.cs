namespace Obsługa_biurowca
{
    partial class Pomieszczenia
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
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnWyjdz = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvPomieszczenia = new System.Windows.Forms.DataGridView();
            this.btnOdswiez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPomieszczenia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(12, 51);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(207, 30);
            this.btnUsun.TabIndex = 7;
            this.btnUsun.Text = "Usuń pokój";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(207, 33);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj pokój";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnWyjdz
            // 
            this.btnWyjdz.Location = new System.Drawing.Point(225, 285);
            this.btnWyjdz.Name = "btnWyjdz";
            this.btnWyjdz.Size = new System.Drawing.Size(210, 30);
            this.btnWyjdz.TabIndex = 8;
            this.btnWyjdz.Text = "Wyjdź";
            this.btnWyjdz.UseVisualStyleBackColor = true;
            this.btnWyjdz.Click += new System.EventHandler(this.btnWyjdz_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Dodaj piętro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvPomieszczenia
            // 
            this.dgvPomieszczenia.AllowUserToAddRows = false;
            this.dgvPomieszczenia.AllowUserToDeleteRows = false;
            this.dgvPomieszczenia.AllowUserToOrderColumns = true;
            this.dgvPomieszczenia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPomieszczenia.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPomieszczenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPomieszczenia.Location = new System.Drawing.Point(12, 87);
            this.dgvPomieszczenia.Name = "dgvPomieszczenia";
            this.dgvPomieszczenia.ReadOnly = true;
            this.dgvPomieszczenia.Size = new System.Drawing.Size(423, 192);
            this.dgvPomieszczenia.TabIndex = 10;
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Location = new System.Drawing.Point(12, 285);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(210, 30);
            this.btnOdswiez.TabIndex = 11;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // Pomieszczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 327);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.dgvPomieszczenia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnWyjdz);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Pomieszczenia";
            this.Text = "Pomieszczenia";
            this.Load += new System.EventHandler(this.Pomieszczenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPomieszczenia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnWyjdz;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvPomieszczenia;
        private System.Windows.Forms.Button btnOdswiez;
    }
}