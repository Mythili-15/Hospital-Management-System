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
    public partial class DoctorsPatientListControl : UserControl
    {
        public Func<string, string, MessageBoxButtons, MessageBoxIcon, DialogResult> MessageBoxOverride;

        private readonly IDatabaseOps _databaseOps;
        public string ID { get; set; }

        public DoctorsPatientListControl(string id, IDatabaseOps databaseOps)
        {
            InitializeComponent();
            _databaseOps = databaseOps;
            ID = id;
        }
        public void ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (MessageBoxOverride != null)
                MessageBoxOverride(text, caption, buttons, icon);
            else
                ShowMessageBox(text, caption, buttons, icon);
        }
        public void display()
        {
            Console.WriteLine("Calling display method");
            dataGridViewINP.DataSource = _databaseOps.doctorsPatient(ID);
        }

        public void DoctorsPatientListControl_Load(object sender, EventArgs e)
        {
            display();
        }

        public void dataGridViewINP_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxInpatientID.Text = dataGridViewINP.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxPatientName.Text = dataGridViewINP.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        public void buttonPATDelete_Click(object sender, EventArgs e)
        {
            if (textBoxInpatientID.Text.Length != 0)
            {
               
                _databaseOps.delete("PATIENTS", textBoxInpatientID.Text);
                display();
            }
            else
            {
                ShowMessageBox("Sorry You Cannot Delete Any Patient", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void textBoxSearchValue_TextChanged(object sender, EventArgs e)
        {
            
            dataGridViewINP.DataSource = _databaseOps.searchPat(textBoxSearchValue.Text, comboBoxSearchBy.Text, ID);
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
