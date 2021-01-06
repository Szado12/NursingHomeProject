using NursingHomeApp.Systems.DataManagers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers
{
    class TreatmentDataManager : DefaultDataManager, ITreatmentDataManger
    {
        public bool Add(Treatment t)
        {
            DbContext.Treatments.Add(t);
            return (DbContext.SaveChanges() > 0);
        }

        public bool Delete(int Id)
        {
            Treatment treatment = DbContext.Treatments.SingleOrDefault(t => t.Id == Id);
            DbContext.Treatments.Remove(treatment);
            return (DbContext.SaveChanges() > 0);
        }

        public List<Treatment> Select()
        {
            return DbContext.Treatments.ToList();
        }

        public Treatment Select(int Id)
        {
            return DbContext.Treatments.SingleOrDefault(t => t.Id == Id);
        }

        public bool Update(Treatment t)
        {
            Treatment treatment = DbContext.Treatments.SingleOrDefault(x => x.Id == t.Id);
            treatment.Name = t.Name;
            treatment.Duration = t.Duration;
            return (DbContext.SaveChanges() > 0);
        }
    }
}
