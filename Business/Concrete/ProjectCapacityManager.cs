using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectCapacityManager : IProjectCapacityService
    {
        IProjectCapacityDal _projectCapacityDal;

        public ProjectCapacityManager(IProjectCapacityDal projectCapacityDal)
        {
            _projectCapacityDal = projectCapacityDal;
        }

        public IResult Add(ProjectCapacity projectCapacity)
        {
            _projectCapacityDal.Add(projectCapacity);
            return new SuccessResult();
        }

        public IResult Update(ProjectCapacity projectCapacity)
        {
            _projectCapacityDal.Update(projectCapacity);
            return new SuccessResult();
        }

        public IResult Delete(ProjectCapacity projectCapacity)
        {
            _projectCapacityDal.Delete(projectCapacity);
            return new SuccessResult();
        }

        public IDataResult<List<ProjectCapacity>> GetAllByProjectId(int id)
        {
            var result = _projectCapacityDal.GetAll(p => p.ProjectId == id);

            if (result == null)
                return new ErrorDataResult<List<ProjectCapacity>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<ProjectCapacity>>(result, Messages.ProjectListed);
        }

        public IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetails()
        {
            return new SuccessDataResult<List<ProjectCapacityDetailDto>>(_projectCapacityDal.GetProjectCapacityDetails());
        }

        public IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateAndProjectName(DateTime date, string projectName)
        {
            var result = _projectCapacityDal.GetProjectCapacityDetails(p => p.Date == date && p.ProjectName == projectName);

            if (result.Count == 0)
                return new ErrorDataResult<List<ProjectCapacityDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<ProjectCapacityDetailDto>>(result, Messages.ProjectListed);
        }

        public IDataResult<ProjectCapacity> GetProjectCapacityByDateAndProjectId(DateTime date, int projectId)
        {
            var result = _projectCapacityDal.Get(p => p.Date == date && p.ProjectId == projectId);

            if (result == null)
                return new ErrorDataResult<ProjectCapacity>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<ProjectCapacity>(result, Messages.ProjectListed);
        }

        public IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateBetweenAndDepartmentId(DateTime dateStart, DateTime dateEnd, int departmentId)
        {
            var result = _projectCapacityDal.GetProjectCapacityDetails(p => p.Date >= dateStart && p.Date <= dateEnd && p.DepartmentId == departmentId);

            if (result.Count == 0)
                return new ErrorDataResult<List<ProjectCapacityDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<ProjectCapacityDetailDto>>(result, Messages.ProjectListed);
        }

        public IDataResult<List<ProjectCapacityDetailDto>> GetAllByDepartmentId(int departmentId)
        {
            var result = _projectCapacityDal.GetProjectCapacityDetails(p => p.DepartmentId == departmentId);

            if (result == null)
                return new ErrorDataResult<List<ProjectCapacityDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<ProjectCapacityDetailDto>>(result, Messages.DepartmentListed);
        }

        public IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateBetween(DateTime dateStart, DateTime dateEnd)
        {
            var result = _projectCapacityDal.GetProjectCapacityDetails(p => p.Date >= dateStart && p.Date <= dateEnd);

            if (result == null)
                return new ErrorDataResult<List<ProjectCapacityDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<ProjectCapacityDetailDto>>(result, Messages.DepartmentListed);
        }
    }
}
