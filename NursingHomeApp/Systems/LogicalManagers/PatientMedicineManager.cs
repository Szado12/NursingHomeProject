using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Views;

namespace NursingHomeApp.Systems.LogicalManagers
{
    class PatientMedicineManager
    {
        PatientMedicineDataManager patientMedicineDataManager = new PatientMedicineDataManager();

        public bool Add(int medicineId, int patientId, int dose, TimeSpan term)
        {
            PatientMedicine patientMedicine = new PatientMedicine()
            {
                MedicineId= medicineId,
                PatientId = patientId,
                Dose = dose,
                Term=term
            };
            
            return patientMedicineDataManager.Add(patientMedicine);
        }

        public bool Delete(int Id)
        {
            
            return patientMedicineDataManager.Delete(Id);
        }

        public List<PatientMedicineView> Select()
        {
            
            return patientMedicineDataManager.Select();
        }

        public PatientMedicineView Select(int Id)
        {
            throw new NotImplementedException();
        }

        public List<PatientMedicineView> SelectAll(int Id)
        {
            return patientMedicineDataManager.SelectAll(Id);
        }

        public bool Update(int id, int medicineId, int patientId, int dose, TimeSpan term)
        {
            PatientMedicine patientMedicine = new PatientMedicine()
            {
                Id=id,
                MedicineId = medicineId,
                PatientId = patientId,
                Dose = dose,
                Term = term
            };
            return patientMedicineDataManager.Update(patientMedicine);
        }

        public List<PatientMedicineView> SelectPatientMedicine(int Id)
        {
            return patientMedicineDataManager.SelectPatientMedicine(Id); 
        }
    }
}
