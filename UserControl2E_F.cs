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
    public partial class UserControl2E_F : UserControl
    {
        public UserControl2E_F()
        {
            InitializeComponent();
            displayData();
            comboBoxTeacher.Items.AddRange(Controller.Instance.getAllTeachersID());
            comboBoxFilterSubject.Items.Add("");
            comboBoxFilterSubject.Items.AddRange(Controller.Instance.getAllSubjectsname());
            comboBoxFilterTeacher.Items.Add("");
            comboBoxFilterTeacher.Items.AddRange(Controller.Instance.getAllTeachersname());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1E(Form0.Instance.username));
        }
        private void displayData(string teacher = "", int year = 0,string subject="")
        {
            DataTable dt = Controller.Instance.getAllSubjects(teacher,year,subject);
            dataGridViewSubjects.DataSource = dt.DefaultView;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text) || comboBoxTeacher.SelectedIndex==-1)
            {
                MessageBox.Show("Please fill all necessary fields");
            }
            else
            {
                if (Controller.Instance.insertSubject(textBoxName.Text, Convert.ToInt32(numericUpDownYear.Value), comboBoxTeacher.Text))
                {
                    MessageBox.Show("Subject added successfully!");
                    displayData();
                }
                else
                    MessageBox.Show("Error!!");
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            displayData(comboBoxFilterTeacher.Text,Convert.ToInt32(numericUpDownFilterYear.Value),comboBoxFilterSubject.Text);
            comboBoxFilterSubject.Text = "";
            comboBoxFilterTeacher.Text = "";
        }

        private void dataGridViewSubjects_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Subject", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controller.Instance.deleteSubject(dataGridViewSubjects.Rows[e.RowIndex].Cells[0].Value.ToString());
                    displayData();
                }

            }
        }
    }
}
