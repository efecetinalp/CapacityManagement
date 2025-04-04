using Core.Entities;
using System.ComponentModel.DataAnnotations;

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
