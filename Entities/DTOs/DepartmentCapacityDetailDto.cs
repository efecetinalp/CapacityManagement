using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class DepartmentCapacityDetailDto : IDto
    {
        public int DCapacityId { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int DTotalCapacity { get; set; }
        public DateTime Date { get; set; }
    }
}
