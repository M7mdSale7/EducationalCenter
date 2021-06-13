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

        public UserControlChangePass()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            labelNewPass.ForeColor = ThemeColor.PrimaryColor;
            labelOldPass.ForeColor = ThemeColor.PrimaryColor;
            labelUsername.ForeColor = ThemeColor.PrimaryColor;
            labelCNewPass.ForeColor = ThemeColor.PrimaryColor;
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
    }
}
