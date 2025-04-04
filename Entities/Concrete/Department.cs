using Core.Entities;

namespace Entities.Concrete
{
    public class Department : IEntity
    {
        public int DepartmentId { get; set; }
        public int ManagementId { get; set; }
        public string DepartmentName { get; set; }
    }
}
