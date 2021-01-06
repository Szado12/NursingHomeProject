using NursingHomeApp.Systems.DataMangers.Interfaces;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers.Interfaces
{
    public interface IPatientMedicineDataManger : IDefaultDataManager<PatientMedicine, PatientMedicineView>
    {
        List<PatientMedicineView> SelectPatientMedicine(int Id);
        List<PatientMedicineView> SelectAll(int Id);
    }
}
