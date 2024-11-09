using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentCapacityDal : EfEntityRepositoryBase<DepartmentCapacity, CapacityDBContext>, IDepartmentCapacityDal
    {
        public List<DepartmentCapacityDetailDto> GetDepartmentCapacityDetails(Expression<Func<DepartmentCapacityDetailDto, bool>> filter = null)
        {
            using (CapacityDBContext context = new CapacityDBContext())
            {
                var result = from dc in context.DepartmentCapacities
                             join d in context.Departments on dc.DepartmentId equals d.DepartmentId
                             select new DepartmentCapacityDetailDto
                             {
                                 DCapacityId = dc.DCapacityId,
                                 DepartmentId = dc.DepartmentId,
                                 DepartmentName = d.DepartmentName,
                                 DTotalCapacity = dc.DTotalCapacity,
                                 Date = dc.Date
                             };
                return result.Where(filter).ToList();
            }
        }

        public List<DepartmentCapacityDetailDto> GetDepartmentCapacityDetails()
        {
            using (CapacityDBContext context = new CapacityDBContext())
            {
                var result = from dc in context.DepartmentCapacities
                             join d in context.Departments on dc.DepartmentId equals d.DepartmentId
                             select new DepartmentCapacityDetailDto
                             {
                                 DCapacityId = dc.DCapacityId,
                                 DepartmentId = dc.DepartmentId,
                                 DepartmentName = d.DepartmentName,
                                 DTotalCapacity = dc.DTotalCapacity,
                                 Date = dc.Date
                             };
                return result.ToList();
            }
        }
    }
}
