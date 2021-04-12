using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Nacho.JuanAlvarez.Empleados
{
    public interface IEmpleadoAppService :
        ICrudAppService< //Defines CRUD methods
            EmpleadoDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateEmpleadoDto> //Used to create/update a book
    {

    }
}
