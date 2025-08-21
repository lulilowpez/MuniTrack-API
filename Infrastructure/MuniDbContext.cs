using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class MuniDbContext : DbContext
    {
        public DbSet<Operator> Operators { get; set; }
        public MuniDbContext()
        {
        }

        public MuniDbContext(DbContextOptions<MuniDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder) //ésto si es esencial para que por lo menos se cree la tabla vacía
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
