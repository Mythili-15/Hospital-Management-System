using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace HopitalManagementSystem
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();

            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var splashScreen = ServiceProvider.GetRequiredService<SplashScreen>();
            Application.Run(splashScreen);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IDatabaseOps, DatabaseOps>();
            services.AddSingleton<CrudEmployee>();
            services.AddSingleton<Login>();
            services.AddSingleton<DashBoard>();
            services.AddSingleton<SplashScreen>();
            services.AddSingleton<DoctorLogin>();
        }
    }
}