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
    public partial class UserControl2E_D : UserControl
    {
        public UserControl2E_D()
        {
            InitializeComponent();
            displayData();
            comboBoxStudentID.Items.AddRange(Controller.Instance.getAllStudentID());
            comboBoxFilterStudentID.Items.Add("");
            comboBoxFilterStudentID.Items.AddRange(Controller.Instance.getAllStudentID());
            comboBoxFilterName.Items.Add("");
            comboBoxFilterName.Items.AddRange(Controller.Instance.getAllParentsname());
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please fill all necessary fields");
            }
            else
            {
                Controller.Instance.insertParent(textBoxName.Text, Convert.ToInt32(comboBoxStudentID.Text), textBoxPhoneNumber.Text);
                MessageBox.Show("user added successfully!");
                displayData();
            }
            comboBoxFilterName.Items.Clear();
            comboBoxFilterStudentID.Items.Add("");
            comboBoxFilterStudentID.Items.AddRange(Controller.Instance.getAllStudentID());
            comboBoxFilterStudentID.Items.Clear();
            comboBoxFilterName.Items.Add("");
            comboBoxFilterName.Items.AddRange(Controller.Instance.getAllParentsname());
        }
        private void displayData(string parentname = "", string studentID = "")
        {
            DataTable dt_Lessons = Controller.Instance.getAllParents(parentname, studentID);
            dataGridViewParents.DataSource = dt_Lessons.DefaultView;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1E());
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            displayData(comboBoxFilterName.Text, comboBoxFilterStudentID.Text);
            comboBoxFilterName.Text = "";
            comboBoxFilterStudentID.Text = "";
        }
    }
}
