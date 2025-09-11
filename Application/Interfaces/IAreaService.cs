using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IAreaService
    {
        List<Area> GetAreas();
        void CreateArea(CreateAndUpdateAreaDTO Dto);
        bool DeleteArea(int id);
        Area? GetAreaByName(string name);
        Area GetAreaById(int id);
        Area UpdateArea(int id, CreateAndUpdateAreaDTO Dto);

    }
}
