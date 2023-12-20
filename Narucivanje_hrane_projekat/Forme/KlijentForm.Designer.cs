namespace Narucivanje_hrane_projekat
{
    partial class KlijentForm
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
            this.dtMin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRezervacije = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtMax = new System.Windows.Forms.DateTimePicker();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtMin
            // 
            this.dtMin.Location = new System.Drawing.Point(45, 48);
            this.dtMin.Name = "dtMin";
            this.dtMin.Size = new System.Drawing.Size(216, 20);
            this.dtMin.TabIndex = 0;
            this.dtMin.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moje rezervacije";
            // 
            // lbRezervacije
            // 
            this.lbRezervacije.FormattingEnabled = true;
            this.lbRezervacije.Location = new System.Drawing.Point(12, 213);
            this.lbRezervacije.Name = "lbRezervacije";
            this.lbRezervacije.Size = new System.Drawing.Size(720, 225);
            this.lbRezervacije.TabIndex = 2;
            this.lbRezervacije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbRezervacije_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Najraniji datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Najkasniji datum";
            // 
            // dtMax
            // 
            this.dtMax.Location = new System.Drawing.Point(475, 48);
            this.dtMax.Name = "dtMax";
            this.dtMax.Size = new System.Drawing.Size(216, 20);
            this.dtMax.TabIndex = 5;
            this.dtMax.ValueChanged += new System.EventHandler(this.dtMax_ValueChanged);
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(45, 133);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(646, 23);
            this.btnDodajRezervaciju.TabIndex = 6;
            this.btnDodajRezervaciju.Text = "Dodaj rezervaciju";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = true;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // KlijentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.btnDodajRezervaciju);
            this.Controls.Add(this.dtMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRezervacije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtMin);
            this.Name = "KlijentForm";
            this.Text = "KlijentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRezervacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        public System.Windows.Forms.DateTimePicker dtMax;
    }
}