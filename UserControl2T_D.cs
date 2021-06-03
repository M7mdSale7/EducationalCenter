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
        public UserControl2T_D()
        {
            InitializeComponent();
            DataTable dt = Controller.Instance.getTeacherGradesReport(Controller.Instance.getTeacherID(Form0.Instance.username));
            dataGridViewTeacherGradesReport.DataSource = dt.DefaultView;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxStudentID.Text == "" || textBoxExamID.Text == "")
            {
                MessageBox.Show("Invalid input.");
                return;
            }

            Controller.Instance.insertTeacherGradeReport(Controller.Instance.getTeacherID(Form0.Instance.username), Convert.ToInt32(textBoxStudentID.Text),
                                                            Convert.ToInt32(textBoxExamID.Text), textBoxGrade.Text);
            DataTable dt = Controller.Instance.getTeacherGradesReport(Controller.Instance.getTeacherID(Form0.Instance.username));
            dataGridViewTeacherGradesReport.DataSource = dt.DefaultView;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl1T());
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
