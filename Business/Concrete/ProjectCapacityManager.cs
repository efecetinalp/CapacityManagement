﻿using Business.Abstract;
using Business.Constants;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProjectCapacityManager : IProjectCapacityService
    {
        IProjectCapacityDal _projectCapacityDal;

        public ProjectCapacityManager(IProjectCapacityDal projectCapacityDal)
        {
            _projectCapacityDal = projectCapacityDal;
        }

        public IResult Add(IEntity projectCapacity)
        {
            _projectCapacityDal.Add(projectCapacity as ProjectCapacity);
            return new SuccessResult(Messages.ProjectCapacityAdded);
        }

        public IResult Update(IEntity projectCapacity)
        {
            _projectCapacityDal.Update(projectCapacity as ProjectCapacity);
            return new SuccessResult(Messages.ProjectCapacityUpdated);
        }

        public IResult Delete(IEntity projectCapacity)
        {
            _projectCapacityDal.Delete(projectCapacity as ProjectCapacity);
            return new SuccessResult(Messages.ProjectCapacityDeleted);
        }

        public IDataResult<List<ProjectCapacity>> GetAllByProjectId(int id)
        {
            var result = _projectCapacityDal.GetAll(p => p.ProjectId == id);

            if (result != null)
                return new SuccessDataResult<List<ProjectCapacity>>(result, Messages.ProjectCapacityListed);
            else
                return new ErrorDataResult<List<ProjectCapacity>>(result, Messages.EmptyData);
        }

        public IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetails()
        {
            var result = _projectCapacityDal.GetProjectCapacityDetails();

            if (result != null)
                return new SuccessDataResult<List<ProjectCapacityDetailDto>>(result, Messages.ProjectCapacityListed);
            else
                return new ErrorDataResult<List<ProjectCapacityDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateAndProjectName(DateTime date, string projectName)
        {
            var result = _projectCapacityDal.GetProjectCapacityDetails(p => p.Date == date && p.ProjectName == projectName);

            if (result != null)
                return new SuccessDataResult<List<ProjectCapacityDetailDto>>(result, Messages.ProjectCapacityListed);
            else
                return new ErrorDataResult<List<ProjectCapacityDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<ProjectCapacity> GetProjectCapacityByDateAndProjectId(DateTime date, int projectId)
        {
            var result = _projectCapacityDal.Get(p => p.Date == date && p.ProjectId == projectId);

            if (result != null)
                return new SuccessDataResult<ProjectCapacity>(result, Messages.ProjectCapacityListed);
            else
                return new ErrorDataResult<ProjectCapacity>(result, Messages.EmptyData);
        }

        public IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateBetweenAndDepartmentId(DateTime dateStart, DateTime dateEnd, int departmentId)
        {
            var result = _projectCapacityDal.GetProjectCapacityDetails(p => p.Date >= dateStart && p.Date <= dateEnd && p.DepartmentId == departmentId);

            if (result != null)
                return new SuccessDataResult<List<ProjectCapacityDetailDto>>(result, Messages.ProjectCapacityListed);
            else
                return new ErrorDataResult<List<ProjectCapacityDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<List<ProjectCapacityDetailDto>> GetAllByDepartmentId(int departmentId)
        {
            var result = _projectCapacityDal.GetProjectCapacityDetails(p => p.DepartmentId == departmentId);

            if (result != null)
                return new SuccessDataResult<List<ProjectCapacityDetailDto>>(result, Messages.ProjectCapacityListed);
            else
                return new ErrorDataResult<List<ProjectCapacityDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateBetween(DateTime dateStart, DateTime dateEnd)
        {
            var result = _projectCapacityDal.GetProjectCapacityDetails(p => p.Date >= dateStart && p.Date <= dateEnd);

            if (result != null)
                return new SuccessDataResult<List<ProjectCapacityDetailDto>>(result, Messages.ProjectCapacityListed);
            else
                return new ErrorDataResult<List<ProjectCapacityDetailDto>>(result, Messages.EmptyData);
        }
    }
}
