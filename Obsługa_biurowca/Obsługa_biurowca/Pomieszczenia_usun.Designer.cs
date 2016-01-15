namespace Obsługa_biurowca
{
    partial class Pomieszczenia_usun
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
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnAkceptuj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBPietro = new System.Windows.Forms.ComboBox();
            this.cBPokoj = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(174, 66);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(145, 23);
            this.btnAnuluj.TabIndex = 15;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.Location = new System.Drawing.Point(25, 66);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(143, 23);
            this.btnAkceptuj.TabIndex = 14;
            this.btnAkceptuj.Text = "Akceptuj";
            this.btnAkceptuj.UseVisualStyleBackColor = true;
            this.btnAkceptuj.Click += new System.EventHandler(this.btnAkceptuj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Piętro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numer pokoju:";
            // 
            // cBPietro
            // 
            this.cBPietro.FormattingEnabled = true;
            this.cBPietro.Location = new System.Drawing.Point(80, 20);
            this.cBPietro.Name = "cBPietro";
            this.cBPietro.Size = new System.Drawing.Size(62, 21);
            this.cBPietro.TabIndex = 1;
            this.cBPietro.SelectedIndexChanged += new System.EventHandler(this.cBPietro_SelectedIndexChanged);
            // 
            // cBPokoj
            // 
            this.cBPokoj.FormattingEnabled = true;
            this.cBPokoj.Location = new System.Drawing.Point(230, 20);
            this.cBPokoj.Name = "cBPokoj";
            this.cBPokoj.Size = new System.Drawing.Size(62, 21);
            this.cBPokoj.TabIndex = 2;
            // 
            // Pomieszczenia_usun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 104);
            this.Controls.Add(this.cBPokoj);
            this.Controls.Add(this.cBPietro);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnAkceptuj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pomieszczenia_usun";
            this.Text = "Usuń pomieszczenie";
            this.Load += new System.EventHandler(this.Pomieszczenia_usun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnAkceptuj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBPietro;
        private System.Windows.Forms.ComboBox cBPokoj;
    }
}