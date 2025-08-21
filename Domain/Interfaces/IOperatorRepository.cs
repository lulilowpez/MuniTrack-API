using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IOperatorRepository: IBaseRepository<Operator>
    {
        void AddOperator(Operator Operator);
        List<Operator> GetOperators();
    }
}
