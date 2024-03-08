﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Contextos;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240301120202_CreateDatabase2")]
    partial class CreateDatabase2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Asignacion", b =>
                {
                    b.Property<int>("ConsultorID")
                        .HasColumnType("int");

                    b.Property<int>("ProyectoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Creado")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreadoPor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAsignacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificacionPor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConsultorID", "ProyectoID");

                    b.HasIndex("ProyectoID");

                    b.ToTable("Asignaciones", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Creado")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreadoPor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificacionPor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Consultor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Creado")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreadoPor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificacionPor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Consultores", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Proyectos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Creado")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreadoPor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificacionPor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteID");

                    b.ToTable("Proyectos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Tareas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Creado")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreadoPor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProyectoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificacionPor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoID");

                    b.ToTable("Tareas", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Creado")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreadoPor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RolUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificacionPor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios", (string)null);
                });

            modelBuilder.Entity("ProyectosUsuarios", b =>
                {
                    b.Property<int>("ProyectosId")
                        .HasColumnType("int");

                    b.Property<int>("usuariosId")
                        .HasColumnType("int");

                    b.HasKey("ProyectosId", "usuariosId");

                    b.HasIndex("usuariosId");

                    b.ToTable("ProyectosUsuarios");
                });

            modelBuilder.Entity("Domain.Entities.Asignacion", b =>
                {
                    b.HasOne("Domain.Entities.Consultor", "Consultor")
                        .WithMany("Asignaciones")
                        .HasForeignKey("ConsultorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Proyectos", "Proyecto")
                        .WithMany("Asignaciones")
                        .HasForeignKey("ProyectoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consultor");

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("Domain.Entities.Proyectos", b =>
                {
                    b.HasOne("Domain.Entities.Clientes", "Cliente")
                        .WithMany("proyectos")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Domain.Entities.Tareas", b =>
                {
                    b.HasOne("Domain.Entities.Proyectos", "Proyecto")
                        .WithMany("Tareas")
                        .HasForeignKey("ProyectoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("ProyectosUsuarios", b =>
                {
                    b.HasOne("Domain.Entities.Proyectos", null)
                        .WithMany()
                        .HasForeignKey("ProyectosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Usuarios", null)
                        .WithMany()
                        .HasForeignKey("usuariosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Clientes", b =>
                {
                    b.Navigation("proyectos");
                });

            modelBuilder.Entity("Domain.Entities.Consultor", b =>
                {
                    b.Navigation("Asignaciones");
                });

            modelBuilder.Entity("Domain.Entities.Proyectos", b =>
                {
                    b.Navigation("Asignaciones");

                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
