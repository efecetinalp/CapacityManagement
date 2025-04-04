using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IDepartmentCapacityDal : IEntityRepository<DepartmentCapacity>
    {
        List<DepartmentCapacityDetailDto> GetDepartmentCapacityDetails(Expression<Func<DepartmentCapacityDetailDto, bool>> filter = null);
        List<DepartmentCapacityDetailDto> GetDepartmentCapacityDetails();
    }
}
