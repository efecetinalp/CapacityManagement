﻿using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService : IManager
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<List<Category>> GetAllById(int id);
        IDataResult<Category> GetByName(string name);
        IDataResult<Category> GetById(int categoryId);


        //IResult Add(Category category);
        //IResult Update(Category category);
        //IResult Delete(Category category);
    }
}
