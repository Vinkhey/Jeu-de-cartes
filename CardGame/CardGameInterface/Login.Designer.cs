namespace CardGameInterface
{
    partial class Login
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
            this.LblEmailLogin = new System.Windows.Forms.Label();
            this.LblPswLogin = new System.Windows.Forms.Label();
            this.LblSignUp = new System.Windows.Forms.Label();
            this.TxtBoxEmailLogin = new System.Windows.Forms.TextBox();
            this.TxtBoxPswLogin = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblPswErrorLogin = new System.Windows.Forms.Label();
            this.LblMailErrorLogin = new System.Windows.Forms.Label();
            this.BtnLoginToSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEmailLogin
            // 
            this.LblEmailLogin.AutoSize = true;
            this.LblEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailLogin.Location = new System.Drawing.Point(139, 208);
            this.LblEmailLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblEmailLogin.Name = "LblEmailLogin";
            this.LblEmailLogin.Size = new System.Drawing.Size(185, 25);
            this.LblEmailLogin.TabIndex = 2;
            this.LblEmailLogin.Text = "Entrez votre email";
            // 
            // LblPswLogin
            // 
            this.LblPswLogin.AutoSize = true;
            this.LblPswLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPswLogin.Location = new System.Drawing.Point(182, 286);
            this.LblPswLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblPswLogin.Name = "LblPswLogin";
            this.LblPswLogin.Size = new System.Drawing.Size(142, 25);
            this.LblPswLogin.TabIndex = 3;
            this.LblPswLogin.Text = "Mot de passe";
            // 
            // LblSignUp
            // 
            this.LblSignUp.AutoSize = true;
            this.LblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSignUp.Location = new System.Drawing.Point(396, 43);
            this.LblSignUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblSignUp.Name = "LblSignUp";
            this.LblSignUp.Size = new System.Drawing.Size(190, 73);
            this.LblSignUp.TabIndex = 5;
            this.LblSignUp.Text = "Login";
            // 
            // TxtBoxEmailLogin
            // 
            this.TxtBoxEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxEmailLogin.Location = new System.Drawing.Point(381, 214);
            this.TxtBoxEmailLogin.Name = "TxtBoxEmailLogin";
            this.TxtBoxEmailLogin.Size = new System.Drawing.Size(244, 31);
            this.TxtBoxEmailLogin.TabIndex = 6;
            // 
            // TxtBoxPswLogin
            // 
            this.TxtBoxPswLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPswLogin.Location = new System.Drawing.Point(381, 291);
            this.TxtBoxPswLogin.Name = "TxtBoxPswLogin";
            this.TxtBoxPswLogin.PasswordChar = '*';
            this.TxtBoxPswLogin.Size = new System.Drawing.Size(244, 31);
            this.TxtBoxPswLogin.TabIndex = 7;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(381, 418);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(222, 81);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "Connexion";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblPswErrorLogin
            // 
            this.LblPswErrorLogin.AutoSize = true;
            this.LblPswErrorLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPswErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.LblPswErrorLogin.Location = new System.Drawing.Point(647, 298);
            this.LblPswErrorLogin.Name = "LblPswErrorLogin";
            this.LblPswErrorLogin.Size = new System.Drawing.Size(0, 20);
            this.LblPswErrorLogin.TabIndex = 10;
            // 
            // LblMailErrorLogin
            // 
            this.LblMailErrorLogin.AutoSize = true;
            this.LblMailErrorLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMailErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.LblMailErrorLogin.Location = new System.Drawing.Point(647, 221);
            this.LblMailErrorLogin.Name = "LblMailErrorLogin";
            this.LblMailErrorLogin.Size = new System.Drawing.Size(0, 20);
            this.LblMailErrorLogin.TabIndex = 11;
            // 
            // BtnLoginToSignUp
            // 
            this.BtnLoginToSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginToSignUp.Location = new System.Drawing.Point(797, 515);
            this.BtnLoginToSignUp.Name = "BtnLoginToSignUp";
            this.BtnLoginToSignUp.Size = new System.Drawing.Size(191, 69);
            this.BtnLoginToSignUp.TabIndex = 12;
            this.BtnLoginToSignUp.Text = "S\'inscrire";
            this.BtnLoginToSignUp.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 621);
            this.Controls.Add(this.BtnLoginToSignUp);
            this.Controls.Add(this.LblMailErrorLogin);
            this.Controls.Add(this.LblPswErrorLogin);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtBoxPswLogin);
            this.Controls.Add(this.TxtBoxEmailLogin);
            this.Controls.Add(this.LblSignUp);
            this.Controls.Add(this.LblPswLogin);
            this.Controls.Add(this.LblEmailLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmailLogin;
        private System.Windows.Forms.Label LblPswLogin;
        private System.Windows.Forms.Label LblSignUp;
        private System.Windows.Forms.TextBox TxtBoxEmailLogin;
        private System.Windows.Forms.TextBox TxtBoxPswLogin;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblPswErrorLogin;
        private System.Windows.Forms.Label LblMailErrorLogin;
        private System.Windows.Forms.Button BtnLoginToSignUp;
    }
}