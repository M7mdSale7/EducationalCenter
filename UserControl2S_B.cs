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
    public partial class UserControl2S_B : UserControl
    {
        public UserControl2S_B()
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
            labelGradesReport.ForeColor = ThemeColor.PrimaryColor;
        }
        
        private void displayData(string username,string subjectname = "", string Teacher = "", string Grade = "")
        {
            DataTable dt_Exams = Controller.Instance.Student_getGradesReport(username,subjectname, Teacher, Grade);
            dataGridViewGradesReport.DataSource = dt_Exams.DefaultView;
           
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
            displayData(Form0.Instance.username, comboBoxSubject.Text,comboBoxTeacher.Text);
            comboBoxSubject.Text = "";
            comboBoxTeacher.Text = "";
        }
    }
}
