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
        public ProjectDetailDto GetProjectDetail(Expression<Func<ProjectDetailDto, bool>> filter)
        {
            using (CapacityDBContext context = new CapacityDBContext())
            {
                var result = from p in context.Projects
                             join m in context.Managements on p.ManagementId equals m.ManagementId
                             join d in context.Departments on p.DepartmentId equals d.DepartmentId
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             join u in context.Users on p.UserId equals u.UserId
                             select new ProjectDetailDto
                             {
                                 ProjectId = p.ProjectId,
                                 ManagementId = p.ManagementId,
                                 DepartmentId = p.DepartmentId,
                                 CategoryId = p.CategoryId,
                                 UserId = p.UserId,
                                 ProjectName = p.ProjectName,
                                 ManagementName = m.ManagementName,
                                 DepartmentName = d.DepartmentName,
                                 CategoryName = c.CategoryName,
                                 isProgressing = p.IsProgressing,
                                 StartDate = p.StartDate,
                                 EndDate = p.EndDate,
                                 UserName = u.UserName,
                             };

               
                    return result.SingleOrDefault(filter);
            }
        }

        public List<ProjectDetailDto> GetProjectDetails(Expression<Func<ProjectDetailDto, bool>> filter = null)
        {
            using (CapacityDBContext context = new CapacityDBContext())
            {
                var result = from p in context.Projects
                             join m in context.Managements on p.ManagementId equals m.ManagementId
                             join d in context.Departments on p.DepartmentId equals d.DepartmentId
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             join u in context.Users on p.UserId equals u.UserId
                             select new ProjectDetailDto
                             {
                                 ProjectId = p.ProjectId,
                                 ManagementId = p.ManagementId,
                                 DepartmentId = p.DepartmentId,
                                 CategoryId = p.CategoryId,
                                 UserId = p.UserId,
                                 ProjectName = p.ProjectName,
                                 ManagementName = m.ManagementName,
                                 DepartmentName = d.DepartmentName,
                                 CategoryName = c.CategoryName,
                                 isProgressing = p.IsProgressing,
                                 StartDate = p.StartDate,
                                 EndDate = p.EndDate,
                                 UserName = u.UserName,
                             };

                if (filter == null)
                    return result.OrderBy(x => x.ManagementId).ToList();
                else
                    return result.Where(filter).OrderBy(x => x.DepartmentId).ToList();
            }
        }
    }
}
