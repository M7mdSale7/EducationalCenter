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
    public partial class UserControl1E : UserControl
    {
        private static UserControl1E _instance;
        public static UserControl1E Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl1E();
                return _instance;
            }
        }
        private UserControl1E()
        {
            InitializeComponent();
        }
    }
}
