﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
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

        public IDataResult<List<ProjectCapacity>> GetAllByProjectId(int id)
        {
            return new SuccessDataResult<List<ProjectCapacity>>(_projectCapacityDal.GetAll(p => p.ProjectId == id));
        }

        public IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetails()
        {
            return new SuccessDataResult<List<ProjectCapacityDetailDto>>(_projectCapacityDal.GetProjectCapacityDetails());
        }

        public IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateAndDepartmentId(DateTime date, int id)
        {
            return new SuccessDataResult<List<ProjectCapacityDetailDto>>
                (_projectCapacityDal.GetProjectCapacityDetails(p=> p.PDate == date && p.DepartmentId == id));
        }

        public IDataResult<List<ProjectCapacityDetailDto>> GetProjectCapacityDetailsByDateAndProjectName(DateTime date, string projectName)
        {
            var result =_projectCapacityDal.GetProjectCapacityDetails(p => p.PDate == date && p.ProjectName == projectName);

            if (result.Count == 0)
                return new ErrorDataResult<List<ProjectCapacityDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<ProjectCapacityDetailDto>>(result, Messages.ProjectListed);
        }
    }
}
