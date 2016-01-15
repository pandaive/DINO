namespace Obsługa_biurowca
{
    partial class Personel_usun
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnAkceptuj = new System.Windows.Forms.Button();
            this.cBNazwisko = new System.Windows.Forms.ComboBox();
            this.cBImie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko:";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(171, 92);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(145, 23);
            this.btnAnuluj.TabIndex = 7;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.Location = new System.Drawing.Point(22, 92);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(143, 23);
            this.btnAkceptuj.TabIndex = 6;
            this.btnAkceptuj.Text = "Akceptuj";
            this.btnAkceptuj.UseVisualStyleBackColor = true;
            this.btnAkceptuj.Click += new System.EventHandler(this.btnAkceptuj_Click);
            // 
            // cBNazwisko
            // 
            this.cBNazwisko.FormattingEnabled = true;
            this.cBNazwisko.Location = new System.Drawing.Point(105, 22);
            this.cBNazwisko.Name = "cBNazwisko";
            this.cBNazwisko.Size = new System.Drawing.Size(180, 21);
            this.cBNazwisko.TabIndex = 1;
            this.cBNazwisko.SelectedIndexChanged += new System.EventHandler(this.cBNazwisko_SelectedIndexChanged);
            // 
            // cBImie
            // 
            this.cBImie.FormattingEnabled = true;
            this.cBImie.Location = new System.Drawing.Point(105, 47);
            this.cBImie.Name = "cBImie";
            this.cBImie.Size = new System.Drawing.Size(180, 21);
            this.cBImie.TabIndex = 2;
            // 
            // Personel_usun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 135);
            this.Controls.Add(this.cBImie);
            this.Controls.Add(this.cBNazwisko);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnAkceptuj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Personel_usun";
            this.Text = "Usuń pracownika";
            this.Load += new System.EventHandler(this.Personel_usun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnAkceptuj;
        private System.Windows.Forms.ComboBox cBNazwisko;
        private System.Windows.Forms.ComboBox cBImie;
    }
}