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
        public UserControl2T_A()
        {
            InitializeComponent();
            LoadTheme();
            DataTable dt = Controller.Instance.getTeacherSchedule(Controller.Instance.getTeacherID(Form0.Instance.username));
            dataGridViewTeacherSchedule.DataSource = dt.DefaultView;
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
            labelSchedule.ForeColor = ThemeColor.PrimaryColor;
        }
    }
}
