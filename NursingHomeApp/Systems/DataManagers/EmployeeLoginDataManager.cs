using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NursingHomeApp.Systems.DataManagers.Interfaces;

namespace NursingHomeApp.Systems.DataManagers
{
    public class EmployeeLoginDataManager : DefaultDataManager, IEmployeeLoginDataManager
    {
        public Employee Select(string PersonId, string Password)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(Password);
            SHA512 shaM = new SHA512Managed();
            Byte[] hashedBytes = shaM.ComputeHash(inputBytes);
            EmployeeLogin employee = DbContext.EmployeeLogins.Where(x => x.PersonId == PersonId && x.Password == hashedBytes).SingleOrDefault();
            if (employee == null)
                return null;
            return employee.Employee;
        }
    }
}
