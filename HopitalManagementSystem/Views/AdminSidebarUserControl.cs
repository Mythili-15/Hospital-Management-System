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
    public partial class AdminSidebarUserControl : UserControl
    {
        public AdminSidebarUserControl()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

        }

        private void buttonPatient_Click(object sender, EventArgs e)
        {

        }

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            var databaseOps = Program.ServiceProvider.GetRequiredService<IDatabaseOps>();
            CRUDDoctor cRUDDoctor = new CRUDDoctor(databaseOps);
            ControlClass.ShowControl(cRUDDoctor, Content);
        }

       
        private void buttonBilling_Click(object sender, EventArgs e)
        {

        }
    }
}
