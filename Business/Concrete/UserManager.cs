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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.UserName.Length <= 2)
            {
                return new ErrorResult(Messages.ProjectNameInvalid);
            }

            _userDal.Add(user);
            return new SuccessResult(Messages.ProjectAdded);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.ProjectUpdated);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.ProjectDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == id), Messages.ProjectListed);
        }

        public IDataResult<User> GetByUserName(string username)
        {
            User result = _userDal.Get(u => u.UserName == username);

            if (result != null)
                return new SuccessDataResult<User>(result, Messages.ProjectListed);
            else
                return new ErrorDataResult<User>(result, Messages.EmptyData);

        }
    }
}
