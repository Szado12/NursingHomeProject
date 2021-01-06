using NursingHomeApp.Systems.DataManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.LogicalManagers
{
    public class EmployeeLoginManager
    {
        EmployeeLoginDataManager employeeLoginDataManager = new EmployeeLoginDataManager();

        public Employee Select(string PersonId, string Password)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(Password);
            SHA512 shaM = new SHA512Managed();
            Byte[] hashedBytes = shaM.ComputeHash(inputBytes);

            return employeeLoginDataManager.Select(PersonId, hashedBytes);
        }
    }
}
