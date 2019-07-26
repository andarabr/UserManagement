using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Context;
using UserManagement.Models;
using UserManagement.Repositories.Interfaces;
using UserManagement.ViewModels;

namespace UserManagement.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private bool status = false;
        private ApplicationContext applicationContext = new ApplicationContext();

        public bool Delete(int id)
        {
            var get = Get(id);
            get.Delete();
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public List<Position> Get()
        {
            var get = applicationContext.Position.Where(x => x.IsDeleted == false).ToList();
            return get;
        }

        public List<Position> Get(string value)
        {
            //roles di application context class
            var get = applicationContext.Position.Where(x => (x.Name.Contains(value) || Convert.ToString(x.Id).Contains(value)) && x.IsDeleted == false).ToList();
            return get;
        }

        public Position Get(int id)
        {
            var get = applicationContext.Position.SingleOrDefault(x => x.IsDeleted == false && x.Id == id);
            return get;
        }

        public bool Insert(PositionVM positionVM)
        {
            var push = new Position(positionVM);
            applicationContext.Position.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, PositionVM positionVM)
        {
            var get = Get(id);
            get.Update(positionVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}
