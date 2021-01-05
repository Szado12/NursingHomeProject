using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataMangers.Interfaces
{
    public interface IDefaultDataManager<T,S>
    {
        bool Add(T t);
        bool Delete(int Id);
        bool Update(T t);
        List<S> Select();
        S Select(int Id);
    }
}
