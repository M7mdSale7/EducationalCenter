using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace EducationalCenter
{
    public partial class Form2 : Form
    {
        Controller controllerObj;
        public Form2(UserControl userControl)
        {
            InitializeComponent(userControl);
            controllerObj = Controller.Instance;
        }
    }
}
