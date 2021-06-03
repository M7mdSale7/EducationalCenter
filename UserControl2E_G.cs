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
    public partial class UserControl2E_G : UserControl
    {
        public UserControl2E_G()
        {
            InitializeComponent();
            displayData();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            numericUpDownYear.Value = 0;
            numericUpDownPrice.Value = 0;
            comboBoxTeacher.SelectedIndex = -1;
            comboBoxSubject.SelectedIndex = -1;
            comboBoxTeacher.SelectedIndex = -1;
            comboBoxTeacher.Text = "";
            comboBoxSubject.Text = "";
            comboBoxTeacher.Text = "";
        }

        private void displayData(string subject = "", string teacher = "", int year = 0, int roomNum = 0, decimal price = 0)
        {
            DataTable dt = Controller.Instance.getAllExams( subject, teacher, year, roomNum, price);
            dataGridViewExams.DataSource = dt.DefaultView;
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
            price = numericUpDownPrice.Value;
            year = Convert.ToInt32(numericUpDownYear.Value);
            displayData(subject, teacher, year, roomNum, price);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1E());
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
