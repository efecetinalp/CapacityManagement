using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IDepartmentDal : IEntityRepository<Department>
    {
        List<DepartmentDetailDto> GetDepartmentDetails(Expression<Func<DepartmentDetailDto, bool>> filter = null);
        DepartmentDetailDto GetDepartmentDetail(Expression<Func<DepartmentDetailDto, bool>> filter);
    }
}
