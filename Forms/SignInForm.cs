using Dump.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dump.Forms
{
    public partial class SignInForm : Form
    {
        private readonly hulomclientloandbEntities _context = new hulomclientloandbEntities();
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private LoginResult GetUserID(string username, string password)
        {
            Entities.User user = _context.Users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                return new LoginResult { IsUsernameCorrect = false, IsPasswordCorrect = false };
            }

            bool isPasswordCorrect = user.Password == password;
            return new LoginResult
            {
                UserID = isPasswordCorrect ? user.ID : (int?)null,
                IsUsernameCorrect = true,
                IsPasswordCorrect = isPasswordCorrect
            };
        }

        public int? UserID { get; set; }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTextbox.Text.Trim();
            string password = PasswordTextbox.Text.Trim();


            LoginResult loginResult = GetUserID(username, password);

            UserID = loginResult.UserID;
            if (UserID.HasValue)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (!loginResult.IsUsernameCorrect)
                {
                    MessageBox.Show("Username is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!loginResult.IsPasswordCorrect)
                {
                    MessageBox.Show("Password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No user found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GoSignUpLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            SignUpForm s = new SignUpForm();

            if (s.ShowDialog() == DialogResult.OK)
            {
                UserID = s.NewUserID;
                DialogResult = DialogResult.OK;
            }
            else
            {
                Show();
            }
        }
    }

    public class LoginResult
    {
        public int? UserID { get; set; }
        public bool IsUsernameCorrect { get; set; }
        public bool IsPasswordCorrect { get; set; }
    }
}
