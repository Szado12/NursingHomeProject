using System.Collections.Generic;
using System.Data.Entity;
using NursingHomeApp.Systems.DataManagers;

namespace NursingHomeApp.Systems.LogicalManagers
{
    class EmployeeManager
    {
        EmployeeDataManager employeeDataManager = new EmployeeDataManager();
        public List<Employee> SelectNurses()
        {
            return employeeDataManager.SelectNurses();
        }
        public Employee Select(int Id)
        {

            return employeeDataManager.Select(Id);
        }

    }
}
