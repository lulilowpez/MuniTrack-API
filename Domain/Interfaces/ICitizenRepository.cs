using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICitizenRepository : IBaseRepository<Citizen>
    {
        void AddCitizen(Citizen citizen);
        List<Citizen> GetCitizens();
        Citizen? GetCitizenByDni(int NLegajo);
        Citizen UpdateCitizen(Citizen citizen);
        void DeleteCitizen(Citizen citizen);
        
    }
}
