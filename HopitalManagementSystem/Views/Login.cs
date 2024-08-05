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
    public partial class Login : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IDatabaseOps _databaseOps;

        public Login(IServiceProvider serviceProvider, IDatabaseOps databaseOps)
        {
            _serviceProvider = serviceProvider;
            _databaseOps = databaseOps;
            InitializeComponent();
            textboxError.Visible = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text.Length != 0 && textBoxUsername.Text.Length != 0)
            {
                UserLogin userLogin = new UserLogin()
                {
                    Username = textBoxUsername.Text,
                    Pass = textBoxPass.Text
                };
                _databaseOps.login(userLogin, "employeeLogin");
                this.Close();
            }
            else
            {
                textboxError.Visible = true;
                button1.BackColor = Color.FromArgb(textboxError.ForeColor.ToArgb());
            }
        }

        public void Login_Load(object sender, EventArgs e)
        {
            DatabaseOps db = new DatabaseOps();
            db.makeslotsavailable();
        }

        public void label3_Click(object sender, EventArgs e)
        {
            DoctorLogin doctorLogin = new DoctorLogin(_databaseOps);
            doctorLogin.Show();
            this.Close();
        }
    }

    public class UserLogin
    {
        public string? Username { get; set; }
        public string? Pass { get; set; }

        //public void login(UserLogin userLogin)
        //{
        //    try
        //    {
        //        DatabaseOps databaseOps = new DatabaseOps();
        //        databaseOps.login(userLogin, "");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Database operation failed: {ex.Message}");
        //    }
        //}
    }
}
