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
    public partial class UserControl2E_C : UserControl
    {
        public UserControl2E_C()
        {
            InitializeComponent();
            displayData();
            comboBoxSubject.Items.Add("");
            comboBoxSubject.Items.AddRange(Controller.Instance.getAllSubjectsname());
            comboBoxTeacher.Items.Add("");
            comboBoxTeacher.Items.AddRange(Controller.Instance.getAllTeahcersname());
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text) )
            {
                MessageBox.Show("Please fill all necessary fields");
            }
            else
            {
                Controller.Instance.insertStudent(textBoxName.Text, Convert.ToInt32(numericUpDownStudyYear.Value), textBoxPhoneNumber.Text);
                MessageBox.Show("user added successfully!");
                displayData();
            }
            comboBoxTeacher.Items.Clear();
            comboBoxTeacher.Items.Add("");
            comboBoxTeacher.Items.AddRange(Controller.Instance.getAllTeahcersname());
            comboBoxSubject.Items.Add("");
            comboBoxSubject.Items.Clear();
            comboBoxSubject.Items.AddRange(Controller.Instance.getAllSubjectsname(""));
        }
        private void displayData(int grade=0, string subjectname="", string teachername="")
        {
            DataTable dt_Lessons = Controller.Instance.getAllStudents(grade, subjectname, teachername);
            dataGridViewStudents.DataSource = dt_Lessons.DefaultView;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1E());
        }
        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTeacher.Items.Clear();
            comboBoxTeacher.Items.Add("");
            comboBoxTeacher.Items.AddRange(Controller.Instance.getAllTeahcersname(comboBoxSubject.Text));
        }

        private void comboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubject.Items.Add("");
            comboBoxSubject.Items.Clear();
            comboBoxSubject.Items.AddRange(Controller.Instance.getAllSubjectsname(comboBoxTeacher.Text));
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            displayData(Convert.ToInt32(numericUpDownYearFilter.Value), comboBoxSubject.Text, comboBoxTeacher.Text);
            comboBoxSubject.Text = "";
            comboBoxTeacher.Text = "";
        }
    }
}
