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
    public partial class Form2E : Form
    {
        Controller controllerObj;
        public Form2E(UserControl userControl)
        {
            InitializeComponent(userControl);
            controllerObj = new Controller();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            /*int result = controllerObj.InsertBookLesson(textBoxStudentID.Text, textBoxSubject.Text, textBoxTeacher.Text,comboBoxSlot.Text);
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
            /*int result = controllerObj.UpdateBookLesson(textBoxStudentID.Text, textBoxSubject.Text, textBoxTeacher.Text,comboBoxSlot.Text,textBoxOldSlot.Text);
            if (result == 0)
            {
                MessageBox.Show(" Update failed");
            }
            else
            {
                MessageBox.Show("The row is Updated successfully!");
            }*/
        }

        

       
    }
}
