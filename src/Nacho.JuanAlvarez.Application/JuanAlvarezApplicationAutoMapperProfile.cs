using AutoMapper;
using Nacho.JuanAlvarez.Empleados;

namespace Nacho.JuanAlvarez
{
    public class JuanAlvarezApplicationAutoMapperProfile : Profile
    {
        public JuanAlvarezApplicationAutoMapperProfile()
        {
            CreateMap<Empleado, EmpleadoDto>();
            CreateMap<CreateUpdateEmpleadoDto, Empleado>();
        }
    }
}
