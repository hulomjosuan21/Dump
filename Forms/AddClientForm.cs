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
    public partial class AddClientForm : Form
    {
        private readonly int currentUserID;
        public AddClientForm(int currentUserID)
        {
            InitializeComponent();
            this.currentUserID = currentUserID;
        }

        private readonly Client toEditClient;
        private readonly bool isEdit = false;
        public AddClientForm(Client toEditClient, int currentUserID) : this(currentUserID)
        {
            if (toEditClient != null)
            {
                isEdit = true;
                this.toEditClient = toEditClient;
            }
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                FnameTextbox.Text = toEditClient.Firstname;
                LnameTextbox.Text = toEditClient.Lastname;
                AddressTextbox.Text = toEditClient.Address;

                if (string.Equals(toEditClient.Gender, "Male"))
                {
                    GenderComboBox.SelectedIndex = 0;
                }
                else GenderComboBox.SelectedIndex = 1;

                BdayDtPicke.Value = toEditClient.Birthdate;
                EmailTextbox.Text = toEditClient.Email;
                PhoneNumTextbox.Text = toEditClient.PhoneNumber;
            }
        }

        public Client GetToAddOrEdit { get; set; } = new Client();
        private void AddBtn_Click(object sender, EventArgs e)
        {
            string fname = FnameTextbox.Text.Trim();
            string lname = LnameTextbox.Text.Trim();
            string address = AddressTextbox.Text.Trim();
            DateTime bday = BdayDtPicke.Value;
            string gender = GenderComboBox.SelectedItem.ToString();
            string email = EmailTextbox.Text.Trim();
            string phoneNum = PhoneNumTextbox.Text.Trim();

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(address) || bday == default(DateTime) || string.IsNullOrEmpty(gender) ||string.IsNullOrEmpty(email) ||string.IsNullOrEmpty(phoneNum))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            GetToAddOrEdit.Firstname = fname;
            GetToAddOrEdit.Lastname = lname;
            GetToAddOrEdit.Address = address;
            GetToAddOrEdit.Birthdate = bday;
            GetToAddOrEdit.Gender = gender;
            GetToAddOrEdit.Email = email;
            GetToAddOrEdit.PhoneNumber = phoneNum;

            if (!isEdit)
            {
                GetToAddOrEdit.UserID = currentUserID;
            }
            else
            {
                GetToAddOrEdit.ID = toEditClient.ID;
                GetToAddOrEdit.UserID = currentUserID;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
