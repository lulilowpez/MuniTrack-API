using Application.Dtos;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CitizenService
    {
        private readonly ICitizenRepository _citizenRepository;

        public CitizenService(ICitizenRepository citizenRepository)
        {
            _citizenRepository = citizenRepository;
        }
        public List<Citizen> GetCitizen()
        {
            return _citizenRepository.GetAllCitizens();
        }
        public void CreateCitizen(CreateCitizenDto Dto)
        {
            var existingCitizen = _citizenRepository.GetCitizenByDni(Dto.DNI);
            if (existingCitizen != null)
                throw new Exception($"Ya existe un ciudadano con DNI {Dto.DNI}");

            Citizen newCitizen = new Citizen()
            {
                DNI = Dto.DNI,
                Name = Dto.Name,
                LastName = Dto.LastName,
                Adress = Dto.Adress,
                Phone = Dto.Phone,
                Email = Dto.Email,
            };
            _citizenRepository.AddCitizen(newCitizen);

        }

        public bool DeleteCitizen(int dni)
        {
            var citizenDelete = _citizenRepository.GetCitizenByDni(dni);
            if (citizenDelete is null)
                return false;

            citizenDelete.Deleted = 1;
            _citizenRepository.UpdateCitizen(citizenDelete);
            return true;

        }

        public Citizen? GetCitizenByDni(int dni)
        {
            return _citizenRepository.GetCitizenByDni(dni);

        }


    }
}
