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
    public partial class UserControlChangePass : UserControl
    {
        private static UserControlChangePass _instance;
        public static UserControlChangePass Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlChangePass();
                return _instance;
            }
        }
        private UserControlChangePass()
        {
            InitializeComponent();
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxOldPass.Text)
                || String.IsNullOrEmpty(textBoxNewPass.Text) || String.IsNullOrEmpty(textBoxConfirmNewPass.Text))
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                if(textBoxNewPass.Text != textBoxConfirmNewPass.Text)
                {
                    MessageBox.Show("The new password does not match!");
                }
                else
                {
                    if (Controller.Instance.changePassword(textBoxUsername.Text, textBoxOldPass.Text, textBoxNewPass.Text))
                    {
                        MessageBox.Show("Password changed successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password!");
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControlLogin.Instance);
        }
    }
}
