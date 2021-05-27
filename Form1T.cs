using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EducationalCenter
{
    public partial class Form1T : Form
    {
        public Form1T()
        {
            InitializeComponent();
        }

        
        private void buttonViewSchedule_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2T_A();
            Form FormViewSchedule = new Form2(usercontrol);
            FormViewSchedule.Show();
        }

        private void buttonGradesReport_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2T_D();
            Form FormGradesReport = new Form2(usercontrol);
            FormGradesReport.Show();
        }

        private void buttonExams_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2T_E();
            Form FormExams = new Form2(usercontrol);
            FormExams.Show();
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2T_B();
            Form FormStudents = new Form2(usercontrol);
            FormStudents.Show();
        }

        private void buttonTeachingAssistants_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2T_F();
            Form FormTA = new Form2(usercontrol);
            FormTA.Show();
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2T_C();
            Form FormAttendance = new Form2(usercontrol);
            FormAttendance.Show();
        }
    }
}
