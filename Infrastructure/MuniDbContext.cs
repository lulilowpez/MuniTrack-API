using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Enum;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class MuniDbContext : DbContext
    {
        public DbSet<Operator> Operators { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Incidence> Incidences { get; set; }
        public MuniDbContext()
        {
        }

        public MuniDbContext(DbContextOptions<MuniDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder) //ésto si es esencial para que por lo menos se cree la tabla vacía
        {
            modelBuilder.Entity<Operator>().HasData(
            new Operator
            {
                DNI = 46502865,
                Name = "Micaela",
                LastName = "Ortigoza",
                NLegajo = 459850,
                Password = "123abc",
                Phone = "3416897542",
                Email = "micaela@example.com",
                Position = Role.OperatorElite,
                Deleted = 0
            },
            new Operator
            {
                DNI = 43567210,
                Name = "Lucas",
                LastName = "Fernandez",
                NLegajo = 459851,
                Password = "abc12345",
                Phone = "3416549871",
                Email = "lucas@example.com",
                Position = Role.OperatorBasic,
                Deleted = 0
            }
            );
            modelBuilder.Entity<Area>().HasData(
        new Area
        {
            Id = 1,
            Name = "Oficina Martin Fierro",
            Description = "Atiende trámites generales",
            Deleted = 0
        },
        new Area
        {
            Id = 2,
            Name = "Oficina Gender",
            Description = "Atiende temas de género",
            Deleted = 0
        }
    );

            // Semilla de Incidencias
            modelBuilder.Entity<Incidence>().HasData(
                new Incidence
                {
                    Id = 1,
                    Date = DateTime.UtcNow,
                    IncidenceType = IncidenceType.FoodBag,
                    Description = "Luz rota en Av. Pellegrini 2000",
                    State = IncidenceState.Started,
                    Deleted = 0,
                    AreaId = 1 
                },
                new Incidence
                {
                    Id = 2,
                    Date = DateTime.UtcNow.AddDays(-2),
                    IncidenceType = IncidenceType.Complaint,
                    Description = "Bache en San Martín y Rioja",
                    State = IncidenceState.InProgress,
                    Deleted = 0,
                    AreaId = 2
                }
            );

            modelBuilder.Entity<Operator>()
              .HasMany(c => c.Citizens)
              .WithMany();

            modelBuilder.Entity<Citizen>()
              .HasMany(c => c.Incidences)
              .WithMany();

            modelBuilder.Entity<Operator>()
              .HasMany(c => c.Incidences)
              .WithMany();

            modelBuilder.Entity<Incidence>()
                .HasOne(e => e.Area)
                .WithOne();
        



            base.OnModelCreating(modelBuilder);
        }
    }
}
