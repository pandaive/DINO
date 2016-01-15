namespace Obsługa_biurowca
{
    partial class Firmy_usun
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
            this.biurowiecDataSet1 = new Obsługa_biurowca.BiurowiecDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnAkceptuj = new System.Windows.Forms.Button();
            this.cBFirma = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.biurowiecDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // biurowiecDataSet1
            // 
            this.biurowiecDataSet1.DataSetName = "BiurowiecDataSet";
            this.biurowiecDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa firmy do usunięcia:";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(176, 49);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(145, 23);
            this.btnAnuluj.TabIndex = 3;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.Location = new System.Drawing.Point(27, 49);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(143, 23);
            this.btnAkceptuj.TabIndex = 2;
            this.btnAkceptuj.Text = "Akceptuj";
            this.btnAkceptuj.UseVisualStyleBackColor = true;
            this.btnAkceptuj.Click += new System.EventHandler(this.btnAkceptuj_Click);
            // 
            // cBFirma
            // 
            this.cBFirma.FormattingEnabled = true;
            this.cBFirma.Location = new System.Drawing.Point(149, 13);
            this.cBFirma.Name = "cBFirma";
            this.cBFirma.Size = new System.Drawing.Size(172, 21);
            this.cBFirma.TabIndex = 4;
            // 
            // Firmy_usun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 88);
            this.Controls.Add(this.cBFirma);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnAkceptuj);
            this.Controls.Add(this.label1);
            this.Name = "Firmy_usun";
            this.Text = "Usuń firmę";
            this.Load += new System.EventHandler(this.Firmy_usun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biurowiecDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BiurowiecDataSet biurowiecDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnAkceptuj;
        private System.Windows.Forms.ComboBox cBFirma;
    }
}