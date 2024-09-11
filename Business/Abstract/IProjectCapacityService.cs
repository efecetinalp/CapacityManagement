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

        IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateAndDepartmentId(DateTime date, int id);
        IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateAndProjectName(DateTime date, string projectName);

        IDataResult<List<ProjectCapacity>> GetAllByProjectId(int id);
    }
}
