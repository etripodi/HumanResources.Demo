using System;
using System.ComponentModel.DataAnnotations;

namespace Nacho.JuanAlvarez.Empleados
{
    public class CreateUpdateEmpleadoDto
    {
        [Required]
        [StringLength(128)]
        public string NombreApellido { get; set; }

        [Required]
        [StringLength(128)]
        public string Mail { get; set; }

        [Required]
        public int Celular { get; set; }

        [Required]
        [StringLength(50)]
        public string Pais { get; set; }

        [Required]
        [StringLength(128)]
        public string Localidad { get; set; }

        [Required]
        public int NroBusqueda { get; set; }

        [Required]
        [StringLength(100)]
        public string AreaPuesto { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaPostulacion { get; set; } = DateTime.Now;

        [Required]
        [StringLength(128)]
        public string Postulacion { get; set; }

        [Required]
        public float RemPretendida { get; set; }

        [Required]
        public EmpleadoDisponibilidadViaje DisponibilidadViaje { get; set; } = EmpleadoDisponibilidadViaje.Check;

        [Required]
        public EmpleadoEstado Estado { get; set; } = EmpleadoEstado.Pendiente;

        [Required]
        [StringLength(500)]
        public string Comentario { get; set; }

        [Required]
        public EmpleadoValoracion Valoracion { get; set; } = EmpleadoValoracion.A;

        
    }
}
