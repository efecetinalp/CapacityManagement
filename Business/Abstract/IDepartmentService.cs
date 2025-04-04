using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        IDataResult<List<Department>> GetAll();
        IDataResult<List<Department>> GetAllByManagementId(int id);
        IDataResult<List<Department>> GetAllById(int id);
        IDataResult<List<DepartmentDetailDto>> GetDepartmentDetails();
        IDataResult<List<DepartmentDetailDto>> GetDepartmentDetails(int managementId);

        IDataResult<Department> GetById(int departmentId);
        IDataResult<Department> GetByName(string departmentName);
        IDataResult<DepartmentDetailDto> GetDepartmentDetail(int departmentId);


        IResult Add(Department department);
        IResult Update(Department department);
        IResult Delete(Department department);
    }
}
