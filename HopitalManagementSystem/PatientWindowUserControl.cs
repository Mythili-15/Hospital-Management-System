using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopitalManagementSystem
{
    public partial class PatientWindowUserControl : UserControl
    {
        public PatientWindowUserControl()
        {
            InitializeComponent();
        }

        private void buttonOUTPAT_Click(object sender, EventArgs e)
        {
            //OutPatientUserControl outPatientUserControl = new OutPatientUserControl();
            //ControlClass.ShowControl(outPatientUserControl, Content);
        }

        private void buttonINPAT_Click(object sender, EventArgs e)
        {
            var databaseOps = Program.ServiceProvider.GetRequiredService<IDatabaseOps>();
            InpatientUserControl inpatientUserControl = new InpatientUserControl(databaseOps);
            ControlClass.ShowControl(inpatientUserControl, Content);
        }
    }
}
