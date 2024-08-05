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
    public partial class CRUDDoctor : UserControl
    {
        public Func<string, string, MessageBoxButtons, MessageBoxIcon, DialogResult> MessageBoxOverride;

        private readonly IDatabaseOps _databaseOps;
        public CRUDDoctor(IDatabaseOps databaseOps)
        {
            InitializeComponent();
            _databaseOps = databaseOps;
            display();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
        }
        private void ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (MessageBoxOverride != null)
                MessageBoxOverride(text, caption, buttons, icon);
            else
                MessageBox.Show(text, caption, buttons, icon);
        }

        public void buttonInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(comboBoxGender.Text) ||
                rolecbx.SelectedItem == null ||
                depcbx.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text) ||
                string.IsNullOrWhiteSpace(textBoxTel.Text) ||
                string.IsNullOrWhiteSpace(priceperappointment.Text))
            {
                ShowMessageBox("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Doctor doctor = new Doctor()
                {
                    Name = textBoxName.Text,
                    Gender = comboBoxGender.Text,
                    Designation = rolecbx.SelectedItem.ToString(),
                    Department = depcbx.SelectedItem.ToString(),
                    Email = textBoxEmail.Text,
                    Address = textBoxAddress.Text,
                    Tel = textBoxTel.Text,
                    starttime = dateTimePicker1.Value,
                    endtime = dateTimePicker2.Value,
                    PricePerAppointment = int.Parse(priceperappointment.Text),
                };

                _databaseOps.insert(doctor);
                display();
            }
            catch (FormatException)
            {
                ShowMessageBox("Invalid format in one of the fields. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ShowMessageBox($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buttonDisplay_Click(object sender, EventArgs e)
        {
            display();
        }
        int DoctorID;
        public void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cellValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            if (cellValue != null && int.TryParse(cellValue.ToString(), out DoctorID))
            {
            }
            else
            {
                ShowMessageBox("The selected Doctor ID is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            depcbx.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxTel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "Male")
            {
                comboBoxGender.Text = "Male";
            }
            else
            {
                comboBoxGender.Text = "Female";
            }
            textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            rolecbx.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            //dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString());
            //dateTimePicker2.Value = Convert.ToDateTime();
            priceperappointment.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            //dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString());
            //dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString());
        }

        public void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxid.Text) ||
                string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(comboBoxGender.Text) ||
                rolecbx.SelectedItem == null ||
                depcbx.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text) ||
                string.IsNullOrWhiteSpace(textBoxTel.Text) ||
                string.IsNullOrWhiteSpace(priceperappointment.Text))
            {
                ShowMessageBox("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Doctor doctor = new Doctor()
                {
                    ID = textBoxid.Text,
                    Name = textBoxName.Text,
                    Gender = comboBoxGender.Text,
                    Designation = rolecbx.SelectedItem.ToString(),
                    Department = depcbx.SelectedItem.ToString(),
                    Email = textBoxEmail.Text,
                    Address = textBoxAddress.Text,
                    Password = "123",
                    Tel = textBoxTel.Text,
                    starttime = dateTimePicker1.Value,
                    endtime = dateTimePicker2.Value,
                    PricePerAppointment = int.Parse(priceperappointment.Text),
                };

                _databaseOps.DeleteTimeSlots(DoctorID);
                _databaseOps.update(doctor);
                display();

                //doctor.addEmployee(doctor);
            }
            catch (Exception ex)
            {
                ShowMessageBox($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxid.Text.Length != 0)
            {
                
                _databaseOps.DeleteTimeSlots(DoctorID);
                _databaseOps.delete("DOCTORS", textBoxid.Text);
                display();
            }
            else
            {
                ShowMessageBox("Unable to delete Data, Select a row which you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void display()
        {
            
            dataGridView1.DataSource = _databaseOps.display("DOCTORS");
            _databaseOps.Showincbx(depcbx, "Department", "DepartmentName");
            _databaseOps.Showincbx(rolecbx, "DoctorRoles", "Rolename");
        }

        public void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = _databaseOps.search("DOCTORS", textBoxSearch.Text, comboBoxSearchBy.Text);
        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rolecbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void depcbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dOCTORSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
