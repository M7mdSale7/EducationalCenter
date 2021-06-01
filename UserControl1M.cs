﻿ using System;
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

        private UserControl1M()
        {
            InitializeComponent();
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(new UserControl2M_A());
        }

        private void buttonAccounts_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControl2M_B.Instance);
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Form0.Instance.Controls.Clear();
            Form0.Instance.Controls.Add(UserControlLogin.Instance);
        }
    }
}
