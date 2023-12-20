namespace Narucivanje_hrane_projekat
{
    partial class JeloForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtGramaza = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.chbPrilog = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRestoran = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Gramaza";
            // 
            // txtGramaza
            // 
            this.txtGramaza.Location = new System.Drawing.Point(149, 102);
            this.txtGramaza.Name = "txtGramaza";
            this.txtGramaza.Size = new System.Drawing.Size(196, 20);
            this.txtGramaza.TabIndex = 17;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(38, 317);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(307, 23);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "Sacuvaj jelo";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Naziv Jela";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(149, 65);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(196, 20);
            this.txtCena.TabIndex = 13;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(149, 27);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(196, 20);
            this.txtNaziv.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Opis jela (opcionalno)";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(149, 195);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(196, 62);
            this.txtOpis.TabIndex = 19;
            // 
            // chbPrilog
            // 
            this.chbPrilog.AutoSize = true;
            this.chbPrilog.Location = new System.Drawing.Point(149, 275);
            this.chbPrilog.Name = "chbPrilog";
            this.chbPrilog.Size = new System.Drawing.Size(103, 17);
            this.chbPrilog.TabIndex = 21;
            this.chbPrilog.Text = "Obavezan prilog";
            this.chbPrilog.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "ID Restorana";
            // 
            // txtRestoran
            // 
            this.txtRestoran.Location = new System.Drawing.Point(149, 147);
            this.txtRestoran.Name = "txtRestoran";
            this.txtRestoran.ReadOnly = true;
            this.txtRestoran.Size = new System.Drawing.Size(196, 20);
            this.txtRestoran.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 22);
            this.button1.TabIndex = 24;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JeloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRestoran);
            this.Controls.Add(this.chbPrilog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGramaza);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtNaziv);
            this.Name = "JeloForm";
            this.Text = "JeloForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGramaza;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.CheckBox chbPrilog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRestoran;
        private System.Windows.Forms.Button button1;
    }
}