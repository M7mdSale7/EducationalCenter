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
    public partial class UserControl2E_E : UserControl
    {
        UserControl1E usercontrol1E;
        public UserControl2E_E(UserControl1E usercontrol1E)
        {
            this.usercontrol1E = usercontrol1E;
            InitializeComponent();
            LoadTheme();
            displayData();
            comboBoxTeacherID.Items.AddRange(Controller.Instance.getAllTeachersID());
            comboBoxSubject.Items.Add("");
            comboBoxSubject.Items.AddRange(Controller.Instance.getAllSubjectsname());
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
            labelTeachers.ForeColor = ThemeColor.PrimaryColor;
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text)|| String.IsNullOrWhiteSpace(textBoxNationalID.Text))
            {
                MessageBox.Show("Please fill all necessary fields");
            }
            else
            {
                if (Controller.Instance.insertTeacher(textBoxName.Text, textBoxNationalID.Text, textBoxPhoneNumber.Text))
                {
                    MessageBox.Show("Teacher added successfully!");
                    displayData();
                }
                else
                    MessageBox.Show("Error!!");
            }
        }
        private void displayData(string subject="") 
        {
            DataTable dt= Controller.Instance.getAllTeachers(subject);
            dataGridViewTeachers.DataSource = dt.DefaultView;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            displayData(comboBoxSubject.Text);
            comboBoxSubject.Text = "";
        }

        private void dataGridViewTeachers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Teacher", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controller.Instance.deleteTeacher(dataGridViewTeachers.Rows[e.RowIndex].Cells[1].Value.ToString());
                    displayData();
                }

            }
        }

        private void buttonTA_Click(object sender, EventArgs e)
        {
            usercontrol1E.OpenChildForm(new UserControl2E_J(usercontrol1E,comboBoxTeacherID.Text));
        }
    }
}
