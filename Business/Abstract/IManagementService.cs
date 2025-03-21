using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IManagementService
    {
        IDataResult<List<Management>> GetAll();
        IDataResult<List<Management>> GetAllById(int managementId);
        IDataResult<Management> GetByName(string managementName);
        IDataResult<Management> GetById(int managementId);

        IResult Add(Management management);
        IResult Update(Management management);
        IResult Delete(Management management);
    }
}
