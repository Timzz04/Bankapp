namespace _5T_PROG_PROJECT_BANKAPP
{
    partial class MainScreen
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
            this.Btnexit = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btnexit
            // 
            this.Btnexit.BackColor = System.Drawing.Color.Transparent;
            this.Btnexit.ForeColor = System.Drawing.Color.Black;
            this.Btnexit.Location = new System.Drawing.Point(787, 1);
            this.Btnexit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(56, 19);
            this.Btnexit.TabIndex = 6;
            this.Btnexit.Text = "X";
            this.Btnexit.UseVisualStyleBackColor = false;
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.ForeColor = System.Drawing.Color.Black;
            this.BtnMinimize.Location = new System.Drawing.Point(726, 1);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(56, 19);
            this.BtnMinimize.TabIndex = 7;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnWithdraw);
            this.panel1.Controls.Add(this.BtnDeposit);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 485);
            this.panel1.TabIndex = 8;
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.BackgroundImage = global::_5T_PROG_PROJECT_BANKAPP.Properties.Resources.money_withdrawal;
            this.BtnWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnWithdraw.FlatAppearance.BorderSize = 0;
            this.BtnWithdraw.ForeColor = System.Drawing.Color.Black;
            this.BtnWithdraw.Location = new System.Drawing.Point(1, 100);
            this.BtnWithdraw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(65, 34);
            this.BtnWithdraw.TabIndex = 5;
            this.BtnWithdraw.UseVisualStyleBackColor = true;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.BackgroundImage = global::_5T_PROG_PROJECT_BANKAPP.Properties.Resources.deposit;
            this.BtnDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDeposit.ForeColor = System.Drawing.Color.Black;
            this.BtnDeposit.Location = new System.Drawing.Point(1, 170);
            this.BtnDeposit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(65, 34);
            this.BtnDeposit.TabIndex = 4;
            this.BtnDeposit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::_5T_PROG_PROJECT_BANKAPP.Properties.Resources.dots_menu;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 244);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 34);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::_5T_PROG_PROJECT_BANKAPP.Properties.Resources.info;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 440);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 36);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LblBalance);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LblUsername);
            this.panel2.Location = new System.Drawing.Point(93, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 223);
            this.panel2.TabIndex = 9;
            // 
            // LblBalance
            // 
            this.LblBalance.AutoSize = true;
            this.LblBalance.ForeColor = System.Drawing.Color.Black;
            this.LblBalance.Location = new System.Drawing.Point(33, 57);
            this.LblBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(22, 13);
            this.LblBalance.TabIndex = 3;
            this.LblBalance.Text = "0,0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(77, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Summary";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.ForeColor = System.Drawing.Color.Black;
            this.LblUsername.Location = new System.Drawing.Point(90, 12);
            this.LblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(55, 13);
            this.LblUsername.TabIndex = 0;
            this.LblUsername.Text = "Username";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(854, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnMinimize);
            this.Controls.Add(this.Btnexit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.Button BtnWithdraw;
        private System.Windows.Forms.Button Btnexit;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblBalance;
    }
}