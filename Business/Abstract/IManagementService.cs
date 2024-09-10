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
        IDataResult<List<Management>> GetAllById(int id);

        IResult Add(Management management);
        IResult Update(Management management);
        IResult Delete(Management management);
    }
}
