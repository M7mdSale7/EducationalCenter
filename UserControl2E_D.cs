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
            LoadTheme();
            displayData();
            comboBoxStudentID.Items.AddRange(Controller.Instance.getAllStudentID());
            comboBoxFilterStudentID.Items.Add("");
            comboBoxFilterStudentID.Items.AddRange(Controller.Instance.getAllStudentID());
            comboBoxFilterName.Items.Add("");
            comboBoxFilterName.Items.AddRange(Controller.Instance.getAllParentsname());
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
            labelParents.ForeColor = ThemeColor.PrimaryColor;
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please fill all necessary fields");
            }
            else
            {
                if (Controller.Instance.insertParent(textBoxName.Text, Convert.ToInt32(comboBoxStudentID.Text), textBoxPhoneNumber.Text))
                {
                    MessageBox.Show("Parent added successfully!");
                    displayData();
                }
                else
                    MessageBox.Show("Error!!");
            }
            comboBoxFilterStudentID.Items.Clear();
            comboBoxFilterStudentID.Items.Add("");
            comboBoxFilterStudentID.Items.AddRange(Controller.Instance.getAllStudentID());
            comboBoxFilterName.Items.Clear();
            comboBoxFilterName.Items.Add("");
            comboBoxFilterName.Items.AddRange(Controller.Instance.getAllParentsname());
        }
        private void displayData(string parentname = "", string studentID = "")
        {
            DataTable dt = Controller.Instance.getAllParents(parentname, studentID);
            dataGridViewParents.DataSource = dt.DefaultView;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            displayData(comboBoxFilterName.Text, comboBoxFilterStudentID.Text);
            comboBoxFilterName.Text = "";
            comboBoxFilterStudentID.Text = "";
        }

        private void dataGridViewParents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Parent", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controller.Instance.deleteParent(dataGridViewParents.Rows[e.RowIndex].Cells[0].Value.ToString(),dataGridViewParents.Rows[e.RowIndex].Cells[2].Value.ToString());
                    displayData();
                }

            }
        }
    }
}
