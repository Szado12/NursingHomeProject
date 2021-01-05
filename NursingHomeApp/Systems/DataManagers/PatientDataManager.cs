using NursingHomeApp.Systems.DataManagers.Interfaces;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers
{
    class PatientDataManager : DefaultDataManager, IPatientDataManager
    {
        public bool Add(Patient t)
        {
            DbContext.Patients.Add(t);
            return (DbContext.SaveChanges() > 0);
        }

        public bool Delete(int Id)
        {
            Patient patient = DbContext.Patients.SingleOrDefault(p => p.Id == Id);
            DbContext.Patients.Remove(patient);
            return (DbContext.SaveChanges() > 0);
        }

        public List<PatientView> Select()
        {
            List<Patient> patients = DbContext.Patients.ToList();
            return Mapper.Map<List<Patient>, List<PatientView>>(patients);
        }

        public PatientView Select(int Id)
        {
            Patient patient = DbContext.Patients.SingleOrDefault(p => p.Id == Id);
            PatientView patientView = Mapper.Map<Patient, PatientView>(patient);
            return patientView;
        }

        public List<PatientView> SelectEmployeeId(int Id)
        {
            List<Patient> patients = DbContext.Patients.Where(e => e.EmployeeId == Id).ToList();
            return Mapper.Map<List<Patient>, List<PatientView>>(patients);
        }

        public bool Update(Patient t)
        {
            Patient patient = DbContext.Patients.SingleOrDefault(p => p.Id == t.Id);
            patient = t;
            return (DbContext.SaveChanges() > 0);
        }
    }
}
