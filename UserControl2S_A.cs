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
    public partial class UserControl2S_A : UserControl
    {
       
        public UserControl2S_A()
        {
            InitializeComponent();
            displayData(Form0.Instance.username);
            comboBoxSubject.Items.AddRange(Controller.Instance.getExams_Subjects(Form0.Instance.username));
            comboBoxTeacher.Items.AddRange(Controller.Instance.getExams_Teachers(Form0.Instance.username));
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1S(Form0.Instance.username));
        }
        private void displayData(string username,string type="",  string subjectname="", string Teacher="", string roomnum="", string start_datetime="", string end_datetime="")
        {
            DataTable dt_Lessons = Controller.Instance.Student_getAllLessonsOrExams( username,"subject", subjectname, Teacher, roomnum, start_datetime, end_datetime);
            dataGridViewLessons.DataSource = dt_Lessons.DefaultView;
            DataTable dt_Exams = Controller.Instance.Student_getAllLessonsOrExams(username, "Exam", subjectname, Teacher, roomnum, start_datetime, end_datetime);
            dataGridViewExams.DataSource = dt_Exams.DefaultView;
        }
        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTeacher.Items.Clear();
            comboBoxTeacher.Items.AddRange(Controller.Instance.getExams_Teachers(Form0.Instance.username, comboBoxSubject.Text));
        }

        private void comboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubject.Items.Clear();
            comboBoxSubject.Items.AddRange(Controller.Instance.getExams_Subjects(Form0.Instance.username, comboBoxTeacher.Text));
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            displayData(Form0.Instance.username, "", comboBoxSubject.Text, comboBoxTeacher.Text);
            comboBoxSubject.Text = "";
            comboBoxTeacher.Text = "";
        }
    }
}
