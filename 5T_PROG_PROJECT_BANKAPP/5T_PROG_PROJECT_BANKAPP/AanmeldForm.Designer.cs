namespace _5T_PROG_PROJECT_BANKAPP
{
    partial class AanmeldForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnInloggen = new System.Windows.Forms.Button();
            this.LblText = new System.Windows.Forms.Label();
            this.LblRegistreren = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aanmelden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 74);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(92, 169);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtUsername.Multiline = true;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(92, 22);
            this.TxtUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gebruikersnaam";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(92, 209);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(92, 22);
            this.TxtPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Passwoord";
            // 
            // BtnInloggen
            // 
            this.BtnInloggen.Location = new System.Drawing.Point(92, 250);
            this.BtnInloggen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnInloggen.Name = "BtnInloggen";
            this.BtnInloggen.Size = new System.Drawing.Size(90, 28);
            this.BtnInloggen.TabIndex = 7;
            this.BtnInloggen.Text = "Inloggen";
            this.BtnInloggen.UseVisualStyleBackColor = true;
            this.BtnInloggen.Click += new System.EventHandler(this.BtnInloggen_Click);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Location = new System.Drawing.Point(95, 280);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(87, 13);
            this.LblText.TabIndex = 8;
            this.LblText.Text = "Geen account ? ";
            // 
            // LblRegistreren
            // 
            this.LblRegistreren.AutoSize = true;
            this.LblRegistreren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistreren.Location = new System.Drawing.Point(68, 305);
            this.LblRegistreren.Name = "LblRegistreren";
            this.LblRegistreren.Size = new System.Drawing.Size(140, 13);
            this.LblRegistreren.TabIndex = 9;
            this.LblRegistreren.Text = "Maak Hier een account";
            this.LblRegistreren.Click += new System.EventHandler(this.LblRegistreren_Click);
            // 
            // AanmeldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 327);
            this.Controls.Add(this.LblRegistreren);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.BtnInloggen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AanmeldForm";
            this.Text = "Aanmelden";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnInloggen;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.Label LblRegistreren;
    }
}

