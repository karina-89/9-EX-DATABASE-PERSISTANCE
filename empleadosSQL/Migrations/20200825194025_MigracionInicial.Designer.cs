﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using empleadosSQL.Data;

namespace empleadosSQL.Migrations
{
    [DbContext(typeof(EmpleadoContexto))]
    [Migration("20200825194025_MigracionInicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("empleadosSQL.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Cargo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Sueldo")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("EmpleadoItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellidos = "Pérez",
                            Cargo = "Administrativo",
                            Nombre = "Juan",
                            Sueldo = 24000.0
                        },
                        new
                        {
                            Id = 2,
                            Apellidos = "López",
                            Cargo = "Administrativa",
                            Nombre = "Marta",
                            Sueldo = 24000.0
                        },
                        new
                        {
                            Id = 3,
                            Apellidos = "Rodríguez",
                            Cargo = "Mozo de almacén",
                            Nombre = "Raúl",
                            Sueldo = 20000.0
                        },
                        new
                        {
                            Id = 4,
                            Apellidos = "Guijarro",
                            Cargo = "Comercial",
                            Nombre = "Luís",
                            Sueldo = 26000.0
                        },
                        new
                        {
                            Id = 5,
                            Apellidos = "Sánchez",
                            Cargo = "Ventas",
                            Nombre = "Núria",
                            Sueldo = 26000.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
