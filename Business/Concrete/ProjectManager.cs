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

        public IDataResult<List<Project>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Project>>(_projectDal.GetAll(p => p.ProjectId == categoryId), Messages.ProjectListed);
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
            return new SuccessDataResult<List<ProjectDetailDto>>(_projectDal.GetProjectDetails(), Messages.ProjectListed);
        }
    }
}
