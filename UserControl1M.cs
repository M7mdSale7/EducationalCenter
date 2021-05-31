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
    public partial class UserControl1M : UserControl
    {
        //using singelton pattern
        string username;

        public UserControl1M(string username)
        {
            InitializeComponent();
            this.username = username;
            //labelWelcome.Text += " " + username;
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl2M_A());
        }

        private void buttonAccounts_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl2M_B(username));
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControlLogin());
        }
    }
}
