using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EducationalCenter
{
    public partial class Form2T_E : Form
    {
        public Form2T_E()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            /*int result = controllerObj.InsertGrade(textBoxStudentID.Text , textBoxExamID.Text , textBoxGrade.Text);
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
            /*int result = controllerObj.UpdateGrade(textBoxStudentID.Text , textBoxExamID.Text , textBoxGrade.Text);
            if (result == 0)
            {
                MessageBox.Show("Update failed");
            }
            else
            {
                MessageBox.Show("The row is Updated successfully!");
            }*/
        }

        private void textBoxGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_ExamID_Click(object sender, EventArgs e)
        {

        }

        private void label_Grade_Click(object sender, EventArgs e)
        {

        }

        private void textBoxExamID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
