using AutoMapper;
using Nacho.JuanAlvarez.Empleados;

namespace Nacho.JuanAlvarez.Web
{
    public class JuanAlvarezWebAutoMapperProfile : Profile
    {
        public JuanAlvarezWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.
            CreateMap<EmpleadoDto, CreateUpdateEmpleadoDto>();
        }
    }
}
