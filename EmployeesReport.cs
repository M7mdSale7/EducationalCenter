using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalCenter
{
    public partial class EmployeesReport : UserControl
    {
        public EmployeesReport()
        {
            InitializeComponent();
        } 

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            crystalReportViewer1.ReportSource = employees;
        }
    }
}
