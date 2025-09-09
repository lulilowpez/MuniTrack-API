using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class CitizenRepository : BaseRepository<Citizen>, ICitizenRepository
    {

        public CitizenRepository(MuniDbContext _context) : base(_context)
        {

        }

        public void AddCitizen(Citizen citizen)
        {
            _muniDbContext.Citizens.Add(citizen);
            _muniDbContext.SaveChanges();
        }

        public List<Citizen> GetCitizens()
        {
            return _muniDbContext.Citizens.ToList();
        }

        public Citizen? GetCitizenByDni(int dni)
        {
            return _muniDbContext.Citizens.FirstOrDefault(g => g.DNI == dni);
        }

        public Citizen UpdateCitizen(Citizen citizen)
        {
            _muniDbContext.Update(citizen);
            _muniDbContext.SaveChanges();
            return citizen;
        }
        public void DeleteCitizen(Citizen citizen)
        {
            _muniDbContext.Remove(citizen);
            _muniDbContext.SaveChanges();
        }
        public Operator? GetUserByNLegajoAndPassword(int NLegajo, string Password)
        {
            return _muniDbContext.Operators.FirstOrDefault(p => p.NLegajo == NLegajo && p.Password == Password);
        }
    }



}
