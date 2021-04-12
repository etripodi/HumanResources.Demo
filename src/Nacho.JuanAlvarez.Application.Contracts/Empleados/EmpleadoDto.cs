using System;
using Volo.Abp.Application.Dtos;

namespace Nacho.JuanAlvarez.Empleados
{
    public class EmpleadoDto : AuditedEntityDto<Guid>
    {
        public string NombreApellido { get; set; }

        public string Mail { get; set; }

        public int Celular { get; set; }

        public string Pais { get; set; }

        public string Localidad { get; set; }

        public int NroBusqueda { get; set; }

        public string AreaPuesto { get; set; }

        public DateTime FechaPostulacion { get; set; }

        public string Postulacion { get; set; }

        public float RemPretendida { get; set; }

        public EmpleadoDisponibilidadViaje DisponibilidadViaje { get; set; }

        public EmpleadoEstado Estado { get; set; }

        public string Comentario { get; set; }

        public EmpleadoValoracion Valoracion { get; set; }

        public byte[] SubirArchivo { get; set; }
    }
}