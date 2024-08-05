using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinFormsTimer = System.Windows.Forms.Timer;

namespace HopitalManagementSystem
{
    public partial class SplashScreen : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public SplashScreen(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        WinFormsTimer tmr;

        private void Form1_Shown(object sender, EventArgs e)
        {
            tmr = new WinFormsTimer();
            // Set time interval to 3 seconds
            tmr.Interval = 3000;
            // Start the timer
            tmr.Start();
            tmr.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // After 3 seconds, stop the timer
            tmr.Stop();
            // Display the main form
            var loginForm = _serviceProvider.GetRequiredService<Login>();
            loginForm.Show();
            // Hide this form
            this.Hide();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
