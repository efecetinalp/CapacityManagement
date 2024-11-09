using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DepartmentCapacity : IEntity
    {
        [Key]
        public int DCapacityId { get; set; }
        public int DepartmentId { get; set; }
        public double DTotalCapacity { get; set; }
        public DateTime Date { get; set; }
    }
}
