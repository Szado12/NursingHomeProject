using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataMangers.Interfaces
{
    public interface IDefaultDataManager<T>
    {
        bool Add(T t);
        bool Delete(int id);
        bool Update(T t);
        List<Object> Select();
        List<Object> Select(int Id);
    }
}
