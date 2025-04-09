using Business.Abstract;
using Business.Constants;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public IResult Add(IEntity project)
        {
            _projectDal.Add(project as Project);
            return new SuccessResult(Messages.ProjectAdded);
        }

        public IResult Update(IEntity project)
        {
            _projectDal.Update(project as Project);
            return new SuccessResult(Messages.ProjectUpdated);
        }

        public IResult Delete(IEntity project)
        {
            _projectDal.Delete(project as Project);
            return new SuccessResult(Messages.ProjectDeleted);
        }

        public IDataResult<List<Project>> GetAll()
        {
            List<Project> result = _projectDal.GetAll();

            if (result != null)
                return new SuccessDataResult<List<Project>>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<List<Project>>(result, Messages.EmptyData);
        }

        public IDataResult<List<Project>> GetAllByUserId(int userId)
        {
            List<Project> result = _projectDal.GetAll(p => p.UserId == userId);

            if (result != null)
                return new SuccessDataResult<List<Project>>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<List<Project>>(result, Messages.EmptyData);
        }

        public IDataResult<List<Project>> GetAllByCategoryId(int categoryId)
        {
            List<Project> result = _projectDal.GetAll(p => p.ProjectId == categoryId);

            if (result != null)
                return new SuccessDataResult<List<Project>>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<List<Project>>(result, Messages.EmptyData);
        }

        public IDataResult<List<Project>> GetAllByDepartmentId(int departmentId)
        {
            List<Project> result = _projectDal.GetAll(p => p.DepartmentId == departmentId);

            if (result != null)
                return new SuccessDataResult<List<Project>>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<List<Project>>(result, Messages.EmptyData);
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
            var result = _projectDal.Get(p => p.ProjectId == id);

            if (result != null)
                return new SuccessDataResult<Project>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<Project>(result, Messages.EmptyData);
        }

        public IDataResult<List<ProjectDetailDto>> GetProjectDetails()
        {
            List<ProjectDetailDto> result = _projectDal.GetProjectDetails();

            if (result != null)
                return new SuccessDataResult<List<ProjectDetailDto>>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<List<ProjectDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<List<ProjectDetailDto>> GetProjectDetails(int managementId)
        {
            List<ProjectDetailDto> result = _projectDal.GetProjectDetails(p => p.ManagementId == managementId);

            if (result != null)
                return new SuccessDataResult<List<ProjectDetailDto>>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<List<ProjectDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<List<ProjectDetailDto>> GetProjectDetails(int managementId, int departmentId)
        {
            List<ProjectDetailDto> result = _projectDal.GetProjectDetails(p => p.ManagementId == managementId && p.DepartmentId == departmentId);

            if (result != null)
                return new SuccessDataResult<List<ProjectDetailDto>>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<List<ProjectDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<List<ProjectDetailDto>> GetProjectDetails(int managementId, int departmentId, int categoryId)
        {
            List<ProjectDetailDto> result = _projectDal.GetProjectDetails(p => p.ManagementId == managementId && p.DepartmentId == departmentId && p.CategoryId == categoryId);

            if (result != null)
                return new SuccessDataResult<List<ProjectDetailDto>>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<List<ProjectDetailDto>>(result, Messages.EmptyData);
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

            if (result != null)
                return new SuccessDataResult<List<ProjectDetailDto>>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<List<ProjectDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<ProjectDetailDto> GetProjectDetail(int projectId)
        {
            ProjectDetailDto result = _projectDal.GetProjectDetail(p => p.ProjectId == projectId);

            if (result != null)
                return new SuccessDataResult<ProjectDetailDto>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<ProjectDetailDto>(result, Messages.EmptyData);
        }

        public IDataResult<List<ProjectDetailDto>> GetProjectDetailsByDateBetween(DateTime startDate, DateTime endDate)
        {
            List<ProjectDetailDto> result = _projectDal.GetProjectDetails(p => p.StartDate >= startDate && p.EndDate <= endDate);

            if (result != null)
                return new SuccessDataResult<List<ProjectDetailDto>>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<List<ProjectDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<List<Project>> GetAllByDateBetween(DateTime startDate, DateTime endDate)
        {
            List<Project> result = _projectDal.GetAll(p => p.StartDate >= startDate && p.EndDate <= endDate);

            if (result != null)
                return new SuccessDataResult<List<Project>>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<List<Project>>(result, Messages.EmptyData);
        }
    }
}
