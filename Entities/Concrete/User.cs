using Core.Entities;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool Admin { get; set; }
        public bool Author { get; set; }
    }
}
