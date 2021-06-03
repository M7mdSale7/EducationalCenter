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
    public partial class UserControl2T_D : UserControl
    {
        private static UserControl2T_D _instance;
        public static UserControl2T_D Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl2T_D();
                return _instance;
            }
        }
        public UserControl2T_D()
        {
            InitializeComponent();
            DataTable dt = Controller.Instance.getTeacherGradesReport(12345678);
            dataGridViewTeacherGradesReport.DataSource = dt.DefaultView;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxStudentID.Text == "" || textBoxExamID.Text == "")
            {
                MessageBox.Show("Invalid input.");
                return;
            }

            Controller.Instance.insertTeacherGradeReport(12345678, Convert.ToInt32(textBoxStudentID.Text),
                                                            Convert.ToInt32(textBoxExamID.Text), textBoxGrade.Text);
            DataTable dt = Controller.Instance.getTeacherGradesReport(12345678);
            dataGridViewTeacherGradesReport.DataSource = dt.DefaultView;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControl1T.Instance);
        }

        private void dataGridViewTeacherGradesReport_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Grade Report", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controller.Instance.deleteGradeReport(Convert.ToInt32(dataGridViewTeacherGradesReport.Rows[e.RowIndex].Cells[0].Value),Convert.ToInt32(dataGridViewTeacherGradesReport.Rows[e.RowIndex].Cells[4].Value));
                    dataGridViewTeacherGradesReport.Rows.RemoveAt(e.RowIndex);
                }

            }
        }
    }
}
