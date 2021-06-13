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
    public partial class UserControl2E_B : UserControl
    {
        public UserControl2E_B()
        {
            InitializeComponent();
            displayData();
            comboBoxTeacher.Items.AddRange(Controller.Instance.getAllTeachersID());
            comboBoxSubject.Items.AddRange(Controller.Instance.getAllSubjectsname());
            comboBoxRoom.Items.AddRange(Controller.Instance.getRoomsNumbers());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string subject = ""; string teacher = ""; int year = 0; int roomNum = 0; decimal price = 0;
            if (comboBoxRoom.SelectedIndex != -1)
            {
                roomNum = Convert.ToInt32(comboBoxRoom.SelectedItem);
            }
            if (comboBoxSubject.SelectedIndex != -1)
            {
                subject = Convert.ToString(comboBoxSubject.SelectedItem);
            }
            if (comboBoxTeacher.SelectedIndex != -1)
            {
                teacher = Convert.ToString(comboBoxTeacher.SelectedItem);
            }
            if (numericUpDownPrice.Value != 0)
                price = numericUpDownPrice.Value;
            if (numericUpDownYear.Value != 0)
                year = Convert.ToInt32(numericUpDownYear.Value);

            displayData(subject, teacher, year, roomNum, price);
        }

        private void displayData(string subject = "", string teacher = "", int year = 0, int roomNum = 0, decimal price = 0)
        {
            DataTable dt = Controller.Instance.getAllLessons(subject, teacher, year, roomNum, price);
            dataGridViewLessons.DataSource = dt.DefaultView;
        }

        private void comboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubject.Items.Clear();
            comboBoxSubject.Items.AddRange(Controller.Instance.getAllSubjectsname(0,Controller.Instance.getTeacherName(Convert.ToString(comboBoxTeacher.SelectedItem))));
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTeacher.Items.Clear();
            comboBoxTeacher.Items.AddRange(Controller.Instance.getAllTeachersID(Convert.ToString(comboBoxSubject.SelectedItem)));
        }

        public void clearData()
        {
            numericUpDownYear.Value = 0;
            numericUpDownPrice.Value = 0;
            comboBoxTeacher.SelectedIndex = -1;
            comboBoxSubject.SelectedIndex = -1;
            comboBoxRoom.SelectedIndex = -1;
            comboBoxTeacher.Text = "";
            comboBoxSubject.Text = "";
            comboBoxRoom.Text = "";
            comboBoxTeacher.Items.Clear();
            comboBoxSubject.Items.Clear();
            comboBoxRoom.Items.Clear();
            comboBoxTeacher.Items.AddRange(Controller.Instance.getAllTeachersID());
            comboBoxSubject.Items.AddRange(Controller.Instance.getAllSubjectsname());
            comboBoxRoom.Items.AddRange(Controller.Instance.getRoomsNumbers());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1E(Form0.Instance.username));
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (numericUpDownYear.Value == 0 || String.IsNullOrWhiteSpace(comboBoxTeacher.Text) || String.IsNullOrWhiteSpace(comboBoxSubject.Text))
            {
                MessageBox.Show("Please Fill the fields of year, teacher and subject at least");
            }
            else
            {
                DateTime start = new DateTime(dateTimePickerDay.Value.Year, dateTimePickerDay.Value.Month, dateTimePickerDay.Value.Day
                                            , dateTimePickerFrom.Value.Hour, dateTimePickerFrom.Value.Minute, dateTimePickerFrom.Value.Second);
                DateTime end = new DateTime(dateTimePickerDay.Value.Year, dateTimePickerDay.Value.Month, dateTimePickerDay.Value.Day
                            , dateTimePickerTo.Value.Hour, dateTimePickerTo.Value.Minute, dateTimePickerTo.Value.Second);
                string subjectName = comboBoxSubject.Text.ToString();
                int studyGrade = Convert.ToInt32(numericUpDownYear.Value);
                string teacherID = comboBoxTeacher.Text.ToString();
                int roomNumber = Convert.ToInt32(numericUpDownYear.Value);
                decimal price = numericUpDownPrice.Value;
                string type = "subject";
                if (Controller.Instance.insertReservation(subjectName, studyGrade, teacherID, start, end, roomNumber, price, type))
                {
                    MessageBox.Show("Exam inserted successfully!");
                    clearData();
                    displayData();
                }
                else
                {
                    MessageBox.Show("Check existence of the entered subject with the entered teacher in this year");
                    clearData();
                }

            }
        }

        private void dataGridViewLessons_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Exam", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    DateTime start = Convert.ToDateTime(dataGridViewLessons.Rows[e.RowIndex].Cells[3].Value);
                    DateTime end = Convert.ToDateTime(dataGridViewLessons.Rows[e.RowIndex].Cells[4].Value);

                    int roomNumber = Convert.ToInt32(dataGridViewLessons.Rows[e.RowIndex].Cells[5].Value);

                    Controller.Instance.deleteReservation(start, end, roomNumber);
                }
                displayData();

            }
        }
    }
}
