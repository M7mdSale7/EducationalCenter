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
    public partial class UserControl2M_B : UserControl
    {
        private static UserControl2M_B _instance;
        public static UserControl2M_B Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl2M_B();
                return _instance;
            }
        }
        private UserControl2M_B()
        {
            InitializeComponent();
            displayData();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxType.Text == "manager")
            {
                //nothing to be done
            }
            else if(comboBoxType.Text == "employee")
            {

                comboBoxUsers.Items.Clear();
                comboBoxUsers.Items.AddRange(Controller.Instance.getNonUserEmployees());
            }
            else if (comboBoxType.Text == "teacher")
            {
                comboBoxUsers.Items.Clear();
                comboBoxUsers.Items.AddRange(Controller.Instance.getNonUserTeachers());
            }
            else if (comboBoxType.Text == "TA")
            {
                comboBoxUsers.Items.Clear();
                comboBoxUsers.Items.AddRange(Controller.Instance.getNonUserTAs());
            }
            else if (comboBoxType.Text == "student")
            {
                comboBoxUsers.Items.Clear();
                comboBoxUsers.Items.AddRange(Controller.Instance.getNonUserStudents());
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1M());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearInputs();
        }

        private void clearInputs()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxNewPassword.Text = "";
            comboBoxUsers.Text = "";
            comboBoxType.Text = "";
            comboBoxUsers.SelectedIndex = -1;
            comboBoxType.SelectedIndex = -1;
        }
        private void displayData(string username = "", string password = "", string usertype = "")
        {
            DataTable dt = Controller.Instance.getAllAccounts(username, password, usertype);
            dataGridViewUsers.DataSource = dt.DefaultView;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(textBoxUsername.Text) || String.IsNullOrWhiteSpace(textBoxPassword.Text) || String.IsNullOrWhiteSpace(textBoxNewPassword.Text))
            {
                MessageBox.Show("Please enter a username, old password, and a new password");
            }
            else
            {
                if(Controller.Instance.checkUserPassword(textBoxUsername.Text, textBoxPassword.Text) == "")
                {
                    MessageBox.Show("Incorrect username or password");
                }
                else if(Controller.Instance.changePassword(textBoxUsername.Text, textBoxPassword.Text, textBoxNewPassword.Text))
                {
                    MessageBox.Show("Password successfully updated");
                    clearInputs();
                    displayData();
                }
            }

        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string username = "", password = "", usertype = "";
            if(!String.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                username = textBoxUsername.Text;
            }

            if(!String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                password = textBoxPassword.Text;
            }

            if(!String.IsNullOrWhiteSpace(comboBoxType.Text))
            {
                usertype = comboBoxType.Text;
            }
            displayData(username, password, usertype);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if(comboBoxType.SelectedItem != null && comboBoxUsers.SelectedItem != null)
            {
                if (String.IsNullOrWhiteSpace(textBoxUsername.Text) || String.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                String.IsNullOrWhiteSpace(comboBoxType.SelectedItem.ToString()) || String.IsNullOrWhiteSpace(comboBoxUsers.SelectedItem.ToString()))
                {
                    MessageBox.Show("Please fill all necessary fields");
                }
                else
                {
                    if (comboBoxType.SelectedItem.ToString() == "employee")
                    {
                        Controller.Instance.insertEmployeUser(comboBoxUsers.SelectedItem.ToString(), textBoxUsername.Text, textBoxPassword.Text);
                    }
                    else if (comboBoxType.SelectedItem.ToString() == "teacher")
                    {
                        Controller.Instance.insertTeacherUser(comboBoxUsers.SelectedItem.ToString(), textBoxUsername.Text, textBoxPassword.Text);
                    }
                    else if (comboBoxType.SelectedItem.ToString() == "TA")
                    {
                        Controller.Instance.insertTAUser(comboBoxUsers.SelectedItem.ToString(), textBoxUsername.Text, textBoxPassword.Text);
                    }
                    else if (comboBoxType.SelectedItem.ToString() == "student")
                    {
                        Controller.Instance.insertStudentUser(Convert.ToInt32(comboBoxUsers.SelectedItem), textBoxUsername.Text, textBoxPassword.Text);
                    }
                    MessageBox.Show("user added successfully!");
                    displayData();
                    clearInputs();
                }
            }
            else
            {
                MessageBox.Show("Please fill all necessary fields");
            }
            
        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete User", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controller.Instance.deleteUser(dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString());
                    dataGridViewUsers.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
