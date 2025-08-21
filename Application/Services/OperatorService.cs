using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class OperatorService : IOperatorService
    {
        private readonly IOperatorRepository _operatorRepository;

        public OperatorService(IOperatorRepository operatorRepository)
        {
            _operatorRepository = operatorRepository;
        }

        public List<Operator> GetOperators()
        {
            return _operatorRepository.GetOperators();
        }
        public void CreateOperator(CreateOperatorDto Dto)
        {
            Operator newOperator = new Operator()
            {
                DNI = Dto.DNI,
                Name = Dto.Name,
                LastName = Dto.LastName,
                NLegajo = Dto.NLegajo,
                Password = Dto.Password,
                Phone = Dto.Phone,
                Email = Dto.Email,
                Position = Dto.Position
            };
            _operatorRepository.AddOperator(newOperator);
        }
    }
}
