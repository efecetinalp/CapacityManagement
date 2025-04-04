using Core.Entities;

namespace Entities.Concrete
{
    public class ProjectCapacity : IEntity
    {
        public int ProjectCapacityId { get; set; }
        public int ProjectId { get; set; }
        public double PTotalCapacity { get; set; }
        public DateTime Date { get; set; }
    }
}
