using NursingHomeApp.Systems.DataMangers.Interfaces;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers.Interfaces
{
    public interface IPatientDataManager : IDefaultDataManager<Patient,PatientView>
    {
        List<PatientView> SelectEmployeeId(int Id);
        List<Patient> SelectAll();
    }
}
