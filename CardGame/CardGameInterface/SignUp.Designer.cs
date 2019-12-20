namespace CardGameInterface
{
    partial class SignUp
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblSignUp = new System.Windows.Forms.Label();
            this.LblEmailSignUp = new System.Windows.Forms.Label();
            this.LblPswSignUp = new System.Windows.Forms.Label();
            this.LblPswVerifSignUp = new System.Windows.Forms.Label();
            this.TxtBoxEmailSignUp = new System.Windows.Forms.TextBox();
            this.TxtBoxPswSignUp = new System.Windows.Forms.TextBox();
            this.TxtBoxPswVerifSignUp = new System.Windows.Forms.TextBox();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.LblMailErrorSignUp = new System.Windows.Forms.Label();
            this.LblPswErrorSignUp = new System.Windows.Forms.Label();
            this.LblPswverifErrorSignUp = new System.Windows.Forms.Label();
            this.BtnSignUpToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSignUp
            // 
            this.LblSignUp.AutoSize = true;
            this.LblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSignUp.Location = new System.Drawing.Point(287, 32);
            this.LblSignUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblSignUp.Name = "LblSignUp";
            this.LblSignUp.Size = new System.Drawing.Size(151, 42);
            this.LblSignUp.TabIndex = 0;
            this.LblSignUp.Text = "Sign Up";
            // 
            // LblEmailSignUp
            // 
            this.LblEmailSignUp.AutoSize = true;
            this.LblEmailSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailSignUp.Location = new System.Drawing.Point(72, 131);
            this.LblEmailSignUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblEmailSignUp.Name = "LblEmailSignUp";
            this.LblEmailSignUp.Size = new System.Drawing.Size(160, 24);
            this.LblEmailSignUp.TabIndex = 1;
            this.LblEmailSignUp.Text = "Entrez votre email";
            // 
            // LblPswSignUp
            // 
            this.LblPswSignUp.AutoSize = true;
            this.LblPswSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPswSignUp.Location = new System.Drawing.Point(109, 196);
            this.LblPswSignUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblPswSignUp.Name = "LblPswSignUp";
            this.LblPswSignUp.Size = new System.Drawing.Size(123, 24);
            this.LblPswSignUp.TabIndex = 2;
            this.LblPswSignUp.Text = "Mot de passe";
            // 
            // LblPswVerifSignUp
            // 
            this.LblPswVerifSignUp.AutoSize = true;
            this.LblPswVerifSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPswVerifSignUp.Location = new System.Drawing.Point(15, 256);
            this.LblPswVerifSignUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblPswVerifSignUp.Name = "LblPswVerifSignUp";
            this.LblPswVerifSignUp.Size = new System.Drawing.Size(228, 24);
            this.LblPswVerifSignUp.TabIndex = 3;
            this.LblPswVerifSignUp.Text = "Mot de passe (vérification)";
            // 
            // TxtBoxEmailSignUp
            // 
            this.TxtBoxEmailSignUp.Location = new System.Drawing.Point(252, 131);
            this.TxtBoxEmailSignUp.Name = "TxtBoxEmailSignUp";
            this.TxtBoxEmailSignUp.Size = new System.Drawing.Size(244, 31);
            this.TxtBoxEmailSignUp.TabIndex = 4;
            // 
            // TxtBoxPswSignUp
            // 
            this.TxtBoxPswSignUp.Location = new System.Drawing.Point(252, 192);
            this.TxtBoxPswSignUp.Name = "TxtBoxPswSignUp";
            this.TxtBoxPswSignUp.Size = new System.Drawing.Size(244, 31);
            this.TxtBoxPswSignUp.TabIndex = 5;
            // 
            // TxtBoxPswVerifSignUp
            // 
            this.TxtBoxPswVerifSignUp.Location = new System.Drawing.Point(252, 252);
            this.TxtBoxPswVerifSignUp.Name = "TxtBoxPswVerifSignUp";
            this.TxtBoxPswVerifSignUp.PasswordChar = '*';
            this.TxtBoxPswVerifSignUp.Size = new System.Drawing.Size(244, 31);
            this.TxtBoxPswVerifSignUp.TabIndex = 6;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.Location = new System.Drawing.Point(252, 314);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(244, 42);
            this.BtnSignUp.TabIndex = 7;
            this.BtnSignUp.Text = "Enregistrez-vous";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // LblMailErrorSignUp
            // 
            this.LblMailErrorSignUp.AutoSize = true;
            this.LblMailErrorSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMailErrorSignUp.ForeColor = System.Drawing.Color.Red;
            this.LblMailErrorSignUp.Location = new System.Drawing.Point(687, 237);
            this.LblMailErrorSignUp.Name = "LblMailErrorSignUp";
            this.LblMailErrorSignUp.Size = new System.Drawing.Size(0, 20);
            this.LblMailErrorSignUp.TabIndex = 8;
            // 
            // LblPswErrorSignUp
            // 
            this.LblPswErrorSignUp.AutoSize = true;
            this.LblPswErrorSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPswErrorSignUp.ForeColor = System.Drawing.Color.Red;
            this.LblPswErrorSignUp.Location = new System.Drawing.Point(687, 303);
            this.LblPswErrorSignUp.Name = "LblPswErrorSignUp";
            this.LblPswErrorSignUp.Size = new System.Drawing.Size(0, 20);
            this.LblPswErrorSignUp.TabIndex = 9;
            // 
            // LblPswverifErrorSignUp
            // 
            this.LblPswverifErrorSignUp.AutoSize = true;
            this.LblPswverifErrorSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPswverifErrorSignUp.ForeColor = System.Drawing.Color.Red;
            this.LblPswverifErrorSignUp.Location = new System.Drawing.Point(687, 365);
            this.LblPswverifErrorSignUp.Name = "LblPswverifErrorSignUp";
            this.LblPswverifErrorSignUp.Size = new System.Drawing.Size(0, 20);
            this.LblPswverifErrorSignUp.TabIndex = 10;
            // 
            // BtnSignUpToLogin
            // 
            this.BtnSignUpToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUpToLogin.Location = new System.Drawing.Point(513, 388);
            this.BtnSignUpToLogin.Name = "BtnSignUpToLogin";
            this.BtnSignUpToLogin.Size = new System.Drawing.Size(144, 49);
            this.BtnSignUpToLogin.TabIndex = 11;
            this.BtnSignUpToLogin.Text = "Se connecter";
            this.BtnSignUpToLogin.UseVisualStyleBackColor = true;
            this.BtnSignUpToLogin.Click += new System.EventHandler(this.BtnSignUpToLogin_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(669, 449);
            this.Controls.Add(this.BtnSignUpToLogin);
            this.Controls.Add(this.LblPswverifErrorSignUp);
            this.Controls.Add(this.LblPswErrorSignUp);
            this.Controls.Add(this.LblMailErrorSignUp);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.TxtBoxPswVerifSignUp);
            this.Controls.Add(this.TxtBoxPswSignUp);
            this.Controls.Add(this.TxtBoxEmailSignUp);
            this.Controls.Add(this.LblPswVerifSignUp);
            this.Controls.Add(this.LblPswSignUp);
            this.Controls.Add(this.LblEmailSignUp);
            this.Controls.Add(this.LblSignUp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_Closing);
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSignUp;
        private System.Windows.Forms.Label LblEmailSignUp;
        private System.Windows.Forms.Label LblPswSignUp;
        private System.Windows.Forms.Label LblPswVerifSignUp;
        private System.Windows.Forms.TextBox TxtBoxEmailSignUp;
        private System.Windows.Forms.TextBox TxtBoxPswSignUp;
        private System.Windows.Forms.TextBox TxtBoxPswVerifSignUp;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Label LblMailErrorSignUp;
        private System.Windows.Forms.Label LblPswErrorSignUp;
        private System.Windows.Forms.Label LblPswverifErrorSignUp;
        private System.Windows.Forms.Button BtnSignUpToLogin;
    }
}

