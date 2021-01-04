using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataMangers.Interfaces
{
    interface IDefaultDataManager
    {
        bool Add(Object obj);
        bool Delete(int id);
        bool Update(Object obj);
        List<Object> Select();
        List<Object> Select(int Id);
    }
}
