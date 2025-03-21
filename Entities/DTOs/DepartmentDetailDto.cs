using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
