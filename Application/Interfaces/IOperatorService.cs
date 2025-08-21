using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IOperatorService
    {
        List<Operator> GetOperators();
        void CreateOperator(CreateOperatorDto Dto);
    }
}
