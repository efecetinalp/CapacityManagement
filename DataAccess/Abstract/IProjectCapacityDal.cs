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
    public interface IProjectCapacityDal : IEntityRepository<ProjectCapacity>
    {
        List<ProjectCapacityDetailDto> GetProjectCapacityDetails(Expression<Func<ProjectCapacityDetailDto, bool>> filter = null);
        List<ProjectCapacityDetailDto> GetProjectCapacityDetails();
    }
}
