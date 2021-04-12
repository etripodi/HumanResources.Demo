using Nacho.JuanAlvarez.Empleados;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;


namespace Nacho.NachEmpleado
{
    public class JuanAlvarezDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Empleado, Guid> _empleadoRepository;

        public JuanAlvarezDataSeederContributor(IRepository<Empleado, Guid> empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _empleadoRepository.GetCountAsync() <= 0)
            {
                await _empleadoRepository.InsertAsync(
                    new Empleado
                    {
                        NombreApellido = "Juan Ignacio",
                        Mail = "Nacho12@gmail.com",
                        Celular = 1194879384,
                        Pais = "Argentina",
                        Localidad = "Buenos Aires",
                        NroBusqueda = 505,
                        AreaPuesto = "Sistemas",
                        FechaPostulacion = new DateTime(2020, 6, 8),
                        Postulacion = "Referido",
                        RemPretendida = 35.000f,
                        DisponibilidadViaje = EmpleadoDisponibilidadViaje.Si,
                        Estado = EmpleadoEstado.Pendiente,
                        Comentario = "la verdad que para tikitiki takakaka.",
                        Valoracion = EmpleadoValoracion.A
                    },
                    autoSave: true
                );

                await _empleadoRepository.InsertAsync(
                    new Empleado
                    {
                        NombreApellido = "Pedro Alfonzo",
                        Mail = "juanidjd@gmail.com",
                        Celular = 1159487915,
                        Pais = "Uruguay",
                        Localidad = "Montevideo",
                        NroBusqueda = 650,
                        AreaPuesto = "Mantenimiento",
                        FechaPostulacion = new DateTime(2021, 3, 10),
                        Postulacion = "Linkedin",
                        RemPretendida = 25.000f,
                        DisponibilidadViaje = EmpleadoDisponibilidadViaje.Si,
                        Estado = EmpleadoEstado.Pendiente,
                        Comentario = "Orwer and the dystopianNineteen Eighty-Four (1949).",
                        Valoracion = EmpleadoValoracion.B
                    },
                    autoSave: true
                );

            }
        }
    }
}