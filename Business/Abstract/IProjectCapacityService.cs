using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProjectCapacityService : IManager
    {
        IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetails();
        IDataResult<List<ProjectCapacityDetailDto>> GetAllByDepartmentId(int departmentId);
        IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateBetweenAndDepartmentId(DateTime dateStart, DateTime dateEnd, int departmentId);
        IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateBetween(DateTime dateStart, DateTime dateEnd);
        IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateAndProjectName(DateTime date, string projectName);
        IDataResult<ProjectCapacity> GetProjectCapacityByDateAndProjectId(DateTime date, int projectId);


        IDataResult<List<ProjectCapacity>> GetAllByProjectId(int id);

        //IResult Add(ProjectCapacity projectCapacity);
        //IResult Update(ProjectCapacity projectCapacity);
        //IResult Delete(ProjectCapacity projectCapacity);
    }
}
