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
    public partial class UserControl2E_H : UserControl
    {
        public UserControl2E_H()
        {
            InitializeComponent();
            LoadTheme();
            displayData();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            labelRooms.ForeColor = ThemeColor.PrimaryColor;
        }
        public void displayData()
        {
            DataTable dt = Controller.Instance.getRooms();
            dataGridViewRooms.DataSource = dt.DefaultView;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (numericUpDownNumber.Value == 0 || numericUpDownCapacity.Value == 0)
            {
                MessageBox.Show("Please Fill the ID and name fields at least");
            }
            else
            {
                if (Controller.Instance.insertRoom(Convert.ToInt32(numericUpDownNumber.Value), Convert.ToInt32(numericUpDownCapacity.Value)))
                {
                    MessageBox.Show("Room added successfully");
                    displayData();
                }
                else
                {
                    MessageBox.Show("Room already exists");
                }
            }
        }

        private void dataGridViewRooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete room", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controller.Instance.deleteRoom(Convert.ToInt32(dataGridViewRooms.Rows[e.RowIndex].Cells[0].Value));
                    dataGridViewRooms.Rows.RemoveAt(e.RowIndex);
                }

            }
        }
    }
}
