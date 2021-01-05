using NursingHomeApp.Forms;
using NursingHomeApp.Systems.DataManagers;
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
            EmployeeDataManager employeeDataManager = new EmployeeDataManager();
            Employee employee = employeeDataManager.Select(13);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RehabilitatorForm(employee));

        }
    }
}
