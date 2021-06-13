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
            LoadTheme();
            displayData();
            comboBoxSubject.Items.Add("");
            comboBoxSubject.Items.AddRange(Controller.Instance.getAllSubjectsname());
            comboBoxTeacher.Items.Add("");
            comboBoxTeacher.Items.AddRange(Controller.Instance.getAllTeachersname());
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
            labelStudents.ForeColor = ThemeColor.PrimaryColor;
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text) )
            {
                MessageBox.Show("Please fill all necessary fields");
            }
            else
            {
                if(Controller.Instance.insertStudent(textBoxName.Text, Convert.ToInt32(numericUpDownStudyYear.Value), textBoxPhoneNumber.Text))
                {
                    MessageBox.Show("Student added successfully!");
                    displayData();
                }
                else
                    MessageBox.Show("Error!!");
            }
            comboBoxTeacher.Items.Clear();
            comboBoxTeacher.Items.Add("");
            comboBoxTeacher.Items.AddRange(Controller.Instance.getAllTeachersname());
            comboBoxSubject.Items.Add("");
            comboBoxSubject.Items.Clear();
            comboBoxSubject.Items.AddRange(Controller.Instance.getAllSubjectsname());
        }
        private void displayData(int grade=0, string subjectname="", string teachername="")
        {
            DataTable dt = Controller.Instance.getAllStudents(grade, subjectname, teachername);
            dataGridViewStudents.DataSource = dt.DefaultView;
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTeacher.Items.Clear();
            comboBoxTeacher.Items.Add("");
            comboBoxTeacher.Items.AddRange(Controller.Instance.getAllTeachersname(comboBoxSubject.Text));
        }

        private void comboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubject.Items.Clear();
            comboBoxSubject.Items.Add("");
            comboBoxSubject.Items.AddRange(Controller.Instance.getAllSubjectsname(0,comboBoxTeacher.Text));
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            displayData(Convert.ToInt32(numericUpDownYearFilter.Value), comboBoxSubject.Text, comboBoxTeacher.Text);
            comboBoxSubject.Text = "";
            comboBoxTeacher.Text = "";
        }

        private void dataGridViewStudents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Student", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controller.Instance.deleteStudent(dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString());
                    displayData();
                }

            }
        }
    }
}
