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
            this.SuspendLayout();
            // 
            // LblSignUp
            // 
            this.LblSignUp.AutoSize = true;
            this.LblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSignUp.Location = new System.Drawing.Point(436, 56);
            this.LblSignUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblSignUp.Name = "LblSignUp";
            this.LblSignUp.Size = new System.Drawing.Size(260, 73);
            this.LblSignUp.TabIndex = 0;
            this.LblSignUp.Text = "Sign Up";
            // 
            // LblEmailSignUp
            // 
            this.LblEmailSignUp.AutoSize = true;
            this.LblEmailSignUp.Location = new System.Drawing.Point(198, 232);
            this.LblEmailSignUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblEmailSignUp.Name = "LblEmailSignUp";
            this.LblEmailSignUp.Size = new System.Drawing.Size(185, 25);
            this.LblEmailSignUp.TabIndex = 1;
            this.LblEmailSignUp.Text = "Entrez votre email";
            // 
            // LblPswSignUp
            // 
            this.LblPswSignUp.AutoSize = true;
            this.LblPswSignUp.Location = new System.Drawing.Point(241, 296);
            this.LblPswSignUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblPswSignUp.Name = "LblPswSignUp";
            this.LblPswSignUp.Size = new System.Drawing.Size(142, 25);
            this.LblPswSignUp.TabIndex = 2;
            this.LblPswSignUp.Text = "Mot de passe";
            // 
            // LblPswVerifSignUp
            // 
            this.LblPswVerifSignUp.AutoSize = true;
            this.LblPswVerifSignUp.Location = new System.Drawing.Point(117, 365);
            this.LblPswVerifSignUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblPswVerifSignUp.Name = "LblPswVerifSignUp";
            this.LblPswVerifSignUp.Size = new System.Drawing.Size(266, 25);
            this.LblPswVerifSignUp.TabIndex = 3;
            this.LblPswVerifSignUp.Text = "Mot de passe (vérification)";
            // 
            // TxtBoxEmailSignUp
            // 
            this.TxtBoxEmailSignUp.Location = new System.Drawing.Point(427, 229);
            this.TxtBoxEmailSignUp.Name = "TxtBoxEmailSignUp";
            this.TxtBoxEmailSignUp.Size = new System.Drawing.Size(244, 31);
            this.TxtBoxEmailSignUp.TabIndex = 4;
            // 
            // TxtBoxPswSignUp
            // 
            this.TxtBoxPswSignUp.Location = new System.Drawing.Point(427, 296);
            this.TxtBoxPswSignUp.Name = "TxtBoxPswSignUp";
            this.TxtBoxPswSignUp.Size = new System.Drawing.Size(244, 31);
            this.TxtBoxPswSignUp.TabIndex = 5;
            // 
            // TxtBoxPswVerifSignUp
            // 
            this.TxtBoxPswVerifSignUp.Location = new System.Drawing.Point(427, 359);
            this.TxtBoxPswVerifSignUp.Name = "TxtBoxPswVerifSignUp";
            this.TxtBoxPswVerifSignUp.Size = new System.Drawing.Size(244, 31);
            this.TxtBoxPswVerifSignUp.TabIndex = 6;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Location = new System.Drawing.Point(427, 461);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(222, 81);
            this.BtnSignUp.TabIndex = 7;
            this.BtnSignUp.Text = "Enregistrez-vous";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 629);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.TxtBoxPswVerifSignUp);
            this.Controls.Add(this.TxtBoxPswSignUp);
            this.Controls.Add(this.TxtBoxEmailSignUp);
            this.Controls.Add(this.LblPswVerifSignUp);
            this.Controls.Add(this.LblPswSignUp);
            this.Controls.Add(this.LblEmailSignUp);
            this.Controls.Add(this.LblSignUp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SignUp";
            this.Text = "Sign Up";
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
    }
}

