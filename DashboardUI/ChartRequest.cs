using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardUI
{
    public class ChartRequest
    {
        public List<double> Months { get; set; }
        public List<string> Legends { get; set; }
        public List<List<double>> Series { get; set; }
    }
}
