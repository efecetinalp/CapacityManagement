using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ProjectCapacity : IEntity
    {
        public int ProjectCapacityId { get; set; }
        public int ProjectId { get; set; }
        public int PTotalCapacity { get; set; }
        public DateTime Date { get; set; }
    }
}
