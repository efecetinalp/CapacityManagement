using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public IResult Add(Project project)
        {
            if (project.ProjectName.Length <= 2)
            {
                return new ErrorResult(Messages.ProjectNameInvalid);
            }

            _projectDal.Add(project);
            return new SuccessResult(Messages.ProjectAdded);
        }

        public IResult Update(Project project)
        {
            _projectDal.Update(project);
            return new SuccessResult(Messages.ProjectUpdated);
        }

        public IResult Delete(Project project)
        {
            _projectDal.Delete(project);
            return new SuccessResult(Messages.ProjectDeleted);
        }

        public IDataResult<List<Project>> GetAll()
        {
            return new SuccessDataResult<List<Project>>(_projectDal.GetAll(), Messages.ProjectListed);
        }

        public IDataResult<List<Project>> GetAllByUserId(int userId)
        {
            List<Project> result = _projectDal.GetAll(p => p.UserId == userId);

            if (result == null)
                return new ErrorDataResult<List<Project>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<Project>>(result, Messages.ProjectListed);
        }

        public IDataResult<List<Project>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Project>>(_projectDal.GetAll(p => p.ProjectId == categoryId), Messages.ProjectListed);
        }

        public IDataResult<List<Project>> GetAllByDepartmentId(int departmentId)
        {
            List<Project> result = _projectDal.GetAll(p => p.DepartmentId == departmentId);

            if (result.Count == 0)
                return new ErrorDataResult<List<Project>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<Project>>(result, Messages.ProjectListed);
        }

        public IDataResult<List<Project>> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Project>> GetByDateBetween(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Project> GetById(int id)
        {
            return new SuccessDataResult<Project>(_projectDal.Get(p => p.ProjectId == id), Messages.ProjectListed);
        }

        public IDataResult<List<ProjectDetailDto>> GetProjectDetails()
        {
            List<ProjectDetailDto> result = _projectDal.GetProjectDetails();

            if (result.Count == 0)
                return new ErrorDataResult<List<ProjectDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<ProjectDetailDto>>(result, Messages.ProjectListed);
        }

        public IDataResult<List<ProjectDetailDto>> GetProjectDetails(int managementId)
        {
            List<ProjectDetailDto> result = _projectDal.GetProjectDetails(p => p.ManagementId == managementId);

            if (result.Count == 0)
                return new ErrorDataResult<List<ProjectDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<ProjectDetailDto>>(result, Messages.ProjectListed);
        }

        public IDataResult<List<ProjectDetailDto>> GetProjectDetails(int managementId, int departmentId)
        {
            List<ProjectDetailDto> result = _projectDal.GetProjectDetails(p => p.ManagementId == managementId && p.DepartmentId == departmentId);

            if (result.Count == 0)
                return new ErrorDataResult<List<ProjectDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<ProjectDetailDto>>(result, Messages.ProjectListed);
        }

        public IDataResult<List<ProjectDetailDto>> GetProjectDetails(int managementId, int departmentId, int categoryId)
        {
            List<ProjectDetailDto> result = _projectDal.GetProjectDetails(p => p.ManagementId == managementId && p.DepartmentId == departmentId && p.CategoryId == categoryId);

            if (result.Count == 0)
                return new ErrorDataResult<List<ProjectDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<ProjectDetailDto>>(result, Messages.ProjectListed);
        }

        public IDataResult<Project> GetByName(string projectName)
        {
            Project result = _projectDal.Get(p => p.ProjectName == projectName);

            if (result != null)
                return new SuccessDataResult<Project>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<Project>(result, Messages.EmptyData);
        }

        public IDataResult<List<ProjectDetailDto>> GetCategoryByProjectName(string projectName)
        {
            List<ProjectDetailDto> result = _projectDal.GetProjectDetails(p => p.ProjectName == projectName);

            if (result.Count == 0)
                return new ErrorDataResult<List<ProjectDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<ProjectDetailDto>>(result, Messages.ProjectListed);
        }

        public IDataResult<ProjectDetailDto> GetProjectDetail(int projectId)
        {
            ProjectDetailDto result = _projectDal.GetProjectDetail(p => p.ProjectId == projectId);

            if (result != null)
                return new SuccessDataResult<ProjectDetailDto>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<ProjectDetailDto>(result, Messages.EmptyData);
        }

        
    }
}
