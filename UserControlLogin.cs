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
    public partial class UserControlLogin : UserControl
    {
        private static UserControlLogin _instance;
        public static UserControlLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlLogin();
                return _instance;
            }
        }
        private UserControlLogin()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Please enter a username and a password");
            }
            else
            {
                
                string type = Controller.Instance.checkUserPassword(textBoxUser.Text, textBoxPass.Text);
                if (type == "manager")
                {
                    Form0.Instance.Controls.Clear();
                    Form0.Instance.Controls.Add(UserControl1M.Instance);
                    UserControl1M.Instance.setUsername(textBoxUser.Text);
                }
                else if (type == "employee")
                {
                    Form0.Instance.username = textBoxUser.Text;
                    Form0.Instance.Controls.Clear();
                    Form0.Instance.Controls.Add(new UserControl1E(Form0.Instance.username));
                }
                else if (type == "teacher")
                {

                }
                else if (type == "TA")
                {

                }
                else if (type == "student" || type == "parent")
                {
                    Form0.Instance.username = textBoxUser.Text;
                    Form0.Instance.Controls.Clear();
                    Form0.Instance.Controls.Add(new UserControl1S(Form0.Instance.username));
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
        }
    }
}
