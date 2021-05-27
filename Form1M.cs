using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EducationalCenter
{
    public partial class Form1M : Form
    {
        public Form1M()
        {
            InitializeComponent();
        }

        private void buttonHireEmployees_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2M_A();
            Form FormEmployees = new Form2(usercontrol);
            FormEmployees.Show();
        }

        private void buttonMakeAccounts_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2M_B();
            Form FormAccounts = new Form2(usercontrol);
            FormAccounts.Show();
        }
    }
}
