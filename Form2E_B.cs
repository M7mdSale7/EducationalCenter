using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EducationalCenter
{
    public partial class Form2E_B : Form
    {
        Controller controllerObj;
        public Form2E_B()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int result = controllerObj.InsertBookRoom(textBoxTeacher.Text, textBoxSubject.Text, textBox_Room.Text, textBox_DateAndTime.Text,comboBoxType.Text);
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
            int result = controllerObj.UpdateBookRoom(textBoxTeacher.Text, textBoxSubject.Text, textBox_Room.Text, textBox_DateAndTime.Text,comboBoxType.Text , textBox_OldRoom.Text , textBoxOldDateTime.Text);
            if (result == 0)
            {
                MessageBox.Show("Update failed");
            }
            else
            {
                MessageBox.Show("The row is updated successfully!");
            }
        }
      
    }
}
