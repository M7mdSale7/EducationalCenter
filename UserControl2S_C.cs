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
    public partial class UserControl2S_C : UserControl
    {
       public UserControl2S_C()
        {
            InitializeComponent();
            comboBoxSubject.Items.AddRange(Controller.Instance.getAvaliableSubjects(Form0.Instance.username));
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1S(Form0.Instance.username));
        }
        private void displayData(string username, string subjectname = "", string Teacher = "")
        {
            DataTable dt_Lessons = Controller.Instance.Student_getAvaliableLessons(username, subjectname, Teacher);
            dataGridViewAvailableLessons.DataSource = dt_Lessons.DefaultView;
        }
        private void buttonGet_Click(object sender, EventArgs e)
        {
            displayData(Form0.Instance.username, comboBoxSubject.Text,comboBoxTeacher.Text);
            comboBoxSubject.Text = "";
            comboBoxTeacher.Text = "";
        }
        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTeacher.Items.Clear();
            comboBoxTeacher.Items.AddRange(Controller.Instance.getAvaliableSubjects_Teachers(Form0.Instance.username,comboBoxSubject.Text));
        }
    }
}
