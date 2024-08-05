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
    public partial class DoctorsAppointmentUserControl : UserControl
    {
        public Func<string, string, MessageBoxButtons, MessageBoxIcon, DialogResult> MessageBoxOverride;

        private readonly IDatabaseOps _databaseOps;
        public DoctorsAppointmentUserControl(IDatabaseOps databaseOps)
        {
            InitializeComponent();
            _databaseOps = databaseOps;
            dateTimePicker1.Value = DateTime.Today;

        }
        private void ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (MessageBoxOverride != null)
                MessageBoxOverride(text, caption, buttons, icon);
            else
                MessageBox.Show(text, caption, buttons, icon);
        }

        public string ID { get; set; }

        public void display()
        {
            
            dataGridViewINP.DataSource = _databaseOps.doctorAppointment();
        }

        public void patientList()
        {
            comboBoxpatient.Items.Clear();
            
            DataTable dataTable = new DataTable();
            dataTable = _databaseOps.patientList();
            comboBoxpatient.DataSource = dataTable;
            comboBoxpatient.DisplayMember = "PAT_NAME";
            comboBoxpatient.ValueMember = "ID";
        }

        public void DoctorList()
        {
            comboBoxDoctor.Items.Clear();
            
            comboBoxDoctor.DataSource = _databaseOps.doctorList(); ;
            comboBoxDoctor.DisplayMember = "DOC_NAME";
            comboBoxDoctor.ValueMember = "ID";
        }

        public void TimeSlotlist()
        {
           
            DataTable timeslotDataTable = _databaseOps.timeslotlist(Convert.ToInt32(comboBoxDoctor.SelectedValue.ToString()));
            comboBoxslots.DataSource = timeslotDataTable;
            comboBoxslots.DisplayMember = "slotdec";
            comboBoxslots.ValueMember = "id";

        }

        public void DoctorsAppointmentUserControl_Load(object sender, EventArgs e)
        {
            display();
            patientList();
            DoctorList();
            TimeSlotlist();
        }

        public void dataGridViewINP_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBoxDoctor.Text = "";
            comboBoxpatient.Text = "";
            comboBoxslots.Text = "";
            textBoxAppointmentID.Text = dataGridViewINP.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxDoctor.Text = dataGridViewINP.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxpatient.Text = dataGridViewINP.Rows[e.RowIndex].Cells[2].Value.ToString();

            DateTime appointmentDate;
            if (DateTime.TryParse(dataGridViewINP.Rows[e.RowIndex].Cells[3].Value.ToString(), out appointmentDate))
            {
                dateTimePicker1.Value = appointmentDate;
            }
            else
            {
                ShowMessageBox("Invalid date format in the selected row.", "Date Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Value = DateTime.Now; // Set to a default value or handle as needed
            }

            comboBoxslots.Text = dataGridViewINP.Rows[e.RowIndex].Cells[4].Value.ToString() + " " +
                dataGridViewINP.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        public void buttonCancelAppointment_Click(object sender, EventArgs e)
        {
            if (textBoxAppointmentID.Text.Length != 0)
            {
                int oldslotid = _databaseOps.gettimeslotidfromappointment(textBoxAppointmentID.Text);
                _databaseOps.updatetimeslotavailability(oldslotid, 1);
                _databaseOps.delete("APPOINTMENT", textBoxAppointmentID.Text);
                display();
            }
            else
            {
                ShowMessageBox("Unable to Cancel Appointment, Select a row which you want to Cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buttonReschedule_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.AppointmentID = textBoxAppointmentID.Text;
            appointment.AppointmentDate = dateTimePicker1.Value.Date; // Ensure only the date part is used
            appointment.TimeslotID = Convert.ToInt32(comboBoxslots.SelectedValue.ToString());
            appointment.DoctorID = Convert.ToInt32(comboBoxDoctor.SelectedValue.ToString());
            appointment.PatientID = Convert.ToInt32(comboBoxpatient.SelectedValue.ToString());

            int oldslotid = _databaseOps.gettimeslotidfromappointment(appointment.AppointmentID);
            _databaseOps.updatetimeslotavailability(oldslotid, 1);
            _databaseOps.update(appointment);
            _databaseOps.updatetimeslotavailability(appointment.TimeslotID, 0);
            display();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void comboBoxDoctor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TimeSlotlist();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.AppointmentDate = dateTimePicker1.Value;
            appointment.TimeslotID = Convert.ToInt32(comboBoxslots.SelectedValue.ToString());
            appointment.DoctorID = Convert.ToInt32(comboBoxDoctor.SelectedValue.ToString());
            appointment.PatientID = Convert.ToInt32(comboBoxpatient.SelectedValue.ToString());

            _databaseOps.insert(appointment);
            _databaseOps.updatetimeslotavailability(appointment.TimeslotID, 0);
            display();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void textBoxDesignation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerENDTIME_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewINP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAppointmentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDepartment_TextChanged(object sender, EventArgs e)
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

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxslots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxpatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
