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
    public partial class UserControl2E_A : UserControl
    {
        public UserControl2E_A()
        {
            InitializeComponent();
            displayData();
            comboBoxStudentID.Items.Add("");
            comboBoxStudentID.Items.AddRange(Controller.Instance.getAllStudentID());
        }
        private void displayData()
        {
            DataTable dt = Controller.Instance.getAllAttends();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBoxStudentID.Text)|| String.IsNullOrWhiteSpace(comboBoxSubject.Text)
                || String.IsNullOrWhiteSpace(comboBoxTeacher.Text)|| String.IsNullOrWhiteSpace(comboBoxSlot.Text)
                || String.IsNullOrWhiteSpace(comboBoxType.Text))
            {
                MessageBox.Show("Please fill all necessary fields");
            }
            else
            {
                int subjectID = Controller.Instance.getSubjectID(comboBoxSubject.Text, comboBoxTeacher.Text);
                int reservation_number = Controller.Instance.getReservation_number(subjectID, comboBoxType.Text, comboBoxSlot.Text);
                if (Controller.Instance.insertAttend(Convert.ToInt32(comboBoxStudentID.Text),reservation_number))
                {
                    MessageBox.Show("Attend added successfully!");
                    displayData();
                }
                else
                    MessageBox.Show("Error!!");
            }
        }

        private void comboBoxStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubject.Text = "";
            comboBoxSubject.Items.Clear();
            comboBoxSubject.Items.AddRange(Controller.Instance.getSubject_by_SID(Convert.ToInt32(comboBoxStudentID.Text)));
        }
        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTeacher.Text = "";
            comboBoxTeacher.Items.Clear();
            comboBoxTeacher.Items.AddRange(Controller.Instance.getTeacher_by_SID(Convert.ToInt32(comboBoxStudentID.Text),comboBoxSubject.Text));
        }
        private void comboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxType.Text = "";
            comboBoxType.Items.Clear();
            comboBoxType.Items.Add("subject");
            comboBoxType.Items.Add("Exam");
        }
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSlot.Text = "";
            comboBoxSlot.Items.Clear();
            comboBoxSlot.Items.AddRange(Controller.Instance.getSlots(Convert.ToInt32(comboBoxStudentID.Text), comboBoxSubject.Text,comboBoxTeacher.Text,comboBoxType.Text));
        }
        private void buttonPrice_Click(object sender, EventArgs e)
        {
            int subjectID = Controller.Instance.getSubjectID(comboBoxSubject.Text, comboBoxTeacher.Text);
            string price = Controller.Instance.getPrice(subjectID, comboBoxType.Text, comboBoxSlot.Text);
            MessageBox.Show(price);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1E(Form0.Instance.username));
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Attend", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controller.Instance.deleteAttend(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value), Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                    displayData();
                }

            }
        }
    }
}
