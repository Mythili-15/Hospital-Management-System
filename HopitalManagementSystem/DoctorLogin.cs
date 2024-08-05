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
    public partial class DoctorLogin : Form
    {
        private readonly IDatabaseOps _databaseOps;
        public DoctorLogin(IDatabaseOps databaseOps)
        {
            InitializeComponent();
            _databaseOps = databaseOps ?? throw new ArgumentNullException(nameof(databaseOps)); 
        }     

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text.Length != 0 && textBoxUsername.Text.Length != 0)
            {
                UserLogin login = new UserLogin();
                login.Username = textBoxUsername.Text;
                login.Pass = textBoxPass.Text;
                
                _databaseOps.login(login, "doctorLogin");
            }
            else
            {
                textboxError.Visible = true;
                button1.BackColor = Color.FromArgb(textboxError.ForeColor.ToArgb());
            }
        }

        public void Login_Load(object sender, EventArgs e)
        {

            _databaseOps.makeslotsavailable();

        }

        public void label1_Click(object sender, EventArgs e)
        {
            Login login = new Login(Program.ServiceProvider, _databaseOps);
            login.Show();
            this.Close();
        }
    }
}
