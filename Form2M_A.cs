using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EducationalCenter
{
    public partial class Form2M_A : Form
    {
        Controller controllerObj;
        public Form2M_A()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void labelRoom_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int result = controllerObj.InsertEmployee(textBoxName.Text, textBoxPhoneNumber.Text, textBoxSalary.Text,textBoxAddress.Text ,textBoxNID.Text);
            if (result == 0)
            {
                MessageBox.Show("The insertion is failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdateEmployee(textBoxName.Text, textBoxPhoneNumber.Text, textBoxSalary.Text,textBoxAddress.Text ,textBoxNID.Text);
            if (result == 0)
            {
                MessageBox.Show("Update failed");
            }
            else
            {
                MessageBox.Show("The row is Updated successfully!");
            }
        }
       
    }
}
