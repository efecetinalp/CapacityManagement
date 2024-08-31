using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //root void class
    public interface IResult
    {
        bool Success { get; }
        string Massage { get; }
    }
}
