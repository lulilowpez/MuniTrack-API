using Application.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICitizenService
    {

        List<Citizen> GetCitizen();
        void CreateCitizen(CreateCitizenDto Dto);

        bool DeleteCitizen(int dni);

        Operator? GetCitizenByDni(int dni);

        Citizen UpdateCitizen(int dni, UpdateCitizenDto Dto);

    }
}
