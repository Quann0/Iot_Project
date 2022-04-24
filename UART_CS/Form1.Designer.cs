
namespace UART_CS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AccountBox = new System.Windows.Forms.TextBox();
            this.PassWordBox = new System.Windows.Forms.TextBox();
            this.Account = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountBox
            // 
            this.AccountBox.Location = new System.Drawing.Point(288, 122);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(125, 27);
            this.AccountBox.TabIndex = 0;
            this.AccountBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AccountBox_KeyDown);
            // 
            // PassWordBox
            // 
            this.PassWordBox.Location = new System.Drawing.Point(288, 169);
            this.PassWordBox.Name = "PassWordBox";
            this.PassWordBox.Size = new System.Drawing.Size(125, 27);
            this.PassWordBox.TabIndex = 1;
            this.PassWordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassWordBox_KeyDown);
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Account.Location = new System.Drawing.Point(191, 123);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(73, 23);
            this.Account.TabIndex = 2;
            this.Account.Text = "Account";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(174, 176);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "PassWord";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(288, 225);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(94, 29);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SignUp.Location = new System.Drawing.Point(403, 227);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(65, 23);
            this.SignUp.TabIndex = 5;
            this.SignUp.Text = "SignUp";
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.PassWordBox);
            this.Controls.Add(this.AccountBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccountBox;
        private System.Windows.Forms.TextBox PassWordBox;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label SignUp;
        private System.Windows.Forms.Button button1;
    }
}

