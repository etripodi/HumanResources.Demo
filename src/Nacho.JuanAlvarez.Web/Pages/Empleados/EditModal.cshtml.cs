using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nacho.JuanAlvarez.Empleados;

namespace Nacho.JuanAlvarez.Web.Pages.Empleados
{
    public class EditModalModel : JuanAlvarezPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateEmpleadoDto Empleado { get; set; }

        private readonly IEmpleadoAppService _empleadoAppService;

        public EditModalModel(IEmpleadoAppService empleadoAppService)
        {
            _empleadoAppService = empleadoAppService;
        }

        public async Task OnGetAsync()
        {
            var empleadoDto = await _empleadoAppService.GetAsync(Id);
            Empleado = ObjectMapper.Map<EmpleadoDto, CreateUpdateEmpleadoDto>(empleadoDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _empleadoAppService.UpdateAsync(Id, Empleado);
            return NoContent();
        }
    }
}
