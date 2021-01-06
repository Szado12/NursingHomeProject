using AutoMapper;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Mapper
{
    internal class MapperProfile : Profile
    {
        public MapperProfile()
        {

            CreateMap<Schedule, ScheduleView>()
                .ForMember(s => s.PatientFirstName, opt => opt.MapFrom(src => src.Patient.FirstName))
                .ForMember(s => s.PatientLastName, opt => opt.MapFrom(src => src.Patient.LastName))
                .ForMember(s => s.EmployeeFirstName, opt => opt.MapFrom(src => src.Employee.FirstName))
                .ForMember(s => s.EmployeeLastName, opt => opt.MapFrom(src => src.Employee.LastName))
                .ForMember(s => s.TreatmentName, opt => opt.MapFrom(src => src.Treatment.Name))
                .ForMember(s => s.PlaceName, opt => opt.MapFrom(src => src.Place.Name));

            CreateMap<Patient, PatientView>()
                .ForMember(d => d.EmployeeFirstName, opt => opt.MapFrom(src => src.Employee.FirstName))
                .ForMember(d => d.EmployeeLastName, opt => opt.MapFrom(src => src.Employee.LastName))
                .ForMember(d => d.Schedule, opt => opt.MapFrom(src => src.Schedules));

            CreateMap<Medicine, MedicineView>()
                .ForMember(m => m.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(m => m.Name, opt => opt.MapFrom(src => src.Name));

            CreateMap<PatientMedicine, PatientMedicineView>()
                .ForMember(pm => pm.Name, opt => opt.MapFrom(src => src.Medicine.Name))
                .ForMember(pm => pm.Dose, opt => opt.MapFrom(src => src.Dose))
                .ForMember(pm => pm.Time, opt => opt.MapFrom(src => src.Term));

            CreateMap<Patient, PatientOnListView>();

            CreateMap<Room, RoomView>()
                .ForMember(r => r.Patients, opt => opt.MapFrom(src => src.Patients));

        }
    }
}
