namespace Dump.Forms
{
    partial class SignUpForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.LnameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FnameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.GoSignUpLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lastname";
            // 
            // LnameTextbox
            // 
            this.LnameTextbox.Location = new System.Drawing.Point(107, 81);
            this.LnameTextbox.Name = "LnameTextbox";
            this.LnameTextbox.Size = new System.Drawing.Size(141, 20);
            this.LnameTextbox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Firstname";
            // 
            // FnameTextbox
            // 
            this.FnameTextbox.Location = new System.Drawing.Point(107, 42);
            this.FnameTextbox.Name = "FnameTextbox";
            this.FnameTextbox.Size = new System.Drawing.Size(141, 20);
            this.FnameTextbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(107, 120);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(141, 20);
            this.UsernameTextbox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(107, 159);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = 'J';
            this.PasswordTextbox.Size = new System.Drawing.Size(141, 20);
            this.PasswordTextbox.TabIndex = 14;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Location = new System.Drawing.Point(140, 200);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(75, 23);
            this.SignUpBtn.TabIndex = 16;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // GoSignUpLbl
            // 
            this.GoSignUpLbl.AutoSize = true;
            this.GoSignUpLbl.Location = new System.Drawing.Point(155, 254);
            this.GoSignUpLbl.Name = "GoSignUpLbl";
            this.GoSignUpLbl.Size = new System.Drawing.Size(40, 13);
            this.GoSignUpLbl.TabIndex = 17;
            this.GoSignUpLbl.TabStop = true;
            this.GoSignUpLbl.Text = "Sign In";
            this.GoSignUpLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoSignUpLbl_LinkClicked);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 296);
            this.Controls.Add(this.GoSignUpLbl);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LnameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FnameTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LnameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FnameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.LinkLabel GoSignUpLbl;
    }
}