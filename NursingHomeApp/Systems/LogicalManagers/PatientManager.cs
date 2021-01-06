using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Views;
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
        public bool Update(int Id, string FirstName, string LastName, string PersonId, int Age, string ContactNumber, string PhoneNumber, int RoomId, string Alergies, int EmployeeId)
        {
            Patient patient = new Patient()
            {
                Id = Id,
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
            return patientDataManager.Update(patient);
        }
        public bool Delete(int Id)
        {
            return patientDataManager.Delete(Id);
        }
        public List<NursePatientsView> SelectNursePatients(int Id)
        {
            return patientDataManager.SelectNursePatients(Id);
        }
        public  List<PatientView> Select()
        {
            return patientDataManager.Select();
        }
        public List<PatientOnListView> SelectToList()
        {
            return patientDataManager.SelectToList();
        }
        public PatientView Select(int Id)
        {
            return patientDataManager.Select(Id);
        }
        public List<Patient> SelectAll()
        {
            return patientDataManager.SelectAll();
        }
        public List<PatientView> SelectEmployeeId(int Id)
        {
            return patientDataManager.SelectEmployeeId(Id);
        }
        public List<PatientOnListView> SelectRoomId(int Id)
        {
            return patientDataManager.SelectRoomId(Id);
        }

    }
}
