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
    public partial class UserControl2T_F : UserControl
    {
        public UserControl2T_F()
        {
            InitializeComponent();
            DataTable dt = Controller.Instance.getTeacherAssistants(Controller.Instance.getTeacherID(Form0.Instance.username));
            dataGridViewTeacherAssistants.DataSource = dt.DefaultView;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Controller.Instance.insertTeacherAssistant(textBoxName.Text, Convert.ToInt32(textBoxID.Text), 
                                                       Convert.ToInt32(textBoxPhoneNumber.Text), Controller.Instance.getTeacherID(Form0.Instance.username));

            DataTable dt = Controller.Instance.getTeacherAssistants(Controller.Instance.getTeacherID(Form0.Instance.username));
            dataGridViewTeacherAssistants.DataSource = dt.DefaultView;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1T());
        }

        private void dataGridViewTeacherAssistants_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Teaching Assistant", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controller.Instance.deleteTeachingAssistant(Convert.ToInt32(dataGridViewTeacherAssistants.Rows[e.RowIndex].Cells[1].Value), Controller.Instance.getTeacherID(Form0.Instance.username));
                    dataGridViewTeacherAssistants.Rows.RemoveAt(e.RowIndex);
                }

            }
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControlLogin());
        }
    }
}
