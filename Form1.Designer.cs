
namespace POSK_Projekt3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        Form2 okno2;
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
            this.napis_logowania = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.haslo = new System.Windows.Forms.Label();
            this.przycisk_zaloguj = new System.Windows.Forms.Button();
            this.pole_login = new System.Windows.Forms.TextBox();
            this.pole_haslo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // napis_logowania
            // 
            this.napis_logowania.AutoSize = true;
            this.napis_logowania.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napis_logowania.Location = new System.Drawing.Point(7, 9);
            this.napis_logowania.Name = "napis_logowania";
            this.napis_logowania.Size = new System.Drawing.Size(342, 20);
            this.napis_logowania.TabIndex = 0;
            this.napis_logowania.Text = "Logowanie do stanowiska dyspozytora lini produkcyjnej";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login.Location = new System.Drawing.Point(84, 44);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(46, 20);
            this.login.TabIndex = 1;
            this.login.Text = "Login:";
            // 
            // haslo
            // 
            this.haslo.AutoSize = true;
            this.haslo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo.Location = new System.Drawing.Point(84, 76);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(47, 20);
            this.haslo.TabIndex = 2;
            this.haslo.Text = "Hasło:";
            // 
            // przycisk_zaloguj
            // 
            this.przycisk_zaloguj.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_zaloguj.Location = new System.Drawing.Point(136, 168);
            this.przycisk_zaloguj.Name = "przycisk_zaloguj";
            this.przycisk_zaloguj.Size = new System.Drawing.Size(100, 37);
            this.przycisk_zaloguj.TabIndex = 3;
            this.przycisk_zaloguj.Text = "Zaloguj";
            this.przycisk_zaloguj.UseVisualStyleBackColor = true;
            this.przycisk_zaloguj.Click += new System.EventHandler(this.button_potwierdz_obecnosc);
            // 
            // pole_login
            // 
            this.pole_login.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pole_login.Location = new System.Drawing.Point(136, 41);
            this.pole_login.Name = "pole_login";
            this.pole_login.Size = new System.Drawing.Size(100, 26);
            this.pole_login.TabIndex = 4;
            // 
            // pole_haslo
            // 
            this.pole_haslo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pole_haslo.Location = new System.Drawing.Point(136, 73);
            this.pole_haslo.Name = "pole_haslo";
            this.pole_haslo.PasswordChar = '*';
            this.pole_haslo.Size = new System.Drawing.Size(100, 26);
            this.pole_haslo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(24, 106);
            this.label4.MinimumSize = new System.Drawing.Size(320, 20);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(320, 20);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(23, 135);
            this.label5.MinimumSize = new System.Drawing.Size(320, 20);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(320, 20);
            this.label5.TabIndex = 7;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 210);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pole_haslo);
            this.Controls.Add(this.pole_login);
            this.Controls.Add(this.przycisk_zaloguj);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.napis_logowania);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label napis_logowania;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label haslo;
        private System.Windows.Forms.Button przycisk_zaloguj;
        private System.Windows.Forms.TextBox pole_login;
        private System.Windows.Forms.TextBox pole_haslo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

