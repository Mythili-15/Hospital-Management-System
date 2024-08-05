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
    public partial class AdminHomeControl : UserControl
    {
        private readonly IDatabaseOps _databaseOps;
        public string employeeID { get; set; }
        public AdminHomeControl(string id, IDatabaseOps databaseOps)
        {
            InitializeComponent();
            MaximizeParentForm();
            employeeID = id;
            _databaseOps = databaseOps;
        }
        private void MaximizeParentForm()
        {
            if (this.ParentForm != null)
            {
                this.ParentForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var databaseOps = Program.ServiceProvider.GetRequiredService<IDatabaseOps>();
            CRUDDoctor cRUDDoctor = new CRUDDoctor(databaseOps);
            ControlClass.ShowControl(cRUDDoctor, Content);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var databaseOps = Program.ServiceProvider.GetRequiredService<IDatabaseOps>();
            PatientCRUD cRUDPatient = new PatientCRUD(employeeID, databaseOps);
            ControlClass.ShowControl(cRUDPatient, Content);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var databaseOps = Program.ServiceProvider.GetRequiredService<IDatabaseOps>();
            InpatientUserControl inpatientUserControl = new InpatientUserControl(databaseOps);
            ControlClass.ShowControl(inpatientUserControl, Content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var databaseOps = Program.ServiceProvider.GetRequiredService<IDatabaseOps>();

            RoomCRUD roomCRUD = new RoomCRUD(databaseOps);
            ControlClass.ShowControl(roomCRUD, Content);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var databaseOps = Program.ServiceProvider.GetRequiredService<IDatabaseOps>();
            CrudEmployee emp = new CrudEmployee(databaseOps);
            emp.Show();
            this.Hide();
        }



        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            var databaseOps = Program.ServiceProvider.GetRequiredService<IDatabaseOps>();

            DoctorsAppointmentUserControl doctorsAppointmentUserControl = new DoctorsAppointmentUserControl(databaseOps);
            ControlClass.ShowControl(doctorsAppointmentUserControl, Content);
        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
