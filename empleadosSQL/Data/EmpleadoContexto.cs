using empleadosSQL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace empleadosSQL.Data
{
    public class EmpleadoContexto : DbContext
    {
        public EmpleadoContexto(DbContextOptions<EmpleadoContexto> options) : base(options)
        {
        }

        // Crear el DbSet
        public DbSet<Empleado> EmpleadoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>().HasData(new Empleado[]
            {
                new Empleado { Id = 1, Nombre = "Juan", Apellidos = "Pérez", Cargo = "Administrativo" , Sueldo = 24000 },
                new Empleado { Id = 2, Nombre = "Marta", Apellidos = "López", Cargo = "Administrativa" , Sueldo = 24000 },
                new Empleado { Id = 3, Nombre = "Raúl", Apellidos = "Rodríguez", Cargo = "Mozo de almacén" , Sueldo = 20000 },
                new Empleado { Id = 4, Nombre = "Luís", Apellidos = "Guijarro", Cargo = "Comercial" , Sueldo = 26000 },
                new Empleado { Id = 5, Nombre = "Núria", Apellidos = "Sánchez", Cargo = "Ventas" , Sueldo = 26000 }
            });
        }
    }
}
