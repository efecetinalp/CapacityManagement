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
        IDataResult<List<Project>> GetAllByCategoryId(int categoryId);
        IDataResult<List<Project>> GetByDate(DateTime date);
        IDataResult<List<Project>> GetByDateBetween(DateTime startDate, DateTime endDate);
        IDataResult<List<ProjectDetailDto>> GetProjectDetails();
        IDataResult<List<ProjectDetailDto>> GetProjectDetails(int managementId);
        IDataResult<List<ProjectDetailDto>> GetProjectDetails(int managementId, int departmentId);
        IDataResult<List<ProjectDetailDto>> GetProjectDetails(int managementId, int departmentId, int categoryId);

        IDataResult<Project> GetById(int id);

        IResult Add(Project project);
        IResult Update(Project project);
        IResult Delete(Project project);
    }
}
