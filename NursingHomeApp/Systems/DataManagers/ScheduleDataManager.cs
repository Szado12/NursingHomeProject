using NursingHomeApp.Systems.DataManagers.Interfaces;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers
{
    public class ScheduleDataManager : DefaultDataManager, IScheduleDataManger
    {
        public bool Add(Schedule t)
        {
            DbContext.Schedules.Add(t);
            return (DbContext.SaveChanges() > 0);
        }

        public bool Delete(int Id)
        {
            Schedule schedule = DbContext.Schedules.SingleOrDefault(p => p.Id == Id);
            DbContext.Schedules.Remove(schedule);
            return (DbContext.SaveChanges() > 0);
        }

        public List<ScheduleView> Select()
        {
            List<Schedule> schedules = DbContext.Schedules.ToList();
            return Mapper.Map<List<Schedule>, List<ScheduleView>>(schedules);
        }

        public ScheduleView Select(int Id)
        {
            Schedule schedule = DbContext.Schedules.SingleOrDefault(p => p.Id == Id);
            ScheduleView scheduleView = Mapper.Map<Schedule, ScheduleView>(schedule);
            return scheduleView;
        }

        public List<ScheduleView> SelectFilteredEmployee(int Id, int treatmentId)
        {
            DbContext = new NursingHomeEntities();
            List<Schedule> schedules = DbContext.Schedules.Where(s => (s.EmployeeId == Id && s.TreatmentId == treatmentId)).ToList();
            return Mapper.Map<List<Schedule>, List<ScheduleView>>(schedules);
        }

        public List<ScheduleView> SelectFilteredPatient(int Id, int treatmentId)
        {
            DbContext = new NursingHomeEntities();
            List<Schedule> schedules = DbContext.Schedules.Where(s => (s.PatientId == Id && s.TreatmentId == treatmentId)).ToList();
            return Mapper.Map<List<Schedule>, List<ScheduleView>>(schedules);
        }

        public List<ScheduleView> SelectIdEmployee(int Id)
        {
            DbContext = new NursingHomeEntities();
            List<Schedule> schedules = DbContext.Schedules.Where(s => s.EmployeeId == Id).ToList();
            return Mapper.Map<List<Schedule>, List<ScheduleView>>(schedules);
        }

        public List<ScheduleView> SelectIdPatient(int Id)
        {
            List<Schedule> schedules = DbContext.Schedules.Where(s => s.PatientId == Id).ToList();
            return Mapper.Map<List<Schedule>, List<ScheduleView>>(schedules);
        }

        public bool Update(Schedule t)
        {
            Schedule schedule = DbContext.Schedules.SingleOrDefault(p => p.Id == t.Id);
            schedule.EmployeeId = t.EmployeeId;
            schedule.PatientId = t.PatientId;
            schedule.PlaceId = t.PlaceId;
            schedule.TreatmentId = t.TreatmentId;
            schedule.Term = t.Term;
            return (DbContext.SaveChanges() > 0);
        }
    }
}
