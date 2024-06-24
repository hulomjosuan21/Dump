namespace Dump.Forms
{
    partial class PaymentForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoanTable = new System.Windows.Forms.DataGridView();
            this.ScheduleTable = new System.Windows.Forms.DataGridView();
            this.ClientIDTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentTextbox = new System.Windows.Forms.TextBox();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoanTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PaymentBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PaymentTextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ClientIDTextbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 334);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ScheduleTable);
            this.panel2.Controls.Add(this.LoanTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(159, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(365, 334);
            this.panel2.TabIndex = 3;
            // 
            // LoanTable
            // 
            this.LoanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoanTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoanTable.Location = new System.Drawing.Point(10, 10);
            this.LoanTable.Name = "LoanTable";
            this.LoanTable.Size = new System.Drawing.Size(345, 158);
            this.LoanTable.TabIndex = 0;
            // 
            // ScheduleTable
            // 
            this.ScheduleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleTable.Location = new System.Drawing.Point(10, 168);
            this.ScheduleTable.Name = "ScheduleTable";
            this.ScheduleTable.Size = new System.Drawing.Size(345, 156);
            this.ScheduleTable.TabIndex = 1;
            // 
            // ClientIDTextbox
            // 
            this.ClientIDTextbox.Location = new System.Drawing.Point(12, 29);
            this.ClientIDTextbox.Name = "ClientIDTextbox";
            this.ClientIDTextbox.Size = new System.Drawing.Size(141, 20);
            this.ClientIDTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payment Amount";
            // 
            // PaymentTextbox
            // 
            this.PaymentTextbox.Location = new System.Drawing.Point(12, 76);
            this.PaymentTextbox.Name = "PaymentTextbox";
            this.PaymentTextbox.Size = new System.Drawing.Size(141, 20);
            this.PaymentTextbox.TabIndex = 2;
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.Location = new System.Drawing.Point(12, 103);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(75, 23);
            this.PaymentBtn.TabIndex = 4;
            this.PaymentBtn.Text = "Payout";
            this.PaymentBtn.UseVisualStyleBackColor = true;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 334);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoanTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView LoanTable;
        private System.Windows.Forms.DataGridView ScheduleTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PaymentTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientIDTextbox;
        private System.Windows.Forms.Button PaymentBtn;
    }
}