using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IColorCodeDal : IEntityRepository<ColorCode>
    {
        List<ColorCodeDetailDto> GetColorCodeDetails(Expression<Func<ColorCodeDetailDto, bool>> filter = null);
    }
}
