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
    public partial class UserControl2T_E : UserControl
    {
        public UserControl2T_E()
        {
            InitializeComponent();
            LoadTheme();
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
            labelTA.ForeColor = ThemeColor.PrimaryColor;
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

    }
}
