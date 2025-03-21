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
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public IResult Add(Department department)
        {
            _departmentDal.Add(department);
            return new SuccessResult(Messages.DepartmentAdded);
        }   

        public IResult Update(Department department)
        {
            _departmentDal.Update(department);
            return new SuccessResult(Messages.DepartmentUpdated);
        }

        public IResult Delete(Department department)
        {
            _departmentDal.Delete(department);
            return new SuccessResult(Messages.DepartmentDeleted);
        }

        public IDataResult<List<Department>> GetAll()
        {
            return new SuccessDataResult<List<Department>>(_departmentDal.GetAll());
        }

        public IDataResult<List<Department>> GetAllByManagementId(int id)
        {
            return new SuccessDataResult<List<Department>>(_departmentDal.GetAll(d => d.ManagementId == id));
        }

        public IDataResult<List<Department>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Department>>(_departmentDal.GetAll(d => d.DepartmentId == id));
        }

        public IDataResult<Department> GetByName(string departmentName)
        {
            Department result = _departmentDal.Get(d => d.DepartmentName == departmentName);

            if (result != null)
                return new SuccessDataResult<Department>(result, Messages.DepartmentListed);
            else
                return new ErrorDataResult<Department>(result, Messages.EmptyData);
        }

        public IDataResult<List<DepartmentDetailDto>> GetDepartmentDetails()
        {
            List<DepartmentDetailDto> result = _departmentDal.GetDepartmentDetails();

            if (result.Count == 0)
                return new ErrorDataResult<List<DepartmentDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<DepartmentDetailDto>>(result, Messages.ProjectListed);
        }

        public IDataResult<List<DepartmentDetailDto>> GetDepartmentDetails(int managementId)
        {
            List<DepartmentDetailDto> result = _departmentDal.GetDepartmentDetails(d => d.ManagementId == managementId);

            if (result.Count == 0)
                return new ErrorDataResult<List<DepartmentDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<DepartmentDetailDto>>(result, Messages.ProjectListed);
        }
    }
}
