using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopitalManagementSystem
{
    public partial class InpatientUserControl : UserControl
    {
        public Func<string, string, MessageBoxButtons, MessageBoxIcon, DialogResult> MessageBoxOverride;

        private readonly IDatabaseOps _databaseOps;
        public InpatientUserControl(IDatabaseOps databaseOps)
        {
            InitializeComponent();
            _databaseOps = databaseOps;
            patientList();
            display();
        }
        private void ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (MessageBoxOverride != null)
                MessageBoxOverride(text, caption, buttons, icon);
            else
                MessageBox.Show(text, caption, buttons, icon);
        }

        public void roomList()
        {
            
            DataTable dataTable = new DataTable();
            dataTable = _databaseOps.roomList(comboBoxRType.Text);
            comboBoxRNo.DataSource = dataTable;
            comboBoxRNo.ValueMember = "ID";
            comboBoxRNo.DisplayMember = "ID";
        }

        public void patientList()
        {
            DataTable dataTable = new DataTable();
            dataTable = _databaseOps.patientList();
            comboBoxPatient.DataSource = dataTable;
            comboBoxPatient.DisplayMember = "PAT_NAME";
            comboBoxPatient.ValueMember = "ID";
        }

        public void buttonRoom_Click(object sender, EventArgs e)
        {
            FindRoom findRoom = new FindRoom();
            findRoom.Show();
        }

        public void comboBoxRType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRNo.Enabled = true;
            roomList();
        }

        public void buttonRoomInsert_Click(object sender, EventArgs e)
        {
            Inpatient inpatient = new Inpatient();
            inpatient.PatID = int.Parse(comboBoxPatient.SelectedValue.ToString());
            inpatient.RoomNo = comboBoxRNo.SelectedValue.ToString();
            inpatient.Admission = dateTimePickerDOA.Value.Date;
            inpatient.Discharge = dateTimePickerDOD.Value.Date;
            inpatient.TotalAmount = int.Parse(textBox1.Text);
            
            if (inpatient.ifinpatientalreadyexisted(inpatient.PatID, inpatient.Admission) == true)
            {
                _databaseOps.insert(inpatient);
                //_databaseOps.updateRoomAvailability(Convert.ToInt32(inpatient.RoomNo), "Unavailable");
            }
            else
            {
                MessageBox.Show("Unable to Assign room because room already assignes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            display();
        }

        public void display()
        {
            
            dataGridViewINP.DataSource = _databaseOps.displayInPat();
        }

        public void buttonRoomUpdate_Click(object sender, EventArgs e)
        {
            // Check if the patient selection is valid
            if (comboBoxPatient.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid patient.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the inpatient ID is valid
            if (string.IsNullOrWhiteSpace(textBoxInpatientID.Text) || !int.TryParse(textBoxInpatientID.Text, out int inPatID))
            {
                MessageBox.Show("Please enter a valid inpatient ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the room number selection is valid
            if (comboBoxRNo.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid room number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the total amount is valid
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int totalAmount))
            {
                MessageBox.Show("Please enter a valid total amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Create the Inpatient object
                Inpatient inpatient = new Inpatient()
                {
                    PatID = int.Parse(comboBoxPatient.SelectedValue.ToString()),
                    InPatID = inPatID,
                    RoomNo = comboBoxRNo.SelectedValue.ToString(),
                    Admission = dateTimePickerDOA.Value.Date,
                    Discharge = dateTimePickerDOD.Value.Date,
                    TotalAmount = totalAmount,
                };

                // Perform the update operation
              
                _databaseOps.update(inpatient);
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void textBoxSearchVal_TextChanged(object sender, EventArgs e)
        {
            
            dataGridViewINP.DataSource = _databaseOps.search("INPATIENTS", textBoxSearchVal.Text, comboBoxSearchBy.Text);
        }

        public void dataGridViewINP_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Populate form fields with data from the selected row
            try
            {
                textBoxInpatientID.Text = dataGridViewINP.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;

                // Attempt to set the SelectedValue for comboBoxPatient
                var patientValue = dataGridViewINP.Rows[e.RowIndex].Cells[1].Value;
                if (patientValue != null && int.TryParse(patientValue.ToString(), out int selectedValue))
                {
                    comboBoxPatient.SelectedValue = selectedValue;
                }
                else
                {
                    comboBoxPatient.SelectedValue = -1; // Clear the comboBox selection
                    MessageBox.Show("Selected patient ID is not in the correct format or is null.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                comboBoxPatient.SelectedText = dataGridViewINP.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
                textBoxPhone.Text = dataGridViewINP.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? string.Empty;

                // Handle date fields with checks
                if (DateTime.TryParse(dataGridViewINP.Rows[e.RowIndex].Cells[4].Value?.ToString(), out DateTime doa))
                {
                    dateTimePickerDOA.Value = doa;
                }
                else
                {
                    dateTimePickerDOA.Value = DateTime.Now; // Default value or handle as needed
                }

                if (DateTime.TryParse(dataGridViewINP.Rows[e.RowIndex].Cells[5].Value?.ToString(), out DateTime dod))
                {
                    dateTimePickerDOD.Value = dod;
                }
                else
                {
                    dateTimePickerDOD.Value = DateTime.Now; // Default value or handle as needed
                }

                comboBoxRNo.Text = dataGridViewINP.Rows[e.RowIndex].Cells[6].Value?.ToString() ?? string.Empty;
                comboBoxRType.Text = dataGridViewINP.Rows[e.RowIndex].Cells[7].Value?.ToString() ?? string.Empty;
                textBox1.Text = dataGridViewINP.Rows[e.RowIndex].Cells[8].Value?.ToString() ?? string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buttonRoomDelete_Click(object sender, EventArgs e)
        {
            if (textBoxInpatientID.Text.Length != 0)
            {
               
                _databaseOps.delete("INPATIENT", textBoxInpatientID.Text);
                display();
            }
            else
            {
                MessageBox.Show("Unable to delete Data, Select a row which you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            display();
        }

        private void dataGridViewINP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int noofdays;
        public void button1_Click(object sender, EventArgs e)
        {
            Room patientroom = new Room();
            patientroom.Room_type = comboBoxRType.SelectedItem.ToString();
            patientroom.setPricePerHour();
            DateTime dt1 = dateTimePickerDOA.Value;
            DateTime dt2 = dateTimePickerDOD.Value;
            TimeSpan t = dt2 - dt1;
            noofdays = Convert.ToInt32(t.TotalDays);
            textBox1.Text = Convert.ToString(noofdays * patientroom.Price_Per_Hour);
        }
    }

    public class Inpatient : Patient
    {
        public int PatID { get; set; }
        public int InPatID { get; set; }
        public string RoomNo { get; set; }
        public DateTime Admission { get; set; }
        public DateTime Discharge { get; set; }
        public int TotalAmount { get; set; }


        public virtual bool ifinpatientalreadyexisted(int pid, DateTime stdate)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            DataTable dt = new DataTable();
            dt = databaseOps.displayInPat();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (pid == Convert.ToInt32(dt.Rows[i][1].ToString()))
                {
                    if (stdate > Convert.ToDateTime(dt.Rows[i]["DATE_OF_DIS"]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                //else
                //{

                //    //return true;
                //}
            }

            return true;
        }
    }
}
