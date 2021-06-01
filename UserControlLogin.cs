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
                }
                else if (type == "employee")
                {

                }
                else if (type == "teacher")
                {

                }
                else if (type == "TA")
                {

                }
                else if (type == "student" || type == "parent")
                {

                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
                textBoxUser.Text = "";
                textBoxPass.Text = "";
            }
        }

        private void linkLabelChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControlChangePass.Instance);
        }
    }
}
