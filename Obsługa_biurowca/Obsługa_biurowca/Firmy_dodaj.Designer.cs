namespace Obsługa_biurowca
{
    partial class Firmy_dodaj
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBNazwa = new System.Windows.Forms.TextBox();
            this.btnAkceptuj = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cBPietro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa firmy:";
            // 
            // tBNazwa
            // 
            this.tBNazwa.Location = new System.Drawing.Point(102, 27);
            this.tBNazwa.Name = "tBNazwa";
            this.tBNazwa.Size = new System.Drawing.Size(190, 20);
            this.tBNazwa.TabIndex = 1;
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.Location = new System.Drawing.Point(12, 91);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(143, 23);
            this.btnAkceptuj.TabIndex = 3;
            this.btnAkceptuj.Text = "Akceptuj";
            this.btnAkceptuj.UseVisualStyleBackColor = true;
            this.btnAkceptuj.Click += new System.EventHandler(this.btnAkceptuj_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(161, 91);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(145, 23);
            this.btnAnuluj.TabIndex = 4;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Piętro:";
            // 
            // cBPietro
            // 
            this.cBPietro.FormattingEnabled = true;
            this.cBPietro.Location = new System.Drawing.Point(102, 56);
            this.cBPietro.Name = "cBPietro";
            this.cBPietro.Size = new System.Drawing.Size(53, 21);
            this.cBPietro.TabIndex = 2;
            // 
            // Firmy_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 126);
            this.Controls.Add(this.cBPietro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnAkceptuj);
            this.Controls.Add(this.tBNazwa);
            this.Controls.Add(this.label1);
            this.Name = "Firmy_dodaj";
            this.Text = "Dodaj firmę";
            this.Load += new System.EventHandler(this.Firmy_dodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNazwa;
        private System.Windows.Forms.Button btnAkceptuj;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBPietro;
    }
}