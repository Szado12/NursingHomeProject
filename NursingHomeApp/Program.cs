using NursingHomeApp.Forms;
using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Systems.LogicalManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NursingHomeApp
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            Employee employee = employeeManager.Select(13);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

        }
    }
}
