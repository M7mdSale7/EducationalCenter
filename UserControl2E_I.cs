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
    public partial class UserControl2E_I : UserControl
    {
        public UserControl2E_I()
        {
            InitializeComponent();
            displayData();
            comboBoxStudentID.Items.AddRange(Controller.Instance.getAllStudentID());
            comboBoxFilterStudentID.Items.Add("");
            comboBoxFilterStudentID.Items.AddRange(Controller.Instance.getAllStudentID());
            comboBoxFilterTeacher.Items.Add("");
            comboBoxFilterTeacher.Items.AddRange(Controller.Instance.getAllTeachersname());
            comboBoxFilterSubject.Items.Add("");
            comboBoxFilterSubject.Items.AddRange(Controller.Instance.getAllSubjectsname());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1E(Form0.Instance.username));
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBoxStudentID.Text)|| String.IsNullOrWhiteSpace(comboBoxSubject.Text)
                || String.IsNullOrWhiteSpace(comboBoxTeacher.Text))
            {
                MessageBox.Show("Please fill all necessary fields");
            }
            else
            {
                int subjectID = Controller.Instance.getSubjectID(comboBoxSubject.Text, comboBoxTeacher.Text);
                if (Controller.Instance.insertStudies(Convert.ToInt32(comboBoxStudentID.Text),subjectID))
                {
                    MessageBox.Show("Studies added successfully!");
                    displayData();
                }
                else
                    MessageBox.Show("Error!!");
            }
            displayData();
            comboBoxStudentID.Text = "";
            comboBoxSubject.Text = "";
            comboBoxTeacher.Text = "";
            comboBoxFilterStudentID.Items.Clear();
            comboBoxFilterStudentID.Items.Add("");
            comboBoxFilterStudentID.Items.AddRange(Controller.Instance.getAllStudentID());
            comboBoxFilterTeacher.Items.Clear();
            comboBoxFilterTeacher.Items.Add("");
            comboBoxFilterTeacher.Items.AddRange(Controller.Instance.getAllTeachersname());
            comboBoxFilterSubject.Items.Clear();
            comboBoxFilterSubject.Items.Add("");
            comboBoxFilterSubject.Items.AddRange(Controller.Instance.getAllSubjectsname());
        }
        private void comboBoxStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int grade = Controller.Instance.getStudentYear(Convert.ToInt32(comboBoxStudentID.Text));
            comboBoxSubject.Items.Clear();
            comboBoxSubject.Items.Add("");
            comboBoxSubject.Items.AddRange(Controller.Instance.getAllSubjectsname(grade));
        }
        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTeacher.Items.Clear();
            comboBoxTeacher.Items.Add("");
            comboBoxTeacher.Items.AddRange(Controller.Instance.getAllTeachersname(comboBoxSubject.Text));
        }
        private void displayData(string ID ="" ,string subject = "", string teacher ="")
        {
            DataTable dt = Controller.Instance.getAllStudies(ID,subject,teacher);
            dataGridViewStudies.DataSource = dt.DefaultView;
        }

        private void dataGridViewStudies_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Studies", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controller.Instance.deleteStudies(Convert.ToInt32(dataGridViewStudies.Rows[e.RowIndex].Cells[0].Value), Convert.ToInt32(dataGridViewStudies.Rows[e.RowIndex].Cells[1].Value));
                    displayData();
                }

            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            displayData(comboBoxFilterStudentID.Text,comboBoxFilterSubject.Text,comboBoxFilterTeacher.Text);
            comboBoxFilterSubject.Text = "";
            comboBoxFilterTeacher.Text = "";
            comboBoxFilterStudentID.Text = "";
        }
    }
}
