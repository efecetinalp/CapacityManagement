using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDepartmentCapacityDal : IEntityRepository<DepartmentCapacity>
    {
        List<DepartmentCapacityDetailDto> GetDepartmentCapacityDetails(Expression<Func<DepartmentCapacityDetailDto, bool>> filter = null);
        List<DepartmentCapacityDetailDto> GetDepartmentCapacityDetails();
    }
}
