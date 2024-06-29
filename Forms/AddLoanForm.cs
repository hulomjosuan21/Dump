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
    public partial class AddLoanForm : Form
    {
        private readonly int CurrentClientID;
        public AddLoanForm(int CurrentClientID)
        {
            InitializeComponent();

            TermPaymentComboBox.DataSource = Enum.GetValues(typeof(ListOfPaymentTerm));

            LoanAmountTextbox.TextChanged += new EventHandler(InputChanges);

            InterestTextbox.TextChanged += new EventHandler(InputChanges);

            TermPaymentComboBox.SelectedIndexChanged += new EventHandler(InputChanges);

            NumPaymentTextbox.TextChanged += new EventHandler(InputChanges);

            OtherFeesTextbox.TextChanged += new EventHandler(InputChanges);

            this.CurrentClientID = CurrentClientID;
        }

        private void InputChanges(object sender, EventArgs e)
        {
            decimal.TryParse(LoanAmountTextbox.Text, out decimal loanAmt);
            decimal.TryParse(InterestTextbox.Text, out decimal interest);
            int.TryParse(InterestTextbox.Text, out int numPayment);
            decimal.TryParse(OtherFeesTextbox.Text, out decimal deduction);
            ListOfPaymentTerm term = (ListOfPaymentTerm)TermPaymentComboBox.SelectedItem;

            decimal interest_amount = InterestedAmount(loanAmt, interest);
            decimal receivable_amount = ReceivableAmount(loanAmt, interest_amount, deduction);
            decimal total_payable = TotalPayable(loanAmt, interest_amount);
            DateTime due_date = GetDueDate(term, numPayment);

            string receiptText = $"Capital: {loanAmt.ToString("F2")}\nInterest: {interest.ToString("F1")}%\nPayment Term: {term}\nNo. of Payment: {numPayment}\nOther Fees: {deduction}\n\nInterest Amount: {interest_amount}\nReceivable Amount: {receivable_amount}\nTotal Payable: {total_payable}\nDuedate: {due_date.ToString("MM-dd-yyyy")}";
            ReceiptLabel.Text = receiptText;
        }

        public DateTime GetDueDate(ListOfPaymentTerm t, int n)
        {
            DateTime release = DateTime.Now;
            DateTime due = release.AddDays(5);
            switch (t)
            {
                case ListOfPaymentTerm.Daily:
                    due = release.AddDays(n);
                    break;
                case ListOfPaymentTerm.Weekly:
                    due = release.AddDays(n * 7);
                    break;
                case ListOfPaymentTerm.Bi_Monthly:
                    due = release.AddDays(n * 15);
                    break;
                case ListOfPaymentTerm.Monthly:
                    due = release.AddMonths(n);
                    break;
                case ListOfPaymentTerm.Annually:
                    due = release.AddYears(n);
                    break;
                default:
                    break;
            }
            return due;
        }

        private void AddLoanForm_Load(object sender, EventArgs e)
        {
            string receiptText = $"Capital: 0\nInterest: 0%\nPayment Term: \nNo. of Payment: 0\nOther Fees: 0\n\nInterest Amount: 0\nReceivable Amount: 0\nTotal Payable: 0\nDuedate: ";
            ReceiptLabel.Text = receiptText;
        }

        public decimal InterestedAmount(decimal loanAmount, decimal interest) => (loanAmount * interest) / 100;
        public decimal ReceivableAmount(decimal loanAmount, decimal interestedAmount, decimal deduction) => ((loanAmount + interestedAmount) - deduction);
        public decimal TotalPayable(decimal loanAmount, decimal interestedAmount) => (loanAmount + interestedAmount);
        public Loan GetAddedLoan { get; set; } = new Loan();
        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
            {
                try
                {
                    if (!decimal.TryParse(LoanAmountTextbox.Text, out decimal loanAmt) || loanAmt <= 0)
                    {
                        MessageBox.Show("Invalid loan amount. Please enter a valid number greater than zero.");
                        return;
                    }
                    decimal.TryParse(InterestTextbox.Text, out decimal interest);
                    if (!int.TryParse(NumPaymentTextbox.Text, out int numPayment) || numPayment <= 1)
                    {
                        MessageBox.Show("Invalid number of payments. Please enter a valid number greater than one.");
                        return;
                    }

                    ListOfPaymentTerm term = (ListOfPaymentTerm)TermPaymentComboBox.SelectedItem;
                    decimal.TryParse(OtherFeesTextbox.Text, out decimal deduction);
                    DateTime due_date = GetDueDate(term, numPayment);
                    decimal interest_amount = InterestedAmount(loanAmt, interest);
                    decimal receivable_amount = ReceivableAmount(loanAmt, interest_amount, deduction);
                    decimal total_payable = TotalPayable(loanAmt, interest_amount);

                    GetAddedLoan.ClientID = CurrentClientID;
                    GetAddedLoan.LoanAmount = loanAmt;
                    GetAddedLoan.Interest = interest / 100;
                    GetAddedLoan.NoOfPayments = numPayment;
                    GetAddedLoan.PaymentTerm = term.ToString();
                    GetAddedLoan.Deduction = deduction;
                    GetAddedLoan.InterestedAmount = interest_amount;
                    GetAddedLoan.ReceivableAmount = receivable_amount;
                    GetAddedLoan.TotalPayable = total_payable;
                    GetAddedLoan.DueDate = due_date;
                    GetAddedLoan.Status = ListOfLoanStatus.Ongoing.ToString();

                    _con.Loans.Add(GetAddedLoan);
                    _con.SaveChanges();
                    int loan_id = GetAddedLoan.LoanID;

                    List<Schedule> GetAddedSchedules = new List<Schedule> { };

                    DateTime release = DateTime.Now;

                    for (int i = 0; i < numPayment; i++)
                    {
                        Schedule temp = new Schedule();

                        switch (term)
                        {
                            case ListOfPaymentTerm.Daily:
                                release = release.AddDays(1);
                                break;
                            case ListOfPaymentTerm.Weekly:
                                release = release.AddDays(7);
                                break;
                            case ListOfPaymentTerm.Bi_Monthly:
                                release = release.AddDays(15);
                                break;
                            case ListOfPaymentTerm.Monthly:
                                release = release.AddMonths(1);
                                break;
                            case ListOfPaymentTerm.Annually:
                                release = release.AddYears(1);
                                break;
                            default:
                                release = release.AddDays(1);
                                break;
                        }

                        temp.LoanID = loan_id;
                        temp.ClientID = CurrentClientID;
                        temp.Collectables = total_payable / numPayment;
                        temp.CollectablesDump = total_payable / numPayment;
                        temp.Date = release;
                        temp.Status = ListOfLoanStatus.Ongoing.ToString();

                        GetAddedSchedules.Add(temp);
                    }

                    _con.Schedules.AddRange(GetAddedSchedules);
                    _con.SaveChanges();

                    _con.Dispose();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception)
                { }
            }
        }
    }

    public enum ListOfPaymentTerm
    {
        Daily,
        Weekly,
        Bi_Monthly,
        Monthly,
        Annually
    }

    public enum ListOfLoanStatus
    {
        Ongoing,
        Paid,
        Penalized
    }
}
