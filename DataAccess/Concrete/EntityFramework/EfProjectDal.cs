using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProjectDal : EfEntityRepositoryBase<Project, CapacityDBContext>, IProjectDal
    {
        public List<ProjectDetailDto> GetProjectDetails()
        {
            using (CapacityDBContext context = new CapacityDBContext())
            {
                var result = from p in context.Projects
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             join d in context.Departments on p.DepartmentId equals d.DepartmentId
                             select new ProjectDetailDto
                             {
                                 ProjectId = p.ProjectId,
                                 ProjectName = p.ProjectName,
                                 CategoryName = c.CategoryName,
                                 DepartmentName = d.DepartmentName,
                                 StartDate = p.StartDate,
                                 EndDate = p.EndDate,
                             };
                return result.ToList();
            }
        }
    }
}
