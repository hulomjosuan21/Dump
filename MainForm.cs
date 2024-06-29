using Dump.Entities;
using Dump.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Dump
{
    public partial class MainForm : Form
    {
        private readonly hulomclientloandbEntities _context = new hulomclientloandbEntities();
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

        private int? CurrentUserID;
        private void MainForm_Load(object sender, EventArgs e)
        {
            SignInForm s = new SignInForm();
            if (s.ShowDialog() == DialogResult.OK)
            {
                WindowState = FormWindowState.Maximized;
                if (s.UserID.HasValue)
                {
                    Entities.User u = _context.Users.FirstOrDefault(id => id.ID == s.UserID);
                    CurrentUserID = s.UserID;
                    UsernameLabel.Text = u.Username;

                    openChildForm(new ClientForm((int)CurrentUserID));
                }
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void MemberBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ClientForm((int)CurrentUserID));
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new PaymentForm());
        }
    }
}
