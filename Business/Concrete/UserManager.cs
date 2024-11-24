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

        public List<User> GetAll()
        {
            return new List<User>(_userDal.GetAll());
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
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
