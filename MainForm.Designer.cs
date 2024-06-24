namespace Dump
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.MemberBtn = new System.Windows.Forms.Button();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PaymentBtn);
            this.panel1.Controls.Add(this.MemberBtn);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 373);
            this.panel1.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(137, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(540, 373);
            this.MainPanel.TabIndex = 1;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Location = new System.Drawing.Point(31, 53);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(75, 23);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // MemberBtn
            // 
            this.MemberBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberBtn.Location = new System.Drawing.Point(31, 94);
            this.MemberBtn.Name = "MemberBtn";
            this.MemberBtn.Size = new System.Drawing.Size(75, 23);
            this.MemberBtn.TabIndex = 1;
            this.MemberBtn.Text = "Member";
            this.MemberBtn.UseVisualStyleBackColor = true;
            this.MemberBtn.Click += new System.EventHandler(this.MemberBtn_Click);
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentBtn.Location = new System.Drawing.Point(31, 137);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(75, 23);
            this.PaymentBtn.TabIndex = 2;
            this.PaymentBtn.Text = "Payment";
            this.PaymentBtn.UseVisualStyleBackColor = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 373);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Button MemberBtn;
        private System.Windows.Forms.Button HomeBtn;
    }
}