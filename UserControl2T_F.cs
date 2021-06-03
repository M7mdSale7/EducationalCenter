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
        private static UserControl2T_F _instance;
        public static UserControl2T_F Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl2T_F();
                return _instance;
            }
        }

        public UserControl2T_F()
        {
            InitializeComponent();
            DataTable dt = Controller.Instance.getTeacherAssistants(123456789);
            dataGridViewTeacherAssistants.DataSource = dt.DefaultView;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Controller.Instance.insertTeacherAssistant(textBoxName.Text, Convert.ToInt32(textBoxID.Text), 
                                                       Convert.ToInt32(textBoxPhoneNumber.Text), 123456789);

            DataTable dt = Controller.Instance.getTeacherAssistants(123456789);
            dataGridViewTeacherAssistants.DataSource = dt.DefaultView;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControl1T.Instance);
        }

        private void dataGridViewTeacherAssistants_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Teaching Assistant", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controller.Instance.deleteTeachingAssistant(Convert.ToInt32(dataGridViewTeacherAssistants.Rows[e.RowIndex].Cells[1].Value),123456789);
                    dataGridViewTeacherAssistants.Rows.RemoveAt(e.RowIndex);
                }

            }
        }
    }
}
