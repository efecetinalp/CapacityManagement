using Business.Abstract;
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
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public IResult Add(Department department)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Department department)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Department department)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Department>> GetAll()
        {
            return new SuccessDataResult<List<Department>>(_departmentDal.GetAll());
        }

        public IDataResult<List<Department>> GetAllByManagementId(int id)
        {
            return new SuccessDataResult<List<Department>>(_departmentDal.GetAll(d => d.ManagementId == id));
        }

        public IDataResult<List<Department>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Department>>(_departmentDal.GetAll(d => d.DepartmentId == id));
        }

        public IDataResult<Department> GetIdByDepartmentName(string name)
        {
            return new SuccessDataResult<Department>(_departmentDal.Get(d => d.DepartmentName == name));
        }
    }
}
