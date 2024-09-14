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
            return new SuccessResult();
        }

        public IResult Update(DepartmentCapacity departmentCapacity)
        {
            _departmentCapactiyDal.Update(departmentCapacity);
            return new SuccessResult();
        }

        public IResult Delete(DepartmentCapacity departmentCapacity)
        {
            _departmentCapactiyDal.Delete(departmentCapacity);
            return new SuccessResult();
        }

        public IDataResult<List<DepartmentCapacityDetailDto>> GetAllByDateAndDepartmentName(DateTime date, string departmentName)
        {
            var result = _departmentCapactiyDal.GetDepartmentCapacityDetails(p => p.Date == date && p.DepartmentName == departmentName);

            if (result.Count == 0)
                return new ErrorDataResult<List<DepartmentCapacityDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<DepartmentCapacityDetailDto>>(result, Messages.ProjectListed);
        }

        public IDataResult<DepartmentCapacity> GetDepartmentCapacityByDateAndDepartmentId(DateTime date, int departmentId)
        {
            var result = _departmentCapactiyDal.Get(d => d.Date == date && d.DepartmentId == departmentId);

            if (result == null)
                return new ErrorDataResult<DepartmentCapacity>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<DepartmentCapacity>(result, Messages.DepartmentListed);
        }
    }
}
