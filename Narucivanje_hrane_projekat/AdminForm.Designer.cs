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
            this.lbKorisnici = new System.Windows.Forms.ListBox();
            this.cmsKorisnik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.izbrisiKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLista = new System.Windows.Forms.Label();
            this.cmsKorisnik.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKorisnici
            // 
            this.lbKorisnici.ContextMenuStrip = this.cmsKorisnik;
            this.lbKorisnici.FormattingEnabled = true;
            this.lbKorisnici.Location = new System.Drawing.Point(28, 126);
            this.lbKorisnici.Name = "lbKorisnici";
            this.lbKorisnici.Size = new System.Drawing.Size(785, 316);
            this.lbKorisnici.TabIndex = 0;
            this.lbKorisnici.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // cmsKorisnik
            // 
            this.cmsKorisnik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbrisiKorisnikaToolStripMenuItem,
            this.izmeniKorisnikaToolStripMenuItem});
            this.cmsKorisnik.Name = "cmsKorisnik";
            this.cmsKorisnik.Size = new System.Drawing.Size(160, 48);
            // 
            // izbrisiKorisnikaToolStripMenuItem
            // 
            this.izbrisiKorisnikaToolStripMenuItem.Name = "izbrisiKorisnikaToolStripMenuItem";
            this.izbrisiKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.izbrisiKorisnikaToolStripMenuItem.Text = "Izbrisi Korisnika";
            this.izbrisiKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.izbrisiKorisnikaToolStripMenuItem_Click);
            // 
            // izmeniKorisnikaToolStripMenuItem
            // 
            this.izmeniKorisnikaToolStripMenuItem.Name = "izmeniKorisnikaToolStripMenuItem";
            this.izmeniKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.izmeniKorisnikaToolStripMenuItem.Text = "Izmeni korisnika";
            this.izmeniKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.izmeniKorisnikaToolStripMenuItem_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(370, 110);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(74, 13);
            this.lblLista.TabIndex = 1;
            this.lblLista.Text = "Lista za prikaz";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 454);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lbKorisnici);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.cmsKorisnik.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKorisnici;
        private System.Windows.Forms.ContextMenuStrip cmsKorisnik;
        private System.Windows.Forms.ToolStripMenuItem izbrisiKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniKorisnikaToolStripMenuItem;
        private System.Windows.Forms.Label lblLista;
    }
}