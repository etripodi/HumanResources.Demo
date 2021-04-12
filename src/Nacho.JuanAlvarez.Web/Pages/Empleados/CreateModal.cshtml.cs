using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nacho.JuanAlvarez.Empleados;

namespace Nacho.JuanAlvarez.Web.Pages.Empleados
{
    public class CreateModalModel : JuanAlvarezPageModel
    {
        [BindProperty]
        public CreateUpdateEmpleadoDto Empleado { get; set; }

        private readonly IEmpleadoAppService _empleadoAppService;

        public CreateModalModel(IEmpleadoAppService empleadoAppService)
        {
            _empleadoAppService = empleadoAppService;
        }

        public void OnGet()
        {
            Empleado = new CreateUpdateEmpleadoDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _empleadoAppService.CreateAsync(Empleado);
            return NoContent();
        }
    }
}