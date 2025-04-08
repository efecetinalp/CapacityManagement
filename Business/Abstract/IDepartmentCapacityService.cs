using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IDepartmentCapacityService : IManager
    {
        IDataResult<List<DepartmentCapacityDetailDto>> GetDepartmentCapacityDetails();


        IDataResult<List<DepartmentCapacityDetailDto>> GetAllByDateAndDepartmentName(DateTime date, string departmentName);
        IDataResult<List<DepartmentCapacityDetailDto>> GetAllByDateBetweenAndDepartmentName(DateTime dateStart, DateTime dateEnd, string departmentName);
        IDataResult<List<DepartmentCapacityDetailDto>> GetAllByDateBetweenAndDepartmentId(DateTime dateStart, DateTime dateEnd, int departmentId);
        IDataResult<List<DepartmentCapacityDetailDto>> GetAllByDateBetween(DateTime dateStart, DateTime dateEnd);
        IDataResult<List<DepartmentCapacity>> GetAllByDepartmentId(int departmentId);
        IDataResult<List<DepartmentCapacity>> GetAllUniqueDate();
        IDataResult<List<DepartmentCapacity>> GetAllUniqueDateBetween(DateTime dateStart, DateTime dateEnd);
        IDataResult<DepartmentCapacity> GetDepartmentCapacityByDateAndDepartmentId(DateTime date, int departmentId);


        IResult Add(DepartmentCapacity departmentCapacity);
        IResult Update(DepartmentCapacity departmentCapacity);
        IResult Delete(DepartmentCapacity departmentCapacity);
    }
}
