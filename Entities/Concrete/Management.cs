using Core.Entities;

namespace Entities.Concrete
{
    public class Management : IEntity
    {
        public int ManagementId { get; set; }
        public string ManagementName { get; set; }
    }
}
