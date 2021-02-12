using AutoMapper;
using CleverBit.API.Model;
using CleverBit.Core;

namespace CleverBit.API.Mapper
{
    public class MapperConfg : Profile
    {
        public MapperConfg()
        {
            CreateMap<EmployeeModel, Employee>();
        }
    }
}
