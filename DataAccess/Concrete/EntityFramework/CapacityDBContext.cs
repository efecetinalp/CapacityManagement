using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CapacityDBContext : DbContext
    {
        string path;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string

            //for ms sql
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CapacityDB;Trusted_Connection=true");

            //for ms access
            //string path = @"C:\Users\ECETINALP\Desktop\CapacityManagement\CapacityDB.accdb";
            //string path = @"C:\Users\Efe\source\repos\CapacityManagement\CapacityDB.accdb";

            //var path = System.AppDomain.CurrentDomain.BaseDirectory;
            //path = path.Substring(0, path.Length - 56);
            //path += "CapacityDB.accdb";

            //USE WHEN PUBLISHING
            //var exePath = Path.GetDirectoryName(
            //   new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            //Debug.Print(exePath);
            //optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + exePath + "\\CapacityDB.accdb;Persist Security Info = False;");
            //USE WHEN PUBLISHING
            
            optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\ECETINALP\Desktop\Tools\Capacity Management\CapacityDB.accdb;Persist Security Info = False;");
            //optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Efe\source\repos\CapacityManagement\CapacityDB.accdb;Persist Security Info = False;");
            
            //optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + path + ";Persist Security Info = False;");

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
