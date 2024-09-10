using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardUI
{
    public class UIRequest
    {
        public int ManagementIndex { get; set; }
        public int DepartmentIndex { get; set; }
        public int CategotryIndex { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
