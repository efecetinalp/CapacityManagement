using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService : IManager
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        IDataResult<User> GetByUserName(string username);

        //IResult Add(User user);
        //IResult Update(User user);
        //IResult Delete(User user);
    }
}
