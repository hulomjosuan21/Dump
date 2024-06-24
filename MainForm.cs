using Dump.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dump
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Form activeform = null;
        private void openChildForm(Form childform)
        {
            if (activeform != null)
                activeform.Close();

            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childform);
            MainPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            openChildForm(new ClientForm());
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void MemberBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ClientForm());
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new PaymentForm());
        }
    }
}
