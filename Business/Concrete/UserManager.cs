using Business.Abstract;
using Business.Constants;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(IEntity user)
        {
            _userDal.Add(user as User);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Update(IEntity user)
        {
            _userDal.Update(user as User);
            return new SuccessResult(Messages.UserUpdated);
        }

        public IResult Delete(IEntity user)
        {
            _userDal.Delete(user as User);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == id), Messages.UserListed);
        }

        public IDataResult<User> GetByUserName(string username)
        {
            User result = _userDal.Get(u => u.UserName == username);

            if (result != null)
                return new SuccessDataResult<User>(result, Messages.UserListed);
            else
                return new ErrorDataResult<User>(result, Messages.EmptyData);

        }
    }
}
