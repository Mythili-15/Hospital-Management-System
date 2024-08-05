using Microsoft.Extensions.DependencyInjection;
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
    public partial class PatientCRUD : UserControl
    {
        public Func<string, string, MessageBoxButtons, MessageBoxIcon, DialogResult> MessageBoxOverride;

        private readonly IDatabaseOps _databaseOps;
        public PatientCRUD(string id, IDatabaseOps databaseOps)
        {
            InitializeComponent();
            _databaseOps = databaseOps;
            display();
            employeeid.Text = id;
        }
        private void ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (MessageBoxOverride != null)
                MessageBoxOverride(text, caption, buttons, icon);
            else
                MessageBox.Show(text, caption, buttons, icon);
        }

        public void display()
        {
            dataGridView1.DataSource = _databaseOps.display("PATIENTS");
        }

        public void buttonPATInsert_Click(object sender, EventArgs e)
        {
            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(textBoxPATName.Text) ||
                string.IsNullOrWhiteSpace(comboBoxPATGender.Text) ||
                string.IsNullOrWhiteSpace(textBoxPATTel.Text) ||
                string.IsNullOrWhiteSpace(employeeid.Text) ||
                string.IsNullOrWhiteSpace(emailt.Text) ||
                string.IsNullOrWhiteSpace(textBoxPATAddress.Text))
            {
                // Display a message box if any field is empty
                ShowMessageBox("Please fill in all fields before inserting the patient information.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed with inserting the patient information if all fields are filled
            Patient patient = new Patient()
            {
                Name = textBoxPATName.Text,
                Gender = comboBoxPATGender.Text,
                Tel = textBoxPATTel.Text,
                CreatedBy = int.Parse(employeeid.Text),
                Date = dateTimePicker1.Value,
                Email = emailt.Text,
                Address = textBoxPATAddress.Text,
            };
            
            _databaseOps.insert(patient);
            display();
        }

        public void buttonPATDelete_Click(object sender, EventArgs e)
        {
            if (textBoxPATID.Text.Length != 0)
            {
                _databaseOps.delete("PATIENTS", textBoxPATID.Text);
                display();
            }
            else
            {
                ShowMessageBox("Unable to delete Data, Select a row which you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            display();
        }

        public void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxPATID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxPATName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "Male")
            {
                comboBoxPATGender.Text = "Male";
            }
            else
            {
                comboBoxPATGender.Text = "Female";
            }
            textBoxPATTel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            emailt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            employeeid.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[8].Value != DBNull.Value)
            {
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            }
            else
            {
                // Set a default value if the cell value is DBNull
                dateTimePicker1.Value = DateTime.Now; // or any other default value you prefer
            }
            textBoxPATAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        public void buttonPATUpdate_Click(object sender, EventArgs e)
        {
            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(textBoxPATID.Text) ||
                string.IsNullOrWhiteSpace(textBoxPATName.Text) ||
                string.IsNullOrWhiteSpace(comboBoxPATGender.Text) ||
                string.IsNullOrWhiteSpace(textBoxPATTel.Text) ||
                string.IsNullOrWhiteSpace(employeeid.Text) ||
                string.IsNullOrWhiteSpace(emailt.Text) ||
                string.IsNullOrWhiteSpace(textBoxPATAddress.Text))
            {
                // Display a message box if any field is empty
                ShowMessageBox("Please fill in all fields before updating the patient information.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed with updating the patient information if all fields are filled
            Patient patient = new Patient()
            {
                ID = textBoxPATID.Text,
                Name = textBoxPATName.Text,
                Gender = comboBoxPATGender.Text,
                Tel = textBoxPATTel.Text,
                Date = dateTimePicker1.Value,
                CreatedBy = int.Parse(employeeid.Text),
                Email = emailt.Text,
                Address = textBoxPATAddress.Text,
            };
            
            _databaseOps.update(patient);
            display();
        }


        public void textBoxSearchVal_TextChanged(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = _databaseOps.search("PATIENTS", textBoxSearchVal.Text, comboBoxSearchBy.Text);
        }

        public void buttonPATDisplay_Click(object sender, EventArgs e)
        {
            var databaseOps = Program.ServiceProvider.GetRequiredService<IDatabaseOps>();

            DoctorsAppointmentUserControl doctorsAppointmentUserControl = new DoctorsAppointmentUserControl(databaseOps);
            doctorsAppointmentUserControl.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
