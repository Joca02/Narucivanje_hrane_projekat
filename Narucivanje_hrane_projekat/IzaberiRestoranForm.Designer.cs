namespace Narucivanje_hrane_projekat
{
    partial class IzaberiRestoranForm
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
            this.lbRestorani = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbRestorani
            // 
            this.lbRestorani.FormattingEnabled = true;
            this.lbRestorani.Location = new System.Drawing.Point(-2, -1);
            this.lbRestorani.Name = "lbRestorani";
            this.lbRestorani.Size = new System.Drawing.Size(532, 342);
            this.lbRestorani.TabIndex = 0;
            this.lbRestorani.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbRestorani_MouseDoubleClick);
            // 
            // IzaberiRestoranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 344);
            this.Controls.Add(this.lbRestorani);
            this.Name = "IzaberiRestoranForm";
            this.Text = "IzaberiRestoranForm";          
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRestorani;
    }
}