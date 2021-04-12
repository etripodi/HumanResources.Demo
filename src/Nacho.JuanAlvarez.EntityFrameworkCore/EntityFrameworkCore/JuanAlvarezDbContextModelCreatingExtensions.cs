using Microsoft.EntityFrameworkCore;
using Nacho.JuanAlvarez.Empleados;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Nacho.JuanAlvarez.EntityFrameworkCore
{
    public static class JuanAlvarezDbContextModelCreatingExtensions
    {
        public static void ConfigureJuanAlvarez(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Empleado>(b =>
            {
                b.ToTable(JuanAlvarezConsts.DbTablePrefix + "Empleados", JuanAlvarezConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.NombreApellido).IsRequired().HasMaxLength(128);
            });
        }
    }
}

