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
    public class DepartmentCapacityManager : IDepartmentCapacityService
    {
        IDepartmentCapacityDal _departmentCapactiyDal;

        public DepartmentCapacityManager(IDepartmentCapacityDal departmentCapactiyDal)
        {
            _departmentCapactiyDal = departmentCapactiyDal;
        }

        public IResult Add(DepartmentCapacity departmentCapacity)
        {
            _departmentCapactiyDal.Add(departmentCapacity);
            return new SuccessResult(Messages.DepartmentCapacityAdded);
        }

        public IResult Update(DepartmentCapacity departmentCapacity)
        {
            _departmentCapactiyDal.Update(departmentCapacity);
            return new SuccessResult(Messages.DepartmentCapacityUpdated);
        }

        public IResult Delete(DepartmentCapacity departmentCapacity)
        {
            _departmentCapactiyDal.Delete(departmentCapacity);
            return new SuccessResult(Messages.DepartmentCapacityDeleted);
        }

        public IDataResult<List<DepartmentCapacityDetailDto>> GetAllByDateAndDepartmentName(DateTime date, string departmentName)
        {
            var result = _departmentCapactiyDal.GetDepartmentCapacityDetails(p => p.Date == date && p.DepartmentName == departmentName);

            if (result != null)
                return new SuccessDataResult<List<DepartmentCapacityDetailDto>>(result, Messages.DepartmentCapacityListed);
            else
                return new ErrorDataResult<List<DepartmentCapacityDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<List<DepartmentCapacityDetailDto>> GetAllByDateBetweenAndDepartmentName(DateTime dateStart, DateTime dateEnd, string departmentName)
        {
            var result = _departmentCapactiyDal.GetDepartmentCapacityDetails(d => d.Date >= dateStart && d.Date <= dateEnd && d.DepartmentName == departmentName);

            if (result != null)
                return new SuccessDataResult<List<DepartmentCapacityDetailDto>>(result, Messages.DepartmentCapacityListed);
            else
                return new ErrorDataResult<List<DepartmentCapacityDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<DepartmentCapacity> GetDepartmentCapacityByDateAndDepartmentId(DateTime date, int departmentId)
        {
            var result = _departmentCapactiyDal.Get(d => d.Date == date && d.DepartmentId == departmentId);

            if (result != null)
                return new SuccessDataResult<DepartmentCapacity>(result, Messages.DepartmentCapacityListed);
            else
                return new ErrorDataResult<DepartmentCapacity>(result, Messages.EmptyData);
        }

        public IDataResult<List<DepartmentCapacityDetailDto>> GetDepartmentCapacityDetails()
        {
            var result = _departmentCapactiyDal.GetDepartmentCapacityDetails();

            if (result != null)
                return new SuccessDataResult<List<DepartmentCapacityDetailDto>>(result, Messages.DepartmentCapacityListed);
            else
                return new ErrorDataResult<List<DepartmentCapacityDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<List<DepartmentCapacity>> GetAllByDepartmentId(int departmentId)
        {
            var result = _departmentCapactiyDal.GetAll(d => d.DepartmentId == departmentId);

            if (result != null)
                return new SuccessDataResult<List<DepartmentCapacity>>(result, Messages.DepartmentCapacityListed);
            else
                return new ErrorDataResult<List<DepartmentCapacity>>(result, Messages.EmptyData);
        }

        public IDataResult<List<DepartmentCapacityDetailDto>> GetAllByDateBetween(DateTime dateStart, DateTime dateEnd)
        {
            var result = _departmentCapactiyDal.GetDepartmentCapacityDetails(d => d.Date >= dateStart && d.Date <= dateEnd);

            if (result != null)
                return new SuccessDataResult<List<DepartmentCapacityDetailDto>>(result, Messages.DepartmentCapacityListed);
            else
                return new ErrorDataResult<List<DepartmentCapacityDetailDto>>(result, Messages.EmptyData);
        }

        public IDataResult<List<DepartmentCapacity>> GetAllUniqueDate()
        {
            var result = _departmentCapactiyDal.GetAll().DistinctBy(p => p.Date).OrderBy(p => p.Date).ToList();

            if (result != null)
                return new SuccessDataResult<List<DepartmentCapacity>>(result, Messages.DepartmentCapacityListed);
            else
                return new ErrorDataResult<List<DepartmentCapacity>>(result, Messages.EmptyData);
        }

        public IDataResult<List<DepartmentCapacity>> GetAllUniqueDateBetween(DateTime dateStart, DateTime dateEnd)
        {
            var result = _departmentCapactiyDal.GetAll(d => d.Date >= dateStart && d.Date <= dateEnd).DistinctBy(p => p.Date).OrderBy(p => p.Date).ToList();

            if (result != null)
                return new SuccessDataResult<List<DepartmentCapacity>>(result, Messages.DepartmentCapacityListed);
            else
                return new ErrorDataResult<List<DepartmentCapacity>>(result, Messages.EmptyData);
        }
    }
}
