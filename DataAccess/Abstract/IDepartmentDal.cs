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
    public interface IDepartmentDal : IEntityRepository<Department>
    {
        List<DepartmentDetailDto> GetDepartmentDetails(Expression<Func<DepartmentDetailDto, bool>> filter = null);
        DepartmentDetailDto GetDepartmentDetail(Expression<Func<DepartmentDetailDto, bool>> filter);
    }
}
