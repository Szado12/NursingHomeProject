using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.LogicalManagers
{
    class ScheduleManager
    {
        ScheduleDataManager scheduleDataManager = new ScheduleDataManager();
        public bool Add(int PatientId,int PlaceId, int EmployeeId, int TreatmentId, DateTime Term)
        {
            Schedule newSchedule = new Schedule()
            {
                PatientId = PatientId,
                PlaceId = PlaceId,
                EmployeeId = EmployeeId,
                TreatmentId = TreatmentId,
                Term = Term
            };
            return scheduleDataManager.Add(newSchedule);
        }
        public bool Delete(int Id)
        {
            return scheduleDataManager.Delete(Id);
        }
        public bool Update(int Id, int PatientId, int PlaceId, int EmployeeId, int TreatmentId, DateTime Term)
        {
            Schedule newSchedule = new Schedule()
            {
                Id = Id,
                PatientId = PatientId,
                PlaceId = PlaceId,
                EmployeeId = EmployeeId,
                TreatmentId = TreatmentId,
                Term = Term
            };
            return scheduleDataManager.Update(newSchedule);
        }
        public List<ScheduleView> Select()
        {
            return scheduleDataManager.Select();
        }
        public ScheduleView Select(int Id)
        {
            return scheduleDataManager.Select(Id);
        }
        public List<ScheduleView> SelectIdEmployee(int Id)
        {
            return scheduleDataManager.SelectIdEmployee(Id);
        }
        public List<ScheduleView> SelectIdPatient(int Id)
        {
            return scheduleDataManager.SelectIdPatient(Id);
        }
        public List<ScheduleView> SelectFilteredEmployee(int Id, int treatmentId)
        {
            return scheduleDataManager.SelectFilteredEmployee(Id, treatmentId);
        }
        public List<ScheduleView> SelectFilteredPatient(int Id, int treatmentId)
        {
            return scheduleDataManager.SelectFilteredPatient(Id, treatmentId);
        }
    }
}
