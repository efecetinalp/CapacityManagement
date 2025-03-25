using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProjectService
    {
        IDataResult<List<Project>> GetAll();
        IDataResult<List<Project>> GetAllByUserId(int userId);
        IDataResult<List<Project>> GetAllByCategoryId(int categoryId);
        IDataResult<List<Project>> GetAllByDepartmentId(int departmentId);
        IDataResult<List<Project>> GetAllByDateBetween(DateTime startDate, DateTime endDate);
        IDataResult<List<Project>> GetByDate(DateTime date);
        IDataResult<List<Project>> GetByDateBetween(DateTime startDate, DateTime endDate);
        IDataResult<List<ProjectDetailDto>> GetCategoryByProjectName(string projectName);
        IDataResult<List<ProjectDetailDto>> GetProjectDetails();
        IDataResult<List<ProjectDetailDto>> GetProjectDetailsByDateBetween(DateTime startDate, DateTime endDate);
        IDataResult<List<ProjectDetailDto>> GetProjectDetails(int managementId);
        IDataResult<List<ProjectDetailDto>> GetProjectDetails(int managementId, int departmentId);
        IDataResult<List<ProjectDetailDto>> GetProjectDetails(int managementId, int departmentId, int categoryId);

        IDataResult<Project> GetById(int id);
        IDataResult<Project> GetByName(string projectName);
        IDataResult<ProjectDetailDto> GetProjectDetail(int projectId);


        IResult Add(Project project);
        IResult Update(Project project);
        IResult Delete(Project project);
    }
}
