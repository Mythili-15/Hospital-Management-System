using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using HospitalManagementSystem.Models;

namespace HopitalManagementSystem
{
    public partial class RoomCRUD : UserControl
    {
        public Func<string, string, MessageBoxButtons, MessageBoxIcon, DialogResult> MessageBoxOverride;

        private readonly IDatabaseOps _databaseOps;
        public RoomCRUD(IDatabaseOps databaseOps)
        {
            InitializeComponent();
            _databaseOps = databaseOps;
            display();
        }
        private void ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (MessageBoxOverride != null)
                MessageBoxOverride(text, caption, buttons, icon);
            else
                MessageBox.Show(text, caption, buttons, icon);
        }

        public void buttonRoomInsert_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (textBoxRoomNo.Text.Length != 0 && comboBoxFloorNo.Text.Length != 0)
            {
                Room room = new Room()
                {
                    Room_No = int.Parse(textBoxRoomNo.Text),
                    Room_status = comboBoxStatus.Text,
                    Room_type = comboBoxType.Text,
                    Floor_No = char.Parse(comboBoxFloorNo.Text),
                };
                room.setPricePerDay();
                _databaseOps.insert(room);

                display();
            }
            else
            {
                ShowMessageBox("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void buttonRoomDisplay_Click(object sender, EventArgs e)
        {
            display();
        }

        public void display()
        {

            dataGridView1.DataSource = _databaseOps.display("ROOM");
        }
        public void buttonRoomDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxRoomID.Text))
            {
                _databaseOps.delete("ROOM", textBoxRoomID.Text);
                display();
            }
            else
            {
                ShowMessageBox("Unable to delete Data, Select a row which you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buttonRoomUpdate_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (textBoxRoomNo.Text.Length != 0 && comboBoxFloorNo.Text.Length != 0)
            {
                Room room = new Room()
                {
                    Room_No = int.Parse(textBoxRoomNo.Text),
                    Room_status = comboBoxStatus.Text,
                    Room_type = comboBoxType.Text,
                    Floor_No = char.Parse(comboBoxFloorNo.Text),
                };
                room.setPricePerDay();


                _databaseOps.update(room);

                display();
            }
            else
            {
                ShowMessageBox("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void textBoxSearchValue_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _databaseOps.search(textBoxSearchValue.Text, comboBoxSearchBy.Text);
        }

        public void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxRoomID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxRoomNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxFloorNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxType.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxRoomID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
