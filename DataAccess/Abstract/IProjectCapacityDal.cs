using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IProjectCapacityDal : IEntityRepository<ProjectCapacity>
    {
        List<ProjectCapacityDetailDto> GetProjectCapacityDetails(Expression<Func<ProjectCapacityDetailDto, bool>> filter = null);
        List<ProjectCapacityDetailDto> GetProjectCapacityDetails();
    }
}
