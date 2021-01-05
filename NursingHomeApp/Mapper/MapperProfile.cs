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
                .ForMember(s => s.PlacetName, opt => opt.MapFrom(src => src.Place.Name));

            CreateMap<Patient, PatientView>()
                .ForMember(d => d.EmployeeFirstName, opt => opt.MapFrom(src => src.Employee.FirstName))
                .ForMember(d => d.EmployeeLastName, opt => opt.MapFrom(src => src.Employee.LastName))
                .ForMember(d => d.Schedule, opt => opt.MapFrom(src => src.Schedules));


        }
    }
}
