using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EducationalCenter
{
    public partial class Form0 : Form
    {
        public string username, type, TA;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //end of singelton pattern code
        private Form0() //make this private
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ControlBox = false;
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Controls.Add(new UserControl1());

        }

        public void Release()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
    }
}
