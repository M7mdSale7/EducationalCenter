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
    public partial class Form0 : Form
    {
        public string username, type;
        //start of singelton pattern code
        private static Form0 _instance;
        public static Form0 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form0();
                return _instance;
            }
        }
        //end of singelton pattern code
        private Form0() //make this private
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Controls.Add(new UserControlLogin());
        }
    }
}
