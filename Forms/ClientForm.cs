using Dump.Entities;
using Dump.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Diagnostics.Debug;

namespace Dump
{
    public partial class ClientForm : Form
    {
        private readonly hulomclientloandbEntities _context;
        private readonly int currentUserID;
        public ClientForm(int currentUserID)
        {
            InitializeComponent();
            _context = new hulomclientloandbEntities();
            this.currentUserID = currentUserID;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = _context.Clients.Where(id => id.UserID == currentUserID).ToList();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddClientForm a = new AddClientForm(currentUserID);

            if (a.ShowDialog() == DialogResult.OK)
            {
                _context.Clients.Add(a.GetToAddOrEdit);
                _context.SaveChanges();
                clientBindingSource.DataSource = _context.Clients.Where(id => id.UserID == currentUserID).ToList();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            AddClientForm a = new AddClientForm(_context.Clients.FirstOrDefault(id => id.ID == selectedClientID), currentUserID);

            if (a.ShowDialog() == DialogResult.OK)
            {
                Client c = _context.Clients.FirstOrDefault(client => client.ID == a.GetToAddOrEdit.ID);

                if (c != null)
                {
                    c.Firstname = a.GetToAddOrEdit.Firstname;
                    c.Lastname = a.GetToAddOrEdit.Lastname;
                    c.Address = a.GetToAddOrEdit.Address;
                    c.Birthdate = a.GetToAddOrEdit.Birthdate;
                    c.Gender = a.GetToAddOrEdit.Gender;
                    c.Email = a.GetToAddOrEdit.Email;
                    c.PhoneNumber = a.GetToAddOrEdit.PhoneNumber;
                    c.UserID = a.GetToAddOrEdit.UserID;
                    _context.SaveChanges();
                }

                clientBindingSource.DataSource = _context.Clients.Where(id => id.UserID == currentUserID).ToList();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedClientID > 0)
            {
                _context.Clients.Remove(_context.Clients.FirstOrDefault(id => id.ID == selectedClientID));
                _context.SaveChanges();
                clientBindingSource.DataSource = _context.Clients.Where(id => id.UserID == currentUserID).ToList();
            }
        }

        private int selectedClientID;
        private void ClientTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ClientTable.SelectedRows.Count > 0)
            {
                selectedClientID = (int)ClientTable.SelectedRows[0].Cells[0].Value;
                WriteLine($"Client ID: {selectedClientID}");
            }
        }

        private void ViewLoanBtn_Click(object sender, EventArgs e)
        {
            if (selectedClientID > 0)
            {
                LoanForm l = new LoanForm(selectedClientID);
                l.ShowDialog();
                clientBindingSource.DataSource = _context.Clients.Where(id => id.UserID == currentUserID).ToList();
            }
        }
    }
}
