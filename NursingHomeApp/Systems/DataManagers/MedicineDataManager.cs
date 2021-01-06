using NursingHomeApp.Systems.DataManagers.Interfaces;

using NursingHomeApp.Views;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NursingHomeApp.Systems.DataManagers
{
    public class MedicineDataManager : DefaultDataManager, IMedicineDataManger
    {
        public bool Add(Medicine t)
        {
            Medicine medicine = DbContext.Medicines.SingleOrDefault(m => m.Name == t.Name);
            if(medicine != null)
            {
                if (MessageBox.Show("This medicine already exists in data base!") == DialogResult.OK)
                    return false;
            }

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
            medicine.Name = t.Name;
            medicine.Amount = t.Amount;
            return (DbContext.SaveChanges() > 0);
        }
    }
}
