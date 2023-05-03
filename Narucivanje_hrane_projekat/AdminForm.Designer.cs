namespace Narucivanje_hrane_projekat
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.cmsKorisnici = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.izbrisiKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlListe = new System.Windows.Forms.Panel();
            this.chbKorisnici = new System.Windows.Forms.CheckBox();
            this.chbRezervacije = new System.Windows.Forms.CheckBox();
            this.chbRestorani = new System.Windows.Forms.CheckBox();
            this.chbJela = new System.Windows.Forms.CheckBox();
            this.chbPrilozi = new System.Windows.Forms.CheckBox();
            this.chbDodaci = new System.Windows.Forms.CheckBox();
            this.cmsRezervacije = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRezervacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRestorani = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRestoranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsJela = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajJeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDodaci = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajDodatakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPrilozi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPrilogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsKorisnici.SuspendLayout();
            this.cmsRezervacije.SuspendLayout();
            this.cmsRestorani.SuspendLayout();
            this.cmsJela.SuspendLayout();
            this.cmsDodaci.SuspendLayout();
            this.cmsPrilozi.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsKorisnici
            // 
            this.cmsKorisnici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbrisiKorisnikaToolStripMenuItem,
            this.izmeniKorisnikaToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem});
            this.cmsKorisnici.Name = "cmsKorisnik";
            this.cmsKorisnici.Size = new System.Drawing.Size(164, 70);
            // 
            // izbrisiKorisnikaToolStripMenuItem
            // 
            this.izbrisiKorisnikaToolStripMenuItem.Name = "izbrisiKorisnikaToolStripMenuItem";
            this.izbrisiKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.izbrisiKorisnikaToolStripMenuItem.Text = "Izbrisi  Korisnika";
            this.izbrisiKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.izbrisiKorisnikaToolStripMenuItem_Click_1);
            // 
            // izmeniKorisnikaToolStripMenuItem
            // 
            this.izmeniKorisnikaToolStripMenuItem.Name = "izmeniKorisnikaToolStripMenuItem";
            this.izmeniKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.izmeniKorisnikaToolStripMenuItem.Text = "Izmeni  Korisnika";
            this.izmeniKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.izmeniKorisnikaToolStripMenuItem_Click_1);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj Korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // pnlListe
            // 
            this.pnlListe.Location = new System.Drawing.Point(12, 12);
            this.pnlListe.Name = "pnlListe";
            this.pnlListe.Size = new System.Drawing.Size(869, 549);
            this.pnlListe.TabIndex = 1;
            // 
            // chbKorisnici
            // 
            this.chbKorisnici.AutoSize = true;
            this.chbKorisnici.Location = new System.Drawing.Point(904, 94);
            this.chbKorisnici.Name = "chbKorisnici";
            this.chbKorisnici.Size = new System.Drawing.Size(65, 17);
            this.chbKorisnici.TabIndex = 2;
            this.chbKorisnici.Text = "Korisnici";
            this.chbKorisnici.UseVisualStyleBackColor = true;
            this.chbKorisnici.CheckedChanged += new System.EventHandler(this.chbKorisnici_CheckedChanged);
            // 
            // chbRezervacije
            // 
            this.chbRezervacije.AutoSize = true;
            this.chbRezervacije.Location = new System.Drawing.Point(904, 149);
            this.chbRezervacije.Name = "chbRezervacije";
            this.chbRezervacije.Size = new System.Drawing.Size(82, 17);
            this.chbRezervacije.TabIndex = 3;
            this.chbRezervacije.Text = "Rezervacije";
            this.chbRezervacije.UseVisualStyleBackColor = true;
            this.chbRezervacije.CheckedChanged += new System.EventHandler(this.chbRezervacije_CheckedChanged);
            // 
            // chbRestorani
            // 
            this.chbRestorani.AutoSize = true;
            this.chbRestorani.Location = new System.Drawing.Point(904, 211);
            this.chbRestorani.Name = "chbRestorani";
            this.chbRestorani.Size = new System.Drawing.Size(71, 17);
            this.chbRestorani.TabIndex = 4;
            this.chbRestorani.Text = "Restorani";
            this.chbRestorani.UseVisualStyleBackColor = true;
            this.chbRestorani.CheckedChanged += new System.EventHandler(this.chbRestorani_CheckedChanged);
            // 
            // chbJela
            // 
            this.chbJela.AutoSize = true;
            this.chbJela.Location = new System.Drawing.Point(904, 270);
            this.chbJela.Name = "chbJela";
            this.chbJela.Size = new System.Drawing.Size(45, 17);
            this.chbJela.TabIndex = 5;
            this.chbJela.Text = "Jela";
            this.chbJela.UseVisualStyleBackColor = true;
            this.chbJela.CheckedChanged += new System.EventHandler(this.chbJela_CheckedChanged);
            // 
            // chbPrilozi
            // 
            this.chbPrilozi.AutoSize = true;
            this.chbPrilozi.Location = new System.Drawing.Point(904, 339);
            this.chbPrilozi.Name = "chbPrilozi";
            this.chbPrilozi.Size = new System.Drawing.Size(53, 17);
            this.chbPrilozi.TabIndex = 6;
            this.chbPrilozi.Text = "Prilozi";
            this.chbPrilozi.UseVisualStyleBackColor = true;
            this.chbPrilozi.CheckedChanged += new System.EventHandler(this.chbPrilozi_CheckedChanged);
            // 
            // chbDodaci
            // 
            this.chbDodaci.AutoSize = true;
            this.chbDodaci.Location = new System.Drawing.Point(904, 403);
            this.chbDodaci.Name = "chbDodaci";
            this.chbDodaci.Size = new System.Drawing.Size(60, 17);
            this.chbDodaci.TabIndex = 7;
            this.chbDodaci.Text = "Dodaci";
            this.chbDodaci.UseVisualStyleBackColor = true;
            this.chbDodaci.CheckedChanged += new System.EventHandler(this.chbDodaci_CheckedChanged);
            // 
            // cmsRezervacije
            // 
            this.cmsRezervacije.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.dodajRezervacijuToolStripMenuItem});
            this.cmsRezervacije.Name = "cmsKorisnik";
            this.cmsRezervacije.Size = new System.Drawing.Size(172, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem1.Text = "Izbrisi Rezervaciju";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem2.Text = "Izmeni Rezervaciju";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // dodajRezervacijuToolStripMenuItem
            // 
            this.dodajRezervacijuToolStripMenuItem.Name = "dodajRezervacijuToolStripMenuItem";
            this.dodajRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.dodajRezervacijuToolStripMenuItem.Text = "Dodaj Rezervaciju";
            this.dodajRezervacijuToolStripMenuItem.Click += new System.EventHandler(this.dodajRezervacijuToolStripMenuItem_Click);
            // 
            // cmsRestorani
            // 
            this.cmsRestorani.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.dodajRestoranToolStripMenuItem});
            this.cmsRestorani.Name = "cmsKorisnik";
            this.cmsRestorani.Size = new System.Drawing.Size(159, 70);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItem3.Text = "Izbrisi Restoran ";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItem4.Text = "Izmeni Restoran";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // dodajRestoranToolStripMenuItem
            // 
            this.dodajRestoranToolStripMenuItem.Name = "dodajRestoranToolStripMenuItem";
            this.dodajRestoranToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dodajRestoranToolStripMenuItem.Text = "Dodaj Restoran";
            this.dodajRestoranToolStripMenuItem.Click += new System.EventHandler(this.dodajRestoranToolStripMenuItem_Click);
            // 
            // cmsJela
            // 
            this.cmsJela.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.dodajJeloToolStripMenuItem});
            this.cmsJela.Name = "cmsKorisnik";
            this.cmsJela.Size = new System.Drawing.Size(181, 92);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "Izbrisi Jelo";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "Izmeni Jelo";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // dodajJeloToolStripMenuItem
            // 
            this.dodajJeloToolStripMenuItem.Name = "dodajJeloToolStripMenuItem";
            this.dodajJeloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajJeloToolStripMenuItem.Text = "Dodaj Jelo";
            this.dodajJeloToolStripMenuItem.Click += new System.EventHandler(this.dodajJeloToolStripMenuItem_Click);
            // 
            // cmsDodaci
            // 
            this.cmsDodaci.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.dodajDodatakToolStripMenuItem});
            this.cmsDodaci.Name = "cmsKorisnik";
            this.cmsDodaci.Size = new System.Drawing.Size(157, 70);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "Izbrisi Dodatak";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem8.Text = "Izmeni Dodatak";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // dodajDodatakToolStripMenuItem
            // 
            this.dodajDodatakToolStripMenuItem.Name = "dodajDodatakToolStripMenuItem";
            this.dodajDodatakToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajDodatakToolStripMenuItem.Text = "Dodaj Dodatak";
            this.dodajDodatakToolStripMenuItem.Click += new System.EventHandler(this.dodajDodatakToolStripMenuItem_Click);
            // 
            // cmsPrilozi
            // 
            this.cmsPrilozi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.dodajPrilogToolStripMenuItem});
            this.cmsPrilozi.Name = "cmsKorisnik";
            this.cmsPrilozi.Size = new System.Drawing.Size(144, 70);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem9.Text = "Izbrisi Prilog";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem10.Text = "Izmeni Prilog";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // dodajPrilogToolStripMenuItem
            // 
            this.dodajPrilogToolStripMenuItem.Name = "dodajPrilogToolStripMenuItem";
            this.dodajPrilogToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.dodajPrilogToolStripMenuItem.Text = "Dodaj Prilog";
            this.dodajPrilogToolStripMenuItem.Click += new System.EventHandler(this.dodajPrilogToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 573);
            this.Controls.Add(this.chbDodaci);
            this.Controls.Add(this.chbPrilozi);
            this.Controls.Add(this.chbJela);
            this.Controls.Add(this.chbRestorani);
            this.Controls.Add(this.chbRezervacije);
            this.Controls.Add(this.chbKorisnici);
            this.Controls.Add(this.pnlListe);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.cmsKorisnici.ResumeLayout(false);
            this.cmsRezervacije.ResumeLayout(false);
            this.cmsRestorani.ResumeLayout(false);
            this.cmsJela.ResumeLayout(false);
            this.cmsDodaci.ResumeLayout(false);
            this.cmsPrilozi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsKorisnici;
        private System.Windows.Forms.ToolStripMenuItem izbrisiKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniKorisnikaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlListe;
        private System.Windows.Forms.CheckBox chbKorisnici;
        private System.Windows.Forms.CheckBox chbRezervacije;
        private System.Windows.Forms.CheckBox chbRestorani;
        private System.Windows.Forms.CheckBox chbJela;
        private System.Windows.Forms.CheckBox chbPrilozi;
        private System.Windows.Forms.CheckBox chbDodaci;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsRezervacije;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dodajRezervacijuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsRestorani;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem dodajRestoranToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsJela;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem dodajJeloToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDodaci;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem dodajDodatakToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsPrilozi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem dodajPrilogToolStripMenuItem;
    }
}