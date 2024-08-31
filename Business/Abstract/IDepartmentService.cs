using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        IDataResult<List<Department>> GetAll();
        IDataResult<List<Department>> GetByManagementId(int id);

        IResult Add(Department department);
        IResult Update(Department department);
        IResult Delete(Department department);
    }
}
