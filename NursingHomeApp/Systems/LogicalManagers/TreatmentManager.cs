using NursingHomeApp.Systems.DataManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.LogicalManagers
{
    class TreatmentManager
    {
        TreatmentDataManager treatmentDataManager = new TreatmentDataManager();

        public bool Add(string Name, TimeSpan Duration)
        {
            Treatment treatment = new Treatment()
            {
                Name = Name,
                Duration = Duration
            };
            return treatmentDataManager.Add(treatment);
        }
        public bool Update(int Id, string Name, TimeSpan Duration)
        {
            Treatment treatment = new Treatment()
            {
                Id = Id,
                Name = Name,
                Duration = Duration
            };
            return treatmentDataManager.Update(treatment);
        }
        public bool Delete(int Id)
        {
            return treatmentDataManager.Delete(Id);
        }
        public List<Treatment> Select()
        {
            return treatmentDataManager.Select();
        }
        public Treatment Select(int Id)
        {
            return treatmentDataManager.Select(Id);
        }
    }
}