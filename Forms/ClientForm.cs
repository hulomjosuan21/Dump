using Dump.Entities;
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
using static System.Diagnostics.Debug;

namespace Dump
{
    public partial class ClientForm : Form
    {
        private readonly hulomclientloandbEntities _context;
        public ClientForm()
        {
            InitializeComponent();
            _context = new hulomclientloandbEntities();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = _context.Clients.ToList();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddClientForm a = new AddClientForm(1);

            if (a.ShowDialog() == DialogResult.OK)
            {
                _context.Clients.Add(a.GetToAddOrEdit);
                _context.SaveChanges();
                clientBindingSource.DataSource = _context.Clients.ToList();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            AddClientForm a = new AddClientForm(_context.Clients.FirstOrDefault(id => id.ID == selectedClientID),1);

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

                clientBindingSource.DataSource = _context.Clients.ToList();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedClientID > 0)
            {
                _context.Clients.Remove(_context.Clients.FirstOrDefault(id => id.ID == selectedClientID));
                _context.SaveChanges();
                clientBindingSource.DataSource = _context.Clients.ToList();
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

    }
}
