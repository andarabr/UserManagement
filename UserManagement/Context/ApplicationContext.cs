using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("UserManagement") { }

        //Roles dibawah sebagai object
        public DbSet<Role> Role { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Religion> Religion { get; set; }
        public DbSet<Parameter> Parameter { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Login> Login{ get; set; }
        public DbSet<Application> Application { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Regency> Regency { get; set; }
        public DbSet<District> District { get; set; }




    }
}
