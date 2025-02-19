﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDepartmentCapacityService
    {
        IDataResult<List<DepartmentCapacityDetailDto>> GetDepartmentCapacityDetails();

        IDataResult<List<DepartmentCapacityDetailDto>> GetAllByDateAndDepartmentName(DateTime date, string departmentName);
        IDataResult<DepartmentCapacity> GetDepartmentCapacityByDateAndDepartmentId(DateTime date, int departmentId);

        IResult Add(DepartmentCapacity departmentCapacity);
        IResult Update(DepartmentCapacity departmentCapacity);
        IResult Delete(DepartmentCapacity departmentCapacity);
    }
}
