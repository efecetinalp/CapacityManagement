using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CapacityDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CapacityDB;Trusted_Connection=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentCapacity> DepartmentCapacities { get; set; }
        public DbSet<Management> Managements { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCapacity> ProjectCapacities { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
