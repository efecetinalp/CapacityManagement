﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Department : IEntity
    {
        public int DepartmentId { get; set; }
        public int ManagementId { get; set; }
        public string DepartmentName { get; set; }
    }
}
