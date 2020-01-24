namespace CardGameInterface
{
    partial class RegisterCorrect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterCorrect));
            this.LblRegister = new System.Windows.Forms.Label();
            this.LblInscrit = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblRegister
            // 
            this.LblRegister.AutoSize = true;
            this.LblRegister.BackColor = System.Drawing.Color.Transparent;
            this.LblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegister.ForeColor = System.Drawing.Color.White;
            this.LblRegister.Location = new System.Drawing.Point(225, 34);
            this.LblRegister.Name = "LblRegister";
            this.LblRegister.Size = new System.Drawing.Size(378, 42);
            this.LblRegister.TabIndex = 0;
            this.LblRegister.Text = "Enregistrement validé";
            // 
            // LblInscrit
            // 
            this.LblInscrit.AutoSize = true;
            this.LblInscrit.BackColor = System.Drawing.Color.Transparent;
            this.LblInscrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInscrit.ForeColor = System.Drawing.Color.White;
            this.LblInscrit.Location = new System.Drawing.Point(280, 141);
            this.LblInscrit.Name = "LblInscrit";
            this.LblInscrit.Size = new System.Drawing.Size(243, 25);
            this.LblInscrit.TabIndex = 2;
            this.LblInscrit.Text = "Vous êtes bien inscrit -e";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Location = new System.Drawing.Point(306, 233);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(188, 57);
            this.BtnRegister.TabIndex = 3;
            this.BtnRegister.Text = "Connectez-vous";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // RegisterCorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 324);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.LblInscrit);
            this.Controls.Add(this.LblRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterCorrect";
            this.Text = "RegisterCorrect";
            this.Load += new System.EventHandler(this.RegisterCorrect_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegister;
        private System.Windows.Forms.Label LblInscrit;
        private System.Windows.Forms.Button BtnRegister;
    }
}