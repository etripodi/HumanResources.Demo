
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Nacho.JuanAlvarez.Empleados
{
    public class EmpleadoAppService :
        CrudAppService<
            Empleado, //The Book entity
            EmpleadoDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateEmpleadoDto>, //Used to create/update a book
        IEmpleadoAppService //implement the IBookAppService
    {
        public EmpleadoAppService(IRepository<Empleado, Guid> repository)
            : base(repository)
        {

        }
    }
}
