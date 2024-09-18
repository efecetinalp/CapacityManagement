using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ManagementManager : IManagementService
    {
        IManagementDal _managementDal;

        public ManagementManager(IManagementDal managementDal)
        {
            _managementDal = managementDal;
        }

        public IResult Add(Management management)
        {
            _managementDal.Add(management);
            return new SuccessResult(Messages.ManagementAdded);
        }

        public IResult Update(Management management)
        {
            _managementDal.Update(management);
            return new SuccessResult(Messages.ManagementUpdated);
        }

        public IResult Delete(Management management)
        {
            _managementDal.Delete(management);
            return new SuccessResult(Messages.ManagementDeleted);
        }

        public IDataResult<List<Management>> GetAll()
        {
            return new SuccessDataResult<List<Management>>(_managementDal.GetAll());
        }

        public IDataResult<List<Management>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Management>>(_managementDal.GetAll(m => m.ManagementId == id));
        }

        public IDataResult<Management> GetByName(string managementName)
        {
            Management result = _managementDal.Get(m => m.ManagementName == managementName);

            if (result != null)
                return new SuccessDataResult<Management>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<Management>(result, Messages.EmptyData);
        }
    }
}
