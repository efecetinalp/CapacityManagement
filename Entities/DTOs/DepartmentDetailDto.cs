using Core.Entities;

namespace Entities.DTOs
{
    public class DepartmentDetailDto : IDto
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string ManagementName { get; set; }
        public int ManagementId { get; set; }
    }
}
