using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Diagnostics;

namespace DataAccess.Concrete.EntityFramework
{
    public class CapacityDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
            //USE WHEN PUBLISHING
            var exePath = Path.GetDirectoryName(
               new Uri(System.Reflection.Assembly.GetExecutingAssembly().Location).LocalPath);

            var dbLocation = exePath + "\\database_path.txt";

            StreamReader streamReader = new StreamReader(dbLocation);

            if (streamReader == null)
            {
                //HANDLE ERROR
            }

            var dbLocationStr = streamReader.ReadLine();
            streamReader.Close();

            optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + dbLocationStr + "; Persist Security Info = False;");
            //optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + exePath + "\\CapacityDB.accdb;Persist Security Info = False;");

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentCapacity> DepartmentCapacities { get; set; }
        public DbSet<Management> Managements { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCapacity> ProjectCapacities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ColorCode> ColorCodes { get; set; }
        public DbSet<ColorPalette> ColorPalettes { get; set; }

    }
}
