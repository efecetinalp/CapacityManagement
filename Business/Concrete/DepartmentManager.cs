using Business.Abstract;
using Business.Constants;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public IResult Add(IEntity department)
        {
            _departmentDal.Add(department as Department);
            return new SuccessResult(Messages.DepartmentAdded);
        }

        public IResult Update(IEntity department)
        {
            _departmentDal.Update(department as Department);
            return new SuccessResult(Messages.DepartmentUpdated);
        }

        public IResult Delete(IEntity department)
        {
            _departmentDal.Delete(department as Department);
            return new SuccessResult(Messages.DepartmentDeleted);
        }

        public IDataResult<List<Department>> GetAll()
        {
            var result = _departmentDal.GetAll();

            if (result != null)
                return new SuccessDataResult<List<Department>>(result, Messages.DepartmentListed);
            else
                return new ErrorDataResult<List<Department>>(result, Messages.EmptyData);
        }

        public IDataResult<List<Department>> GetAllByManagementId(int id)
        {
            var result = _departmentDal.GetAll(d => d.ManagementId == id);

            if (result != null)
                return new SuccessDataResult<List<Department>>(result, Messages.DepartmentListed);
            else
                return new ErrorDataResult<List<Department>>(result, Messages.EmptyData);
        }

        public IDataResult<List<Department>> GetAllById(int id)
        {
            var result = _departmentDal.GetAll(d => d.DepartmentId == id);

            if (result != null)
                return new SuccessDataResult<List<Department>>(result, Messages.DepartmentListed);
            else
                return new ErrorDataResult<List<Department>>(result, Messages.EmptyData);
        }

        public IDataResult<Department> GetByName(string departmentName)
        {
            Department result = _departmentDal.Get(d => d.DepartmentName == departmentName);

            if (result != null)
                return new SuccessDataResult<Department>(result, Messages.DepartmentListed);
            else
                return new ErrorDataResult<Department>(result, Messages.EmptyData);
        }

        public IDataResult<Department> GetById(int departmentId)
        {
            Department result = _departmentDal.Get(d => d.DepartmentId == departmentId);

            if (result != null)
                return new SuccessDataResult<Department>(result, Messages.DepartmentListed);
            else
                return new ErrorDataResult<Department>(result, Messages.EmptyData);
        }

        public IDataResult<List<DepartmentDetailDto>> GetDepartmentDetails()
        {
            List<DepartmentDetailDto> result = _departmentDal.GetDepartmentDetails();

            if (result != null)
                return new SuccessDataResult<List<DepartmentDetailDto>>(result, Messages.DepartmentListed);
            else
                return new ErrorDataResult<List<DepartmentDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<List<DepartmentDetailDto>> GetDepartmentDetails(int managementId)
        {
            List<DepartmentDetailDto> result = _departmentDal.GetDepartmentDetails(d => d.ManagementId == managementId);

            if (result != null)
                return new SuccessDataResult<List<DepartmentDetailDto>>(result, Messages.DepartmentListed);
            else
                return new ErrorDataResult<List<DepartmentDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<DepartmentDetailDto> GetDepartmentDetail(int departmentId)
        {
            DepartmentDetailDto result = _departmentDal.GetDepartmentDetail(d => d.DepartmentId == departmentId);

            if (result != null)
                return new SuccessDataResult<DepartmentDetailDto>(result, Messages.DepartmentListed);
            else
                return new ErrorDataResult<DepartmentDetailDto>(result, Messages.EmptyData);
        }
    }
}
