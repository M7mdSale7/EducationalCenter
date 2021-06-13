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
            LoadTheme();
            comboBoxSubject.Items.AddRange(Controller.Instance.getAvaliableSubjects(Form0.Instance.username));
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
            labelAvailableLessons.ForeColor = ThemeColor.PrimaryColor;
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
