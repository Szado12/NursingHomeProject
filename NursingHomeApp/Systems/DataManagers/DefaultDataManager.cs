using AutoMapper;
using NursingHomeApp.Mapper;
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
        private static readonly MapperConfiguration mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MapperProfile()));
        protected IMapper Mapper = mapperConfig.CreateMapper();
    }
}
