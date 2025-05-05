using Business.Abstract;
using Business.Constants;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ManagementManager : IManagementService
    {
        IManagementDal _managementDal;

        public ManagementManager(IManagementDal managementDal)
        {
            _managementDal = managementDal;
        }

        public IResult Add(IEntity management)
        {
            _managementDal.Add(management as Management);
            return new SuccessResult(Messages.ManagementAdded);
        }

        public IResult Update(IEntity management)
        {
            _managementDal.Update(management as Management);
            return new SuccessResult(Messages.ManagementUpdated);
        }

        public IResult Delete(IEntity management)
        {
            _managementDal.Delete(management as Management);
            return new SuccessResult(Messages.ManagementDeleted);
        }

        public IDataResult<List<Management>> GetAll()
        {
            var result = _managementDal.GetAll();

            if (result != null)
                return new SuccessDataResult<List<Management>>(result, Messages.ManagementListed);
            else
                return new ErrorDataResult<List<Management>>(result, Messages.EmptyData);
        }

        public IDataResult<List<Management>> GetAllSorted(string sort)
        {
            var result = _managementDal.GetAll();
            //if (isAsc)
            //    var result = _managementDal.GetAll().OrderBy(m=>);
            //else
            //    var result = _managementDal.GetAll().OrderByDescending;

            if (result != null)
                return new SuccessDataResult<List<Management>>(result, Messages.ManagementListed);
            else
                return new ErrorDataResult<List<Management>>(result, Messages.EmptyData);
        }

        public IDataResult<List<Management>> GetAllById(int managementId)
        {
            var result = _managementDal.GetAll(m => m.ManagementId == managementId);

            if (result != null)
                return new SuccessDataResult<List<Management>>(result, Messages.ManagementListed);
            else
                return new ErrorDataResult<List<Management>>(result, Messages.EmptyData);
        }

        public IDataResult<Management> GetByName(string managementName)
        {
            Management result = _managementDal.Get(m => m.ManagementName == managementName);

            if (result != null)
                return new SuccessDataResult<Management>(result, Messages.ManagementListed);
            else
                return new ErrorDataResult<Management>(result, Messages.EmptyData);
        }

        public IDataResult<Management> GetById(int managementId)
        {
            Management result = _managementDal.Get(m => m.ManagementId == managementId);

            if (result != null)
                return new SuccessDataResult<Management>(result, Messages.ManagementListed);
            else
                return new ErrorDataResult<Management>(result, Messages.EmptyData);
        }
    }
}
