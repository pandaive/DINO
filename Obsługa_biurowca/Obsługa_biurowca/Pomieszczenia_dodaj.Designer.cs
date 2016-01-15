namespace Obsługa_biurowca
{
    partial class Pomieszczenia_dodaj
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
            this.tBNr = new System.Windows.Forms.TextBox();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnAkceptuj = new System.Windows.Forms.Button();
            this.cBPietro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numer pokoju:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Piętro:";
            // 
            // tBNr
            // 
            this.tBNr.Location = new System.Drawing.Point(110, 22);
            this.tBNr.Name = "tBNr";
            this.tBNr.Size = new System.Drawing.Size(58, 20);
            this.tBNr.TabIndex = 1;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(174, 68);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(145, 23);
            this.btnAnuluj.TabIndex = 4;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.Location = new System.Drawing.Point(25, 68);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(143, 23);
            this.btnAkceptuj.TabIndex = 3;
            this.btnAkceptuj.Text = "Akceptuj";
            this.btnAkceptuj.UseVisualStyleBackColor = true;
            this.btnAkceptuj.Click += new System.EventHandler(this.btnAkceptuj_Click);
            // 
            // cBPietro
            // 
            this.cBPietro.FormattingEnabled = true;
            this.cBPietro.Location = new System.Drawing.Point(230, 22);
            this.cBPietro.Name = "cBPietro";
            this.cBPietro.Size = new System.Drawing.Size(62, 21);
            this.cBPietro.TabIndex = 2;
            // 
            // Pomieszczenia_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 103);
            this.Controls.Add(this.cBPietro);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnAkceptuj);
            this.Controls.Add(this.tBNr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pomieszczenia_dodaj";
            this.Text = "Dodaj pomieszczenie";
            this.Load += new System.EventHandler(this.Pomieszczenia_dodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBNr;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnAkceptuj;
        private System.Windows.Forms.ComboBox cBPietro;
    }
}