using Core.Entities;

namespace Entities.DTOs
{
    public class ProjectDetailDto : IDto
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string CategoryName { get; set; }
        public string DepartmentName { get; set; }
        public string ManagementName { get; set; }
        public string UserName { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ManagementId { get; set; }
        public int DepartmentId { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
    }
}
