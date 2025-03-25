using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDepartmentCapacityService
    {
        IDataResult<List<DepartmentCapacityDetailDto>> GetDepartmentCapacityDetails();


        IDataResult<List<DepartmentCapacityDetailDto>> GetAllByDateAndDepartmentName(DateTime date, string departmentName);
        IDataResult<List<DepartmentCapacityDetailDto>> GetAllByDateBetweenAndDepartmentName(DateTime dateStart, DateTime dateEnd, string departmentName);
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
