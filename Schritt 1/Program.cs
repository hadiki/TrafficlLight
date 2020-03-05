using System;
using System.Linq;
using System.Windows.Forms;

namespace Ampel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TrafficLight mainForm = new TrafficLight();
            Application.Run(mainForm);
        }
    }
}