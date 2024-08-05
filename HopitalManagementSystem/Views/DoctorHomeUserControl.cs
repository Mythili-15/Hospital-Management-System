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
    public partial class DoctorHomeUserControl : UserControl
    {
        public DoctorHomeUserControl(string iD, string depart_id)
        {
            InitializeComponent();
            ID = iD;
            Departmental_ID = depart_id;
        }

        public string ID { get; set; }
        public string Departmental_ID { get; set; }
        private void buttondoctorspatient_Click(object sender, EventArgs e)
        {
            var databaseOps = Program.ServiceProvider.GetRequiredService<IDatabaseOps>();

            DoctorsPatientListControl doctorsPatientListControl = new DoctorsPatientListControl(ID, databaseOps);
            ControlClass.ShowControl(doctorsPatientListControl, Content);
        }

        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            var databaseOps = Program.ServiceProvider.GetRequiredService<IDatabaseOps>();

            Docappointment doctorsAppointmentUserControl = new Docappointment(Convert.ToInt32(this.ID), databaseOps);
            ControlClass.ShowControl(doctorsAppointmentUserControl, Content);
        }
    }
}
