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
        public List<ProjectDetailDto> GetProjectDetails(Expression<Func<ProjectDetailDto, bool>> filter = null)
        {
            using (CapacityDBContext context = new CapacityDBContext())
            {
                var result = from p in context.Projects
                             join m in context.Managements on p.ManagementId equals m.ManagementId
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             join d in context.Departments on p.DepartmentId equals d.DepartmentId
                             select new ProjectDetailDto
                             {
                                 ProjectId = p.ProjectId,
                                 ManagementId = p.ManagementId,
                                 DepartmentId = p.DepartmentId,
                                 CategoryId = p.CategoryId,
                                 ProjectName = p.ProjectName,
                                 ManagementName = m.ManagementName,
                                 DepartmentName = d.DepartmentName,
                                 CategoryName = c.CategoryName,
                                 StartDate = p.StartDate,
                                 EndDate = p.EndDate,
                             };

                if (filter == null)
                    return result.ToList();
                else
                    return result.Where(filter).OrderBy(x => x.CategoryId).OrderBy(x => x.DepartmentId).OrderBy(x => x.ManagementId).ToList();
            }
        }
    }
}
