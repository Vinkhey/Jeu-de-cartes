namespace CardGameInterface
{
    partial class CardsGame
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
            this.LblRegister = new System.Windows.Forms.Label();
            this.LblEmailRegister = new System.Windows.Forms.Label();
            this.LblInscrit = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblRegister
            // 
            this.LblRegister.AutoSize = true;
            this.LblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegister.Location = new System.Drawing.Point(177, 58);
            this.LblRegister.Name = "LblRegister";
            this.LblRegister.Size = new System.Drawing.Size(653, 73);
            this.LblRegister.TabIndex = 0;
            this.LblRegister.Text = "Enregistrement validé";
            // 
            // LblEmailRegister
            // 
            this.LblEmailRegister.AutoSize = true;
            this.LblEmailRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailRegister.Location = new System.Drawing.Point(282, 261);
            this.LblEmailRegister.Name = "LblEmailRegister";
            this.LblEmailRegister.Size = new System.Drawing.Size(30, 25);
            this.LblEmailRegister.TabIndex = 1;
            this.LblEmailRegister.Text = "...";
            // 
            // LblInscrit
            // 
            this.LblInscrit.AutoSize = true;
            this.LblInscrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInscrit.Location = new System.Drawing.Point(377, 261);
            this.LblInscrit.Name = "LblInscrit";
            this.LblInscrit.Size = new System.Drawing.Size(243, 25);
            this.LblInscrit.TabIndex = 2;
            this.LblInscrit.Text = "Vous êtes bien inscrit -e";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(344, 379);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(222, 81);
            this.BtnRegister.TabIndex = 3;
            this.BtnRegister.Text = "Connectez-vous";
            this.BtnRegister.UseVisualStyleBackColor = true;
            // 
            // CardsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 648);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.LblInscrit);
            this.Controls.Add(this.LblEmailRegister);
            this.Controls.Add(this.LblRegister);
            this.Name = "CardsGame";
            this.Text = "CardsGame";
            this.Load += new System.EventHandler(this.CardsGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegister;
        private System.Windows.Forms.Label LblEmailRegister;
        private System.Windows.Forms.Label LblInscrit;
        private System.Windows.Forms.Button BtnRegister;
    }
}