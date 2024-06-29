namespace Dump.Forms
{
    partial class AddLoanForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.LoanAmountTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InterestTextbox = new System.Windows.Forms.TextBox();
            this.TermPaymentComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OtherFeesTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumPaymentTextbox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ReceiptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // LoanAmountTextbox
            // 
            this.LoanAmountTextbox.Location = new System.Drawing.Point(12, 32);
            this.LoanAmountTextbox.Name = "LoanAmountTextbox";
            this.LoanAmountTextbox.Size = new System.Drawing.Size(141, 20);
            this.LoanAmountTextbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Interest";
            // 
            // InterestTextbox
            // 
            this.InterestTextbox.Location = new System.Drawing.Point(12, 71);
            this.InterestTextbox.Name = "InterestTextbox";
            this.InterestTextbox.Size = new System.Drawing.Size(141, 20);
            this.InterestTextbox.TabIndex = 8;
            // 
            // TermPaymentComboBox
            // 
            this.TermPaymentComboBox.FormattingEnabled = true;
            this.TermPaymentComboBox.Location = new System.Drawing.Point(12, 110);
            this.TermPaymentComboBox.Name = "TermPaymentComboBox";
            this.TermPaymentComboBox.Size = new System.Drawing.Size(141, 21);
            this.TermPaymentComboBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Payment Term";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Other Fees";
            // 
            // OtherFeesTextbox
            // 
            this.OtherFeesTextbox.Location = new System.Drawing.Point(12, 189);
            this.OtherFeesTextbox.Name = "OtherFeesTextbox";
            this.OtherFeesTextbox.Size = new System.Drawing.Size(141, 20);
            this.OtherFeesTextbox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "No. of Payment";
            // 
            // NumPaymentTextbox
            // 
            this.NumPaymentTextbox.Location = new System.Drawing.Point(12, 150);
            this.NumPaymentTextbox.Name = "NumPaymentTextbox";
            this.NumPaymentTextbox.Size = new System.Drawing.Size(141, 20);
            this.NumPaymentTextbox.TabIndex = 12;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(39, 242);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 16;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ReceiptLabel
            // 
            this.ReceiptLabel.Location = new System.Drawing.Point(160, 16);
            this.ReceiptLabel.Name = "ReceiptLabel";
            this.ReceiptLabel.Size = new System.Drawing.Size(375, 296);
            this.ReceiptLabel.TabIndex = 17;
            this.ReceiptLabel.Text = "label6";
            // 
            // AddLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 321);
            this.Controls.Add(this.ReceiptLabel);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OtherFeesTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumPaymentTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TermPaymentComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InterestTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoanAmountTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddLoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Loan";
            this.Load += new System.EventHandler(this.AddLoanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoanAmountTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InterestTextbox;
        private System.Windows.Forms.ComboBox TermPaymentComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OtherFeesTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumPaymentTextbox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label ReceiptLabel;
    }
}