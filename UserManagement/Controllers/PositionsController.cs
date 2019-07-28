using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;
using UserManagement.Repositories;
using UserManagement.Repositories.Interfaces;
using UserManagement.ViewModels;

namespace UserManagement.Controllers
{
    public class PositionsController
    {
        public IPositionRepository iPositionRepository = new PositionRepository();

        public List<Position> Get()
        {
            return iPositionRepository.Get();
        }

        public Position Get(int id)
        {
            return iPositionRepository.Get(id);
        }

        public List<Position> Get(string value)
        {
            return iPositionRepository.Get(value);
        }

        public bool Insert(PositionVM positionVM)
        {
            return iPositionRepository.Insert(positionVM);
        }

        public bool Update(int id, PositionVM positionVM)
        {
            return iPositionRepository.Update(id, positionVM);
        }

        public bool Delete(int id)
        {
            return iPositionRepository.Delete(id);
        }
    }
}
