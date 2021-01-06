using NursingHomeApp.Systems.DataManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.LogicalManagers
{
    public class PatientManager
    {
        PatientDataManager patientDataManager = new PatientDataManager();

        public bool Add(string FirstName, string LastName, string PersonId, int Age, string ContactNumber, string PhoneNumber, int RoomId, string Alergies, int EmployeeId)
        {
            Patient patient = new Patient()
            {
                FirstName = FirstName,
                LastName = LastName,
                PersonId = PersonId,
                Age = Age,
                ContactNumber = ContactNumber,
                PhoneNumber = PhoneNumber,
                RoomID = RoomId,
                Alergies = Alergies,
                EmployeeId = EmployeeId
            };
            return patientDataManager.Add(patient);
        }
            
    }
}
