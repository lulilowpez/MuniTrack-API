using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Infrastructure.Repository
{
    public class OperatorRepository : BaseRepository<Operator>, IOperatorRepository
    {
     
        public OperatorRepository(MuniDbContext _context) : base(_context)
        {

        }

        public void AddOperator(Operator Operator)
        {
            _muniDbContext.Operators.Add(Operator);
            _muniDbContext.SaveChanges();
        }

        public List<Operator> GetOperators()
        {
            return _muniDbContext.Operators.ToList();
        }
    }
}
