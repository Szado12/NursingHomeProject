using NursingHomeApp.Systems.DataManagers.Interfaces;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers
{
    class MedicineDataManger : DefaultDataManager, IMedicineDataManger
    {
        public bool Add(Medicine t)
        {
            DbContext.Medicines.Add(t);
            return DbContext.SaveChanges() > 0;
        }

        public bool Delete(int Id)
        {
            Medicine medicine = DbContext.Medicines.SingleOrDefault(m => m.Id == Id);
            DbContext.Medicines.Remove(medicine);
            return DbContext.SaveChanges() > 0;
        }

        public List<MedicineView> Select()
        {
            List<Medicine> medicine = DbContext.Medicines.ToList();
            return Mapper.Map<List<Medicine>, List<MedicineView>>(medicine);
        }

        public MedicineView Select(int Id)
        {
            Medicine medicine = DbContext.Medicines.SingleOrDefault(p => p.Id == Id);
            MedicineView medicineView = Mapper.Map<Medicine, MedicineView>(medicine);
            return medicineView;
        }

        public bool Update(Medicine t)
        {
            Medicine medicine = DbContext.Medicines.SingleOrDefault(p => p.Id == t.Id);
            medicine = t;
            return (DbContext.SaveChanges() > 0);
        }
    }
}
