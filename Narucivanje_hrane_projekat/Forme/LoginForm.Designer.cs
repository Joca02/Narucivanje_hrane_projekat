namespace Narucivanje_hrane_projekat
{
    partial class LoginForm
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
            this.btnKreirajNalog = new System.Windows.Forms.Button();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKreirajNalog
            // 
            this.btnKreirajNalog.Location = new System.Drawing.Point(82, 327);
            this.btnKreirajNalog.Name = "btnKreirajNalog";
            this.btnKreirajNalog.Size = new System.Drawing.Size(124, 21);
            this.btnKreirajNalog.TabIndex = 0;
            this.btnKreirajNalog.Text = "Kreiraj nalog";
            this.btnKreirajNalog.UseVisualStyleBackColor = true;
            this.btnKreirajNalog.Click += new System.EventHandler(this.btnKreirajNalog_Click);
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(133, 77);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(129, 20);
            this.txtPasswd.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(133, 37);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(129, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nemate nalog?";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(43, 119);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(219, 28);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Korisnicko ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lozinka";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnKreirajNalog);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKreirajNalog;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

