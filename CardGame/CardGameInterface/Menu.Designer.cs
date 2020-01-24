namespace CardGameInterface
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.LblMenu = new System.Windows.Forms.Label();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.BtnSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.BackColor = System.Drawing.Color.Transparent;
            this.LblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.Location = new System.Drawing.Point(289, 25);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(193, 73);
            this.LblMenu.TabIndex = 0;
            this.LblMenu.Text = "Menu";
            this.LblMenu.Click += new System.EventHandler(this.LblMenu_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.Transparent;
            this.BtnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.Location = new System.Drawing.Point(271, 154);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(232, 50);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "Jouer";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.Transparent;
            this.BtnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuit.Location = new System.Drawing.Point(271, 239);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(232, 50);
            this.BtnQuit.TabIndex = 3;
            this.BtnQuit.Text = "Quitter";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(650, 25);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 13);
            this.lblEmail.TabIndex = 5;
            // 
            // BtnSignOut
            // 
            this.BtnSignOut.BackColor = System.Drawing.Color.Transparent;
            this.BtnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignOut.Location = new System.Drawing.Point(628, 258);
            this.BtnSignOut.Name = "BtnSignOut";
            this.BtnSignOut.Size = new System.Drawing.Size(180, 42);
            this.BtnSignOut.TabIndex = 6;
            this.BtnSignOut.Text = "Se deconnecter";
            this.BtnSignOut.UseVisualStyleBackColor = false;
            this.BtnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(820, 312);
            this.Controls.Add(this.BtnSignOut);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.LblMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button BtnSignOut;
    }
}