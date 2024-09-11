using Business.Abstract;
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
    public class DepartmentCapacityManager : IDepartmentCapacityService
    {
        IDepartmentCapacityDal _departmentCapactiyDal;

        public DepartmentCapacityManager(IDepartmentCapacityDal departmentCapactiyDal)
        {
            _departmentCapactiyDal = departmentCapactiyDal;
        }

        public IDataResult<List<DepartmentCapacityDetailDto>> GetAllByDateAndDepartmentName(DateTime date, string departmentName)
        {
            var result = _departmentCapactiyDal.GetDepartmentCapacityDetails(p => p.Date == date && p.DepartmentName == departmentName);

            if (result.Count == 0)
                return new ErrorDataResult<List<DepartmentCapacityDetailDto>>(result, Messages.EmptyData);
            else
                return new SuccessDataResult<List<DepartmentCapacityDetailDto>>(result, Messages.ProjectListed);
        }
    }
}
