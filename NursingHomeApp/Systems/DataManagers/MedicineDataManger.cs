using NursingHomeApp.Systems.DataManagers.Interfaces;
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
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> Select()
        {
            throw new NotImplementedException();
        }

        public Medicine Select(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Medicine t)
        {
            throw new NotImplementedException();
        }
    }
}
