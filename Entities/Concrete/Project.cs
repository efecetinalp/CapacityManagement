using Core.Entities;

namespace Entities.Concrete
{
    public class Project : IEntity
    {
        public int ProjectId { get; set; }
        public int ManagementId { get; set; }
        public int DepartmentId { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
