using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.LogicalManagers
{
    public class MedicineManager
    {
        MedicineDataManager medicineDataManager = new MedicineDataManager();

        public bool Add(string name, int amount)
        {
            if (name == "")
            {
                return false;
            }

            Medicine medicine = new Medicine()
            {
                Name = name,
                Amount = amount
            };

            return medicineDataManager.Add(medicine);
        }

        public bool Update(int id, string name, int amount)
        {
            if (name == "")
            {
                return false;
            }

            Medicine medicine = new Medicine()
            {
                Id = id,
                Name = name,
                Amount = amount
            };

            return medicineDataManager.Update(medicine);
        }

        public bool Delete(int id)
        {
            return medicineDataManager.Delete(id);
        }

        public List<MedicineView> Select()
        {
            return medicineDataManager.Select();
        }

        public MedicineView Select(int Id)
        {
            return medicineDataManager.Select(Id);
        }
    }
}
