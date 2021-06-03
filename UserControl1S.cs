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
    public partial class UserControl1S : UserControl
    {
        
        string username;
        public UserControl1S(string username)
        {
            InitializeComponent(); 
            this.username = username;
        }

        private void buttonViewSchedule_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl2S_A());
        }

        private void buttonGradesReport_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl2S_B());
        }

        private void buttonAvailableLessons_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl2S_C());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form0.Instance.username = "";
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControlLogin.Instance);
        }
    }
}
