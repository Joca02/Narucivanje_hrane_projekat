namespace Narucivanje_hrane_projekat
{
    partial class RestoranForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv Resorana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kontakt telefon";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(143, 31);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(251, 20);
            this.txtNaziv.TabIndex = 3;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(143, 87);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(251, 20);
            this.txtAdresa.TabIndex = 4;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(143, 143);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(251, 20);
            this.txtKontakt.TabIndex = 5;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(15, 209);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(379, 29);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "Sacuvaj Restoran";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // RestoranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 267);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RestoranForm";
            this.Text = "RestoranForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}