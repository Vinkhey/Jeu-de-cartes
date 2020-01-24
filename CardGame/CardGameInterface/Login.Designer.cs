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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
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
            this.LblEmailLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailLogin.ForeColor = System.Drawing.Color.White;
            this.LblEmailLogin.Location = new System.Drawing.Point(15, 147);
            this.LblEmailLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblEmailLogin.Name = "LblEmailLogin";
            this.LblEmailLogin.Size = new System.Drawing.Size(160, 24);
            this.LblEmailLogin.TabIndex = 2;
            this.LblEmailLogin.Text = "Entrez votre email";
            // 
            // LblPswLogin
            // 
            this.LblPswLogin.AutoSize = true;
            this.LblPswLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblPswLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPswLogin.ForeColor = System.Drawing.Color.White;
            this.LblPswLogin.Location = new System.Drawing.Point(15, 224);
            this.LblPswLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblPswLogin.Name = "LblPswLogin";
            this.LblPswLogin.Size = new System.Drawing.Size(123, 24);
            this.LblPswLogin.TabIndex = 3;
            this.LblPswLogin.Text = "Mot de passe";
            // 
            // LblSignUp
            // 
            this.LblSignUp.AutoSize = true;
            this.LblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.LblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSignUp.ForeColor = System.Drawing.Color.White;
            this.LblSignUp.Location = new System.Drawing.Point(218, 9);
            this.LblSignUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblSignUp.Name = "LblSignUp";
            this.LblSignUp.Size = new System.Drawing.Size(190, 73);
            this.LblSignUp.TabIndex = 5;
            this.LblSignUp.Text = "Login";
            // 
            // TxtBoxEmailLogin
            // 
            this.TxtBoxEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxEmailLogin.Location = new System.Drawing.Point(200, 143);
            this.TxtBoxEmailLogin.Name = "TxtBoxEmailLogin";
            this.TxtBoxEmailLogin.Size = new System.Drawing.Size(244, 31);
            this.TxtBoxEmailLogin.TabIndex = 6;
            // 
            // TxtBoxPswLogin
            // 
            this.TxtBoxPswLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPswLogin.Location = new System.Drawing.Point(200, 220);
            this.TxtBoxPswLogin.Name = "TxtBoxPswLogin";
            this.TxtBoxPswLogin.PasswordChar = '*';
            this.TxtBoxPswLogin.Size = new System.Drawing.Size(244, 31);
            this.TxtBoxPswLogin.TabIndex = 7;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.White;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(200, 284);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(244, 46);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "Connexion";
            this.BtnLogin.UseVisualStyleBackColor = false;
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
            this.BtnLoginToSignUp.BackColor = System.Drawing.Color.White;
            this.BtnLoginToSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginToSignUp.Location = new System.Drawing.Point(450, 355);
            this.BtnLoginToSignUp.Name = "BtnLoginToSignUp";
            this.BtnLoginToSignUp.Size = new System.Drawing.Size(128, 40);
            this.BtnLoginToSignUp.TabIndex = 12;
            this.BtnLoginToSignUp.Text = "S\'inscrire";
            this.BtnLoginToSignUp.UseVisualStyleBackColor = false;
            this.BtnLoginToSignUp.Click += new System.EventHandler(this.BtnLoginToSignUp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(591, 426);
            this.Controls.Add(this.BtnLoginToSignUp);
            this.Controls.Add(this.LblMailErrorLogin);
            this.Controls.Add(this.LblPswErrorLogin);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtBoxPswLogin);
            this.Controls.Add(this.TxtBoxEmailLogin);
            this.Controls.Add(this.LblSignUp);
            this.Controls.Add(this.LblPswLogin);
            this.Controls.Add(this.LblEmailLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_Closing);
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