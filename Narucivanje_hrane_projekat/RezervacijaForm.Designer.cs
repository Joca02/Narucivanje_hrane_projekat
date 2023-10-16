namespace Narucivanje_hrane_projekat
{
    partial class RezervacijaForm
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
            this.txtRestoran = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzaberiRestoran = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.lbRezJela = new System.Windows.Forms.ListBox();
            this.lbJela = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRestoran
            // 
            this.txtRestoran.Location = new System.Drawing.Point(379, 33);
            this.txtRestoran.Name = "txtRestoran";
            this.txtRestoran.ReadOnly = true;
            this.txtRestoran.Size = new System.Drawing.Size(175, 20);
            this.txtRestoran.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izaberite restoran u kojem cete jesti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dostupna jela ";
            // 
            // btnIzaberiRestoran
            // 
            this.btnIzaberiRestoran.Location = new System.Drawing.Point(560, 32);
            this.btnIzaberiRestoran.Name = "btnIzaberiRestoran";
            this.btnIzaberiRestoran.Size = new System.Drawing.Size(25, 23);
            this.btnIzaberiRestoran.TabIndex = 6;
            this.btnIzaberiRestoran.Text = "...";
            this.btnIzaberiRestoran.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIzaberiRestoran.UseVisualStyleBackColor = true;
            this.btnIzaberiRestoran.Click += new System.EventHandler(this.btnIzaberiRestoran_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.lbRezJela);
            this.pnl.Controls.Add(this.lbJela);
            this.pnl.Location = new System.Drawing.Point(30, 105);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(770, 299);
            this.pnl.TabIndex = 7;
            // 
            // lbRezJela
            // 
            this.lbRezJela.FormattingEnabled = true;
            this.lbRezJela.Location = new System.Drawing.Point(410, 0);
            this.lbRezJela.Name = "lbRezJela";
            this.lbRezJela.Size = new System.Drawing.Size(357, 290);
            this.lbRezJela.TabIndex = 7;
            // 
            // lbJela
            // 
            this.lbJela.FormattingEnabled = true;
            this.lbJela.Location = new System.Drawing.Point(3, 3);
            this.lbJela.Name = "lbJela";
            this.lbJela.Size = new System.Drawing.Size(370, 290);
            this.lbJela.TabIndex = 6;
            this.lbJela.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbJela_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Jela dodata u rezervaciju";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(296, 436);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(216, 30);
            this.btnSacuvaj.TabIndex = 9;
            this.btnSacuvaj.Text = "Sacuvaj rezervaciju";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ukupna cena";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(647, 483);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(13, 20);
            this.lblCena.TabIndex = 11;
            this.lblCena.Text = ".";
            // 
            // RezervacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 516);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIzaberiRestoran);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRestoran);
            this.Name = "RezervacijaForm";
            this.Text = "RezervacijaForm";
            this.pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRestoran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzaberiRestoran;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ListBox lbJela;
        private System.Windows.Forms.ListBox lbRezJela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCena;
    }
}