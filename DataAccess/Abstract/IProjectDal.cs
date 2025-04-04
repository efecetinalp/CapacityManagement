using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IProjectDal : IEntityRepository<Project>
    {
        List<ProjectDetailDto> GetProjectDetails(Expression<Func<ProjectDetailDto, bool>> filter = null);
        ProjectDetailDto GetProjectDetail(Expression<Func<ProjectDetailDto, bool>> filter);


    }
}
