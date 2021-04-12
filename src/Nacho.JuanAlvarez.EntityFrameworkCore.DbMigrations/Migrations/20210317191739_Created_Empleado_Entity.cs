using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nacho.JuanAlvarez.Migrations
{
    public partial class Created_Empleado_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppEmpleados",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreApellido = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<int>(type: "int", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NroBusqueda = table.Column<int>(type: "int", nullable: false),
                    AreaPuesto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaPostulacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Postulacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemPretendida = table.Column<float>(type: "real", nullable: false),
                    DisponibilidadViaje = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valoracion = table.Column<int>(type: "int", nullable: false),
                    SubirArchivo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEmpleados", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppEmpleados");
        }
    }
}
