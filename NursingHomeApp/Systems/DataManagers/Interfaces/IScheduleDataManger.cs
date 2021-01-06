using NursingHomeApp.Systems.DataMangers.Interfaces;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers.Interfaces
{
    public interface IScheduleDataManger : IDefaultDataManager<Schedule, ScheduleView>
    {
        List<ScheduleView> SelectIdPatient(int Id);
        List<ScheduleView> SelectFilteredPatient(int Id, int treatmentId);
        List<ScheduleView> SelectIdEmployee(int Id);
        List<ScheduleView> SelectFilteredEmployee(int Id, int treatmentId);
    }
}
