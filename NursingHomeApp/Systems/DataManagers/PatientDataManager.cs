using NursingHomeApp.Systems.DataManagers.Interfaces;
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

        public List<Patient> Select()
        {
            return DbContext.Patients.ToList();
        }

        public Patient Select(int Id)
        {
            return DbContext.Patients.SingleOrDefault(p => p.Id == Id);
        }

        public List<Patient> SelectEmployeeId(int Id)
        {
            return DbContext.Patients.Where(e => e.EmployeeId == Id).ToList();
        }

        public bool Update(Patient t)
        {
            Patient patient = DbContext.Patients.SingleOrDefault(p => p.Id == t.Id);
            patient = t;
            return (DbContext.SaveChanges() > 0);
        }
    }
}
