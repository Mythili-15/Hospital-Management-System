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
    public partial class Docappointment : UserControl
    {
        public Func<string, string, MessageBoxButtons, MessageBoxIcon, DialogResult> MessageBoxOverride;

        private readonly IDatabaseOps _databaseOps;

        int ID;
        public Docappointment(int ID, IDatabaseOps databaseOps)
        {
            InitializeComponent();
            this.ID = ID;
            _databaseOps = databaseOps;
            dataGridViewINP.DataSource = _databaseOps.GetAppointmentofDoctor(this.ID);
        }
        public void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {            
            dataGridViewINP.DataSource = _databaseOps.GetAppointmentofDoctor(this.ID);
        }
        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void dataGridViewINP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
        public void comboBoxSearchBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.SelectedItem.ToString() == "Current Appointments")
            {
                dataGridViewINP.DataSource = _databaseOps.GetAppointmentofDoctor(this.ID, "Current Appointment");
            }
            else
            {
                dataGridViewINP.DataSource = _databaseOps.GetAppointmentofDoctor(this.ID);
            }
        }
        public void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
