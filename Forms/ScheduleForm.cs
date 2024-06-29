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
    public partial class ScheduleForm : Form
    {
        private readonly int currentLoanID;
        public ScheduleForm(int currentLoanID)
        {
            InitializeComponent();
            this.currentLoanID = currentLoanID;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            hulomclientloandbEntities _con = new hulomclientloandbEntities();
            scheduleBindingSource.DataSource = _con.Schedules.Where(id => id.LoanID == currentLoanID).ToList();
        }
    }
}
