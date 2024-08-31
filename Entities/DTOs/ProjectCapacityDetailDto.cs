using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProjectCapacityDetailDto : IDto
    {
        public int PCapacityId { get; set; }
        public int DepartmentId { get; set; }
        public string ProjectName { get; set; }
        public int DCapacityId { get; set; }
        public int PTotalCapacity { get; set; }
        public DateTime PDate { get; set; }
    }
}
