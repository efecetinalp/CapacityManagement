using Core.Entities;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IManager
    {
        IResult Add(IEntity entity);
        IResult Update(IEntity entity);
        IResult Delete(IEntity entity);
    }
}
