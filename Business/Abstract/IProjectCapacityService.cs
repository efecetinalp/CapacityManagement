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
    public interface IProjectCapacityService
    {
        IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetails();

        IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateBetweenAndDepartmentId(DateTime dateStart, DateTime dateEnd, int departmentId);
        IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateAndProjectName(DateTime date, string projectName);
        IDataResult<ProjectCapacity> GetProjectCapacityByDateAndProjectId(DateTime date, int projectId);


        IDataResult<List<ProjectCapacity>> GetAllByProjectId(int id);

        IResult Add(ProjectCapacity projectCapacity);
        IResult Update(ProjectCapacity projectCapacity);
        IResult Delete(ProjectCapacity projectCapacity);
    }
}
