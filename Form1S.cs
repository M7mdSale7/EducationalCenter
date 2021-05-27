using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EducationalCenter
{
    public partial class Form1S : Form
    {
        public Form1S()
        {
            InitializeComponent();
        }

        private void buttonViewSchedule_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2S_A();
            Form FormViewSchedule = new Form2(usercontrol);
            FormViewSchedule.Show();
        }

        private void buttonAvailableLessons_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2S_C();
            Form FormAvailableLessons = new Form2(usercontrol);
            FormAvailableLessons.Show();
        }

        private void buttonGradesReport_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2S_B();
            Form FormGradesReport = new Form2(usercontrol);
            FormGradesReport.Show();
        }
    }
}
