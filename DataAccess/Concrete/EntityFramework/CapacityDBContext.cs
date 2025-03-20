using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class CapacityDBContext : DbContext
    {
        private string _dbLocationStr;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
            if (_dbLocationStr == null)
            {
                try
                {
                    string? exePath = Path.GetDirectoryName(
                        new Uri(System.Reflection.Assembly.GetExecutingAssembly().Location).LocalPath);

                    string dbLocation = exePath + "\\database_path.txt";

                    if (exePath != "")
                        if (File.Exists(dbLocation))
                        {
                            using (StreamReader _streamReader = new StreamReader(dbLocation))
                            {
                                _dbLocationStr = _streamReader.ReadLine();
                                _streamReader.Close();
                            }
                        }
                        else
                            throw new Exception("Database is not found!");
                    else
                        throw new Exception("Database location path is empty!");
                }
                catch (Exception)
                {
                    throw new Exception("Database connection error!");
                }
            }

            optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + _dbLocationStr + "; Persist Security Info = False;");
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
