using NursingHomeApp.Systems.DataManagers.Interfaces;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers
{
    public class PatientLoginDataManager : DefaultDataManager, IPatientLoginDataManager
    {
        public PatientView Select(string PersonId, string Password)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(Password);
            SHA512 shaM = new SHA512Managed();
            Byte[] hashedBytes = shaM.ComputeHash(inputBytes);
            PatientLogin patient = DbContext.PatientLogins.Where(x => x.PersonId == PersonId && x.Password == hashedBytes).SingleOrDefault();
            if (patient == null)
                return null;
            return Mapper.Map<Patient, PatientView>(patient.Patient);
        }
    }
}
