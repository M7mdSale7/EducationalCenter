using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EducationalCenter
{
    public partial class Form1E : Form
    {
        public Form1E()
        {
            InitializeComponent();
        }

        private void buttonBookLessons_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2E_A();
            this.DoubleBuffered = true;
            this.Controls.Clear();
            this.Controls.Add(usercontrol);
            this.DoubleBuffered = false;
        }

        private void buttonBookRooms_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2E_B();
            Form FormBookRooms = new Form2(usercontrol);
            FormBookRooms.Show();
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2E_C();
            Form FormStudents = new Form2(usercontrol);
            FormStudents.Show();
        }

        private void buttonParents_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2E_D();
            Form FormParents = new Form2(usercontrol);
            FormParents.Show();
        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2E_E();
            Form FormTeachers = new Form2(usercontrol);
            FormTeachers.Show();
        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2E_H();
            Form FormRooms = new Form2(usercontrol);
            FormRooms.Show();
        }

        private void buttonExams_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2E_G();
            Form FormExams = new Form2(usercontrol);
            FormExams.Show();
        }

        private void buttonSubjects_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2E_F();
            Form FormSubjects = new Form2(usercontrol);
            FormSubjects.Show();
        }
    }
}
