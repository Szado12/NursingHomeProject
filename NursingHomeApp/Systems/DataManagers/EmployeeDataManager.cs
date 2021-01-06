using NursingHomeApp.Systems.DataManagers.Interfaces;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers
{
    class EmployeeDataManager : DefaultDataManager, IEmployeeDataManager
    {
        public bool Add(Employee t)
        {
            DbContext.Employees.Add(t);
            return (DbContext.SaveChanges() > 0);
        }

        public bool Delete(int Id)
        {
            Employee employee = DbContext.Employees.SingleOrDefault(p => p.Id == Id);
            DbContext.Employees.Remove(employee);
            return (DbContext.SaveChanges() > 0);
        }

        public List<Employee> Select()
        {
            return DbContext.Employees.ToList();
        }
        public List<Employee> SelectNurses()
        {
            return DbContext.Employees.Where(p => p.ProfessionId == 3).ToList();
        }
        public Employee Select(int Id)
        {
            
            return DbContext.Employees.SingleOrDefault(p => p.Id == Id);
        }
        public bool Update(Employee t)
        {
            Employee employee = DbContext.Employees.SingleOrDefault(p => p.Id == t.Id);
            employee = t;
            return (DbContext.SaveChanges() > 0);
        }
    }
}
