using System;
using System.Windows.Forms;
using Autofac;

namespace OpenOSD
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = Container.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var mainForm = scope.Resolve<FrmSensors>();
                Application.Run(mainForm);
            }
        }
    }
}
