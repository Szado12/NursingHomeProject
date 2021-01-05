using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers
{
    public class DefaultDataManager
    {
        protected readonly NursingHomeEntities DbContext = new NursingHomeEntities();
    }
}
