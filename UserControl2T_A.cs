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
    public partial class UserControl2T_A : UserControl
    {
        private static UserControl2T_A _instance;
        public static UserControl2T_A Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl2T_A();
                return _instance;
            }
        }
        public UserControl2T_A()
        {
            InitializeComponent();
            DataTable dt = Controller.Instance.getTeacherSchedule(123456789);
            dataGridViewTeacherSchedule.DataSource = dt.DefaultView;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControl1T.Instance);
        }
    }
}
