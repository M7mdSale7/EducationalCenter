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
        public UserControlLogin()
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

                    this.Controls.Clear();
                    this.Controls.Add(new UserControl1M(textBoxUser.Text));
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
            }
        }
    }
}
