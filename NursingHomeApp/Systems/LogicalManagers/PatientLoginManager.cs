using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Views;

namespace NursingHomeApp.Systems.LogicalManagers
{
    class PatientLoginManager
    {
        PatientLoginDataManager patientLoginDataManager = new PatientLoginDataManager();

        public PatientView Select(string PersonId, string Password)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(Password);
            SHA512 shaM = new SHA512Managed();
            Byte[] hashedBytes = shaM.ComputeHash(inputBytes);

            return patientLoginDataManager.Select(PersonId, hashedBytes);
        }
    }
}
