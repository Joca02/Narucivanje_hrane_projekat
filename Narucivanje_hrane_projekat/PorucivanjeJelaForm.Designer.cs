namespace Narucivanje_hrane_projekat
{
    partial class PorucivanjeJelaForm
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
            this.clbDodaci = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clbPrilog = new System.Windows.Forms.CheckedListBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbDodaci
            // 
            this.clbDodaci.FormattingEnabled = true;
            this.clbDodaci.Location = new System.Drawing.Point(442, 72);
            this.clbDodaci.Name = "clbDodaci";
            this.clbDodaci.Size = new System.Drawing.Size(346, 304);
            this.clbDodaci.TabIndex = 1;
            this.clbDodaci.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbDodaci_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izaberite prilog uz jelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izaberite do 3 dodatka";
            // 
            // clbPrilog
            // 
            this.clbPrilog.FormattingEnabled = true;
            this.clbPrilog.Location = new System.Drawing.Point(12, 72);
            this.clbPrilog.Name = "clbPrilog";
            this.clbPrilog.Size = new System.Drawing.Size(346, 304);
            this.clbPrilog.TabIndex = 4;
            this.clbPrilog.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbPrilog_ItemCheck);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(88, 405);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(636, 45);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sacuvaj jelo";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // PorucivanjeJelaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.clbPrilog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbDodaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PorucivanjeJelaForm";
            this.Text = "PorucivanjeJelaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PorucivanjeJelaForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox clbDodaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbPrilog;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}