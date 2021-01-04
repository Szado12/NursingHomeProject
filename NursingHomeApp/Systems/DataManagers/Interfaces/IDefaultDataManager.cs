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
        bool Delete(int Id);
        bool Update(T t);
        List<T> Select();
        T Select(int Id);
    }
}
