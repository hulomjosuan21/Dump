using Dump.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dump.Forms
{
    public partial class SignUpForm : Form
    {
        private readonly hulomclientloandbEntities _context = new hulomclientloandbEntities();
        public SignUpForm()
        {
            InitializeComponent();
        }

        public int NewUserID { get; set; }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string fname = FnameTextbox.Text.Trim();
            string lname = LnameTextbox.Text.Trim();
            string username = UsernameTextbox.Text.Trim();
            string password = PasswordTextbox.Text.Trim();

            bool usernameExists = _context.Users.Any(user => user.Username == username);

            if (usernameExists)
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Entities.User newUser = new Entities.User()
            {
                Firstname = fname,
                Lastname = lname,
                Username = username,
                Password = password,
                Usertype = "Regular"
            };

            try
            {
                _context.Users.Add(newUser);
                _context.SaveChanges();
                NewUserID = newUser.ID;
                DialogResult = DialogResult.OK;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        sb.AppendLine($"{validationError.PropertyName}: {validationError.ErrorMessage}");
                    }
                }

                MessageBox.Show(sb.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void GoSignUpLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
