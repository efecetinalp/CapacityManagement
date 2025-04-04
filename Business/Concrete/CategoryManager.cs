using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IDataResult<List<Category>> GetAll()
        {
            List<Category> result = _categoryDal.GetAll();

            if (result != null)
                return new SuccessDataResult<List<Category>>(result, Messages.CategoryListed);
            else
                return new ErrorDataResult<List<Category>>(result, Messages.EmptyData);
        }

        public IDataResult<List<Category>> GetAllById(int id)
        {
            List<Category> result = new List<Category>(_categoryDal.GetAll(c => c.CategoryId == id));

            if (result != null)
                return new SuccessDataResult<List<Category>>(result, Messages.CategoryListed);
            else
                return new ErrorDataResult<List<Category>>(result, Messages.EmptyData);
        }

        public IDataResult<Category> GetByName(string name)
        {
            Category result = _categoryDal.Get(c => c.CategoryName == name);

            if (result != null)
                return new SuccessDataResult<Category>(result, Messages.CategoryListed);
            else
                return new ErrorDataResult<Category>(result, Messages.EmptyData);
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            Category result = _categoryDal.Get(c => c.CategoryId == categoryId);

            if (result != null)
                return new SuccessDataResult<Category>(result, Messages.CategoryListed);
            else
                return new ErrorDataResult<Category>(result, Messages.EmptyData);
        }
    }
}
