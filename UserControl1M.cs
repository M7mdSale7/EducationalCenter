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
        private static UserControl1M _instance;
        public static UserControl1M Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl1M();
                return _instance;
            }
        }
        //using singelton pattern
        string username;

        private UserControl1M()
        {
            InitializeComponent();
            //labelWelcome.Text += " " + username;
        }

        public void setUsername(string username)
        {
            this.username = username;
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
            Form0.Instance.username = "";
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControlLogin.Instance);
        }
    }
}
