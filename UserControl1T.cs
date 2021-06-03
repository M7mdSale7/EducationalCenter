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
    public partial class UserControl1T : UserControl
    {
        private static UserControl1T _instance;
        public static UserControl1T Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl1T();
                return _instance;
            }
        }
        public UserControl1T()
        {
            InitializeComponent();
        }

        private void buttonViewSchedule_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControl2T_A.Instance);
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControl2T_B.Instance);
        }

        private void buttonGradesReport_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControl2T_D.Instance);
        }

        private void buttonExams_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControl2T_E.Instance);
        }

        private void buttonTeachingAssistants_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControl2T_F.Instance);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControlLogin.Instance);
        }
    }
}
