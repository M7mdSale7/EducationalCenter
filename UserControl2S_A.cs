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
            LoadTheme();
            displayData(Form0.Instance.username);
            comboBoxSubject.Items.AddRange(Controller.Instance.getExams_Subjects(Form0.Instance.username));
            comboBoxTeacher.Items.AddRange(Controller.Instance.getExams_Teachers(Form0.Instance.username));
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            labelExams.ForeColor = ThemeColor.PrimaryColor;
            labelLessons.ForeColor = ThemeColor.PrimaryColor;
        }
       
        private void displayData(string username,string type="",  string subjectname="", string Teacher="", string roomnum="", string start_datetime="", string end_datetime="")
        {
            DataTable dt_Lessons = Controller.Instance.Student_getAllLessonsOrExams( username,"subject", subjectname, Teacher, roomnum, start_datetime, end_datetime);
            dataGridViewLessons.DataSource = dt_Lessons.DefaultView;
            DataTable dt_Exams = Controller.Instance.Student_getAllLessonsOrExams(username, "exam", subjectname, Teacher, roomnum, start_datetime, end_datetime);
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
