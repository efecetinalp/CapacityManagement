using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProjectCapacityDal : EfEntityRepositoryBase<ProjectCapacity, CapacityDBContext>, IProjectCapacityDal
    {
        public List<ProjectCapacityDetailDto> GetProjectCapacityDetails(Expression<Func<ProjectCapacityDetailDto, bool>> filter = null)
        {
            using (CapacityDBContext context = new CapacityDBContext())
            {
                var result = from p in context.ProjectCapacities
                             join pt in context.Projects on p.ProjectId equals pt.ProjectId
                             join m in context.Managements on pt.ManagementId equals m.ManagementId
                             select new ProjectCapacityDetailDto
                             {
                                 PCapacityId = p.ProjectCapacityId,
                                 ProjectId = pt.DepartmentId,
                                 DepartmentId = pt.DepartmentId,
                                 ManagementId = m.ManagementId,
                                 ProjectName = pt.ProjectName,
                                 PTotalCapacity = p.PTotalCapacity,
                                 Date = p.Date
                             };
                return result.Where(filter).ToList();
            }
        }

        public List<ProjectCapacityDetailDto> GetProjectCapacityDetails()
        {
            using (CapacityDBContext context = new CapacityDBContext())
            {
                var result = from p in context.ProjectCapacities
                             join pt in context.Projects on p.ProjectId equals pt.ProjectId
                             join m in context.Managements on pt.ManagementId equals m.ManagementId
                             select new ProjectCapacityDetailDto
                             {
                                 PCapacityId = p.ProjectCapacityId,
                                 ProjectId = pt.DepartmentId,
                                 DepartmentId = pt.DepartmentId,
                                 ManagementId = m.ManagementId,
                                 ProjectName = pt.ProjectName,
                                 PTotalCapacity = p.PTotalCapacity,
                                 Date = p.Date
                             };
                return result.ToList();
            }
        }
    }
}
