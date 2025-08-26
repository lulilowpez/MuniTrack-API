using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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



            base.OnModelCreating(modelBuilder);
        }
    }
}
