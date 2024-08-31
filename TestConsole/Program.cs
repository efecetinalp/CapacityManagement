// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ProjectManager projectManager = new ProjectManager(new EfProjectDal());

foreach (var project in projectManager.GetAll().Data)
{
    Console.WriteLine(project.ProjectName);
    
}

foreach (var project in projectManager.GetAllByCategoryId(2).Data)
{
    Console.WriteLine(project.ProjectName);

}



Console.ReadLine();

