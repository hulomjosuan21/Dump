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
    public partial class PaymentForm : Form
    {
        private string[] PaymentOption = { "Partial Payment", "Full Payment" };
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            DataGridViewCell L_currentCell = LoanTable.CurrentCell;
            int? L_currentCellRowIndex = L_currentCell?.RowIndex;
            int? L_currentCellColumnIndex = L_currentCell?.ColumnIndex;

            using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
            {
                if (decimal.TryParse(PaymentTextbox.Text.Trim(), out decimal pay_amount))
                {
                    Schedule currentSchedule = _con.Schedules.FirstOrDefault(id => id.ID == currentScheduleID);
                    Loan currentLoan = _con.Loans.FirstOrDefault(id => id.LoanID == currentLoanID);
                    int OldNumLoan = _con.Loans.Where(id => id.ClientID == currentClientID && id.Status == ListOfLoanStatus.Ongoing.ToString()).Count();

                    if (currentLoan.TotalPayable > 0)
                    {
                        if (currentSchedule != null)
                        {
                            if (pay_amount <= currentLoan.TotalPayable)
                            {
                                decimal remainingPayment = pay_amount;
                                currentLoan.TotalPayable -= pay_amount;

                                if (currentLoan.TotalPayable == 0)
                                {
                                    currentLoan.Status = ListOfLoanStatus.Paid.ToString();
                                }

                                while (remainingPayment > 0 && currentSchedule != null)
                                {
                                    decimal oldCollectable = currentSchedule.CollectablesDump;
                                    decimal newCollectable = oldCollectable - remainingPayment;

                                    if (newCollectable <= 0)
                                    {
                                        remainingPayment = -newCollectable;
                                        currentSchedule.CollectablesDump = 0;
                                        currentSchedule.Status = ListOfLoanStatus.Paid.ToString();

                                        currentSchedule = _con.Schedules
                                            .Where(s => s.LoanID == currentLoanID && s.Status == ListOfLoanStatus.Ongoing.ToString())
                                            .OrderBy(s => s.Date)
                                            .FirstOrDefault();
                                    }
                                    else
                                    {
                                        currentSchedule.CollectablesDump = newCollectable;
                                        remainingPayment = 0;
                                    }

                                    _con.SaveChanges();
                                }

                                int newNumLoan = _con.Loans.Where(id => id.ClientID == currentClientID && id.Status == ListOfLoanStatus.Ongoing.ToString()).Count();

                                if (OldNumLoan != newNumLoan)
                                {
                                    Client loanCount = _con.Clients.FirstOrDefault(id => id.ID == currentClientID);
                                    loanCount.ActiveLoan = newNumLoan;
                                    _con.SaveChanges();
                                }

                                scheduleBindingSource.DataSource = _con.Schedules.Where(id => id.LoanID == currentLoanID && id.ClientID == currentClientID).ToList();

                                loanBindingSource.DataSource = _con.Loans.Where(id => id.ClientID == currentClientID).ToList();

                                if (L_currentCellRowIndex.HasValue && L_currentCellColumnIndex.HasValue)
                                {
                                    LoanTable.CurrentCell = LoanTable.Rows[L_currentCellRowIndex.Value].Cells[L_currentCellColumnIndex.Value];
                                }

                            }
                            else
                            {
                                MessageBox.Show("Payment Amount Exceed to Loan Total Payable", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Loan is Already Paid", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private int currentScheduleID;
        private decimal currentCollectables;
        private void ScheduleTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ScheduleTable.SelectedRows.Count == 0)
            {
                return;
            }

            currentScheduleID = (int)ScheduleTable.SelectedRows[0].Cells[0].Value;
            currentCollectables = (decimal)ScheduleTable.SelectedRows[0].Cells[6].Value;

            if (PaymentOptionComboBox.SelectedItem.Equals(PaymentOption[1]))
            {
                PaymentTextbox.Text = currentCollectables.ToString();
            }
            else
            {

                PaymentTextbox.Text = string.Empty;
            }

            if (currentCollectables > 0)
            {
                OutStandingBalanceLabel.Text = $"{currentCollectables:F2}";
            }
            else
            {
                OutStandingBalanceLabel.Text = "Paid";
            }
        }

        private int currentClientID;
        private void ClientIDTextbox_TextChanged(object sender, EventArgs e)
        {
            using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
            {
                if (int.TryParse(ClientIDTextbox.Text.Trim(), out int client_id))
                {
                    List<Loan> loans = _con.Loans.Where(id => id.ClientID == client_id).ToList();
                    if (loans != null)
                    {
                        loanBindingSource.DataSource = loans;
                    }
                    currentClientID = client_id;
                    LoanTable.CurrentCell = null;
                }
                else
                {
                    loanBindingSource.DataSource = null;
                    currentScheduleID = 0;
                }
                _con.Dispose();
            }
        }
        private int currentLoanID;
        private string currentSelectedPaymentTerm;
        private void LoanTable_SelectionChanged(object sender, EventArgs e)
        {
            if (LoanTable.SelectedRows.Count == 0)
            {
                scheduleBindingSource.DataSource = null;
                return;
            }

            currentLoanID = (int)LoanTable.SelectedRows[0].Cells[0].Value;
            currentSelectedPaymentTerm = PaymentOptionComboBox.SelectedItem.ToString();
            ScheduleTable.CurrentCell = null;
            using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
            {
                if (LoanTable.SelectedRows.Count > 0)
                {
                    scheduleBindingSource.DataSource = _con.Schedules.Where(id => id.LoanID == currentLoanID && id.ClientID == currentClientID).ToList();
                }
                _con.Dispose();
            }
        }

        private void PaymentOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaymentOptionComboBox.SelectedItem.Equals(PaymentOption[0]))
            {
                PaymentTextbox.Text = string.Empty;
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            PaymentOptionComboBox.DataSource = PaymentOption;
        }
    }
}
