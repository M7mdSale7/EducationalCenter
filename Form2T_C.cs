using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EducationalCenter
{
    public partial class Form2T_C : Form
    {
        public Form2T_C()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            /*int result = controllerObj.InsertTA(textBoxName.Text , textBoxPhoneNumber.Text , textBoxID.Text );
            if (result == 0)
            {
                MessageBox.Show("The insertion is failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }*/
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            /*int result = controllerObj.UpdateTA(textBoxName.Text , textBoxPhoneNumber.Text , textBoxID.Text );
            if (result == 0)
            {
                MessageBox.Show("Update failed");
            }
            else
            {
                MessageBox.Show("The row is Updated successfully!");
            }*/
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
