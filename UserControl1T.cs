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
    public partial class UserControl1T : UserControl
    {
        public UserControl1T()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form0.Instance.username = "";
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControlLogin());

        }
    }
}
