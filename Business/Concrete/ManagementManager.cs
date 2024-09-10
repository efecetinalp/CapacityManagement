﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
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
            return new SuccessResult();
        }

        public IResult Update(Management management)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Management management)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Management>> GetAll()
        {
            return new SuccessDataResult<List<Management>>(_managementDal.GetAll());
        }

        public IDataResult<List<Management>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Management>>(_managementDal.GetAll(m => m.ManagementId == id));
        }
    }
}
