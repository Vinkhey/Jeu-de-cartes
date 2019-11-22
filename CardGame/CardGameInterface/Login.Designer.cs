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
            this.LblPswVerifLogin = new System.Windows.Forms.Label();
            this.LblSignUp = new System.Windows.Forms.Label();
            this.TxtBoxEmailLogin = new System.Windows.Forms.TextBox();
            this.TxtBoxPswLogin = new System.Windows.Forms.TextBox();
            this.TxtBoxPswVerifLogin = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
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
            // LblPswVerifLogin
            // 
            this.LblPswVerifLogin.AutoSize = true;
            this.LblPswVerifLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPswVerifLogin.Location = new System.Drawing.Point(58, 368);
            this.LblPswVerifLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblPswVerifLogin.Name = "LblPswVerifLogin";
            this.LblPswVerifLogin.Size = new System.Drawing.Size(266, 25);
            this.LblPswVerifLogin.TabIndex = 4;
            this.LblPswVerifLogin.Text = "Mot de passe (vérification)";
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
            this.TxtBoxEmailLogin.Location = new System.Drawing.Point(381, 214);
            this.TxtBoxEmailLogin.Name = "TxtBoxEmailLogin";
            this.TxtBoxEmailLogin.Size = new System.Drawing.Size(244, 20);
            this.TxtBoxEmailLogin.TabIndex = 6;
            // 
            // TxtBoxPswLogin
            // 
            this.TxtBoxPswLogin.Location = new System.Drawing.Point(381, 291);
            this.TxtBoxPswLogin.Name = "TxtBoxPswLogin";
            this.TxtBoxPswLogin.Size = new System.Drawing.Size(244, 20);
            this.TxtBoxPswLogin.TabIndex = 7;
            // 
            // TxtBoxPswVerifLogin
            // 
            this.TxtBoxPswVerifLogin.Location = new System.Drawing.Point(381, 373);
            this.TxtBoxPswVerifLogin.Name = "TxtBoxPswVerifLogin";
            this.TxtBoxPswVerifLogin.Size = new System.Drawing.Size(244, 20);
            this.TxtBoxPswVerifLogin.TabIndex = 8;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(381, 453);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(222, 81);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "Connexion";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 621);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtBoxPswVerifLogin);
            this.Controls.Add(this.TxtBoxPswLogin);
            this.Controls.Add(this.TxtBoxEmailLogin);
            this.Controls.Add(this.LblSignUp);
            this.Controls.Add(this.LblPswVerifLogin);
            this.Controls.Add(this.LblPswLogin);
            this.Controls.Add(this.LblEmailLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmailLogin;
        private System.Windows.Forms.Label LblPswLogin;
        private System.Windows.Forms.Label LblPswVerifLogin;
        private System.Windows.Forms.Label LblSignUp;
        private System.Windows.Forms.TextBox TxtBoxEmailLogin;
        private System.Windows.Forms.TextBox TxtBoxPswLogin;
        private System.Windows.Forms.TextBox TxtBoxPswVerifLogin;
        private System.Windows.Forms.Button BtnLogin;
    }
}