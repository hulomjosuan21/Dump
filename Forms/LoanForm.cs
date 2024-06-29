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
    public partial class LoanForm : Form
    {
        private readonly hulomclientloandbEntities _context = new hulomclientloandbEntities();
        private readonly int CurrentClientID;
        public LoanForm(int CurrentClientID)
        {
            InitializeComponent();
            this.CurrentClientID = CurrentClientID;
        }

        private void SetActiveLoan()
        {
            int count = _context.Loans.Where(id => id.ClientID == CurrentClientID).Count();
            Client c = _context.Clients.FirstOrDefault(id => id.ID == CurrentClientID);

            c.ActiveLoan = count;
            _context.SaveChanges();
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            loanBindingSource.DataSource = _context.Loans.Where(id => id.ClientID == CurrentClientID).ToList();

            SetActiveLoan();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddLoanForm a = new AddLoanForm(CurrentClientID);
            if (a.ShowDialog() == DialogResult.OK)
            {
                _context.Loans.Add(a.GetAddedLoan);

                loanBindingSource.DataSource = _context.Loans.Where(id => id.ClientID == CurrentClientID).ToList();
            }
        }

        private void ViewScheduleBtn_Click(object sender, EventArgs e)
        {
            ScheduleForm s = new ScheduleForm(currentLoanID);

            s.ShowDialog();
        }

        private int currentLoanID;
        private void LoanTable_SelectionChanged(object sender, EventArgs e)
        {
            if (LoanTable.SelectedRows.Count > 0)
            {
                currentLoanID = (int)LoanTable.SelectedRows[0].Cells[0].Value;
            }
        }
    }
}
