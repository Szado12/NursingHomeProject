using NursingHomeApp.Systems.DataManagers.Interfaces;
using NursingHomeApp.Systems.DataMangers.Interfaces;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers
{
    class PatientMedicineDataManager : DefaultDataManager, IPatientMedicineDataManger
    {
        public bool Add(PatientMedicine t)
        {
            DbContext.PatientMedicines.Add(t);
            return (DbContext.SaveChanges() > 0);
        }

        public bool Delete(int Id)
        {
            PatientMedicine patientMedicine = DbContext.PatientMedicines.SingleOrDefault(p => p.Id == Id);
            DbContext.PatientMedicines.Remove(patientMedicine);
            return (DbContext.SaveChanges() > 0);
        }

        public List<PatientMedicineView> Select()
        {
            List<PatientMedicine> patients = DbContext.PatientMedicines.ToList();
            return Mapper.Map<List<PatientMedicine>, List<PatientMedicineView>>(patients);
        }

        public PatientMedicineView Select(int Id)
        {
            throw new NotImplementedException();
        }

        public List<PatientMedicineView> SelectAll(int Id)
        {
            List<PatientMedicine> patientMedicine = DbContext.PatientMedicines.Where(p => p.PatientId == Id).ToList();
            return Mapper.Map<List<PatientMedicine>, List<PatientMedicineView>>(patientMedicine);
        }

        public bool Update(PatientMedicine t)
        {
            PatientMedicine patientMedicine = DbContext.PatientMedicines.SingleOrDefault(p => p.Id == t.Id);
            patientMedicine.MedicineId = t.MedicineId;
            patientMedicine.Dose = t.Dose;
            patientMedicine.Term = t.Term;
            return (DbContext.SaveChanges() > 0);
        }

        public List<PatientMedicineView> SelectPatientMedicine(int Id)
        {
            List<PatientMedicine> patientMedicines = DbContext.PatientMedicines.Where(pm => pm.PatientId == Id).ToList();
            return Mapper.Map<List<PatientMedicine>, List<PatientMedicineView>>(patientMedicines);
        }

    }
}
