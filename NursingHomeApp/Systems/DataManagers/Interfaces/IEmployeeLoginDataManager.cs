using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers.Interfaces
{
    interface IEmployeeLoginDataManager
    {
        Employee Select(string PersonId, Byte[] hashedBytes);
    }
}
