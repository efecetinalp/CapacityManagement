using Core.Entities;

namespace Entities.DTOs
{
    public class DepartmentCapacityDetailDto : IDto
    {
        public int DCapacityId { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public double DTotalCapacity { get; set; }
        public DateTime Date { get; set; }
    }
}
