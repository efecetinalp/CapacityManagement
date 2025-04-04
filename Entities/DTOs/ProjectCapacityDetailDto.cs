using Core.Entities;

namespace Entities.DTOs
{
    public class ProjectCapacityDetailDto : IDto
    {
        public int PCapacityId { get; set; }
        public int ProjectId { get; set; }
        public int DepartmentId { get; set; }
        public int ManagementId { get; set; }
        public string ProjectName { get; set; }
        public double PTotalCapacity { get; set; }
        public DateTime Date { get; set; }
    }
}
