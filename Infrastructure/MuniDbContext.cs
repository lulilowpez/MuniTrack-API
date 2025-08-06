using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class MuniDbContext : DbContext
    {
        public MuniDbContext()
        {

        }

        public MuniDbContext(DbContextOptions<MuniDbContext> options) : base(options)
        {

        }
    }
}
