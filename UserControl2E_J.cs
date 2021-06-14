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
    public partial class UserControl2E_J : UserControl
    {
        UserControl1E userControl1E;
        public UserControl2E_J(UserControl1E userControl1E,string TID)
        {
            this.userControl1E = userControl1E;
            InitializeComponent();
            LoadTheme();
            DataTable dt = Controller.Instance.getTeacherAssistants(TID);
            dataGridViewTA.DataSource = dt.DefaultView;
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
            labelTA.ForeColor = ThemeColor.PrimaryColor;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            userControl1E.OpenChildForm(new UserControl2E_E(userControl1E));
        }
    }
}
