﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
