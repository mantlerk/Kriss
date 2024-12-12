using CargoTransportationSystem;
using System;
using System.Windows.Forms;
using TruckingSystem; // Если MainForm находится в этом пространстве имен

namespace TruckingSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Убедитесь, что MainForm существует
        }
    }
}
