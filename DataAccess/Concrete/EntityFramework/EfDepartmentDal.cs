using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentDal : EfEntityRepositoryBase<Department, CapacityDBContext>, IDepartmentDal
    {
        public DepartmentDetailDto GetDepartmentDetail(Expression<Func<DepartmentDetailDto, bool>> filter)
        {
            using (CapacityDBContext context = new CapacityDBContext())
            {
                var result = from d in context.Departments
                             join m in context.Managements on d.ManagementId equals m.ManagementId
                             select new DepartmentDetailDto
                             {
                                 DepartmentId = d.DepartmentId,
                                 DepartmentName = d.DepartmentName,
                                 ManagementName = m.ManagementName,
                                 ManagementId = d.ManagementId
                             };

                return result.SingleOrDefault(filter);
            }
        }

        public List<DepartmentDetailDto> GetDepartmentDetails(Expression<Func<DepartmentDetailDto, bool>> filter = null)
        {
            using (CapacityDBContext context = new CapacityDBContext())
            {
                var result = from d in context.Departments
                             join m in context.Managements on d.ManagementId equals m.ManagementId
                             select new DepartmentDetailDto
                             {
                                 DepartmentId = d.DepartmentId,
                                 DepartmentName = d.DepartmentName,
                                 ManagementName = m.ManagementName,
                                 ManagementId = d.ManagementId
                             };

                if (filter == null)
                    return result.OrderBy(x => x.ManagementId).ToList();
                else
                    return result.Where(filter).OrderBy(x => x.DepartmentId).ToList();
            }
        }
    }
}
