using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EducationalCenter
{
    public partial class Form1E : Form
    {
        public Form1E()
        {
            InitializeComponent();
        }

        private void buttonBookLessons_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2E_A();
            Form FormBookLessons = new Form2E(usercontrol);
            FormBookLessons.Show();
        }

        private void buttonBookRooms_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = new UserControl2E_B();
            Form FormBookRooms = new Form2E(usercontrol);
            FormBookRooms.Show();
        }
    }
}
