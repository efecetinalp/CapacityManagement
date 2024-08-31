﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProjectCapacityDal : EfEntityRepositoryBase<ProjectCapacity, CapacityDBContext>, IProjectCapacityDal
    {
        public List<ProjectCapacityDetailDto> GetProjectCapacityDetails(Expression<Func<ProjectCapacityDetailDto, bool>> filter = null)
        {
            using (CapacityDBContext context = new CapacityDBContext())
            {
                var result = from p in context.ProjectCapacities
                             join d in context.DepartmentCapacities on p.DCapacityId equals d.DCapacityId
                             join pt in context.Projects on p.ProjectId equals pt.ProjectId
                             select new ProjectCapacityDetailDto
                             {
                                 PCapacityId = p.ProjectCapacityId,
                                 DepartmentId = d.DepartmentId,
                                 ProjectName = pt.ProjectName,
                                 PTotalCapacity = p.PTotalCapacity,
                                 DCapacityId = d.DCapacityId,
                                 PDate = d.Date
                             };
                return result.Where(filter).ToList();
            }
        }
    }
}
